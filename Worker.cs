using Cronos;
using Easy2PatchBlogPublisher.Models;
using Easy2PatchBlogPublisher.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Easy2PatchBlogPublisher;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IConfiguration _config;
    private readonly CatalogQueryService _queryService;
    private readonly MarkdownGeneratorService _markdownService;
    private readonly GitHubPublisherService _githubService;
    private readonly ContentMigrationService _migrationService;

    private readonly CronExpression _cron;
    private readonly bool _runPilotOnStartup;
    private readonly bool _runMigration;

    public Worker(
        ILogger<Worker> logger,
        IConfiguration config,
        CatalogQueryService queryService,
        MarkdownGeneratorService markdownService,
        GitHubPublisherService githubService,
        ContentMigrationService migrationService)
    {
        _logger           = logger;
        _config           = config;
        _queryService     = queryService;
        _markdownService  = markdownService;
        _githubService    = githubService;
        _migrationService = migrationService;

        var cronExpr = config["Schedule:WeeklyCron"] ?? "0 0 * * 0";
        _cron = CronExpression.Parse(cronExpr, CronFormat.Standard);
        _runPilotOnStartup = config.GetValue<bool>("Schedule:RunPilotOnStartup");
        _runMigration      = config.GetValue<bool>("Blog:RunMigration");
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Easy2Patch Blog Publisher started.");

        _githubService.InitRepoIfNeeded();
        _githubService.EnsureRemote(_config["GitHub:RemoteUrl"]!);

        // One-time blog migration
        if (_runMigration)
        {
            _logger.LogInformation("Running one-time blog migration from {Url}", _config["Blog:SourceUrl"]);
            var migrated = await _migrationService.MigrateAllPagesAsync();
            DisableMigrationFlag();

            if (migrated.Count > 0)
                _githubService.CommitAndPush($"[Migration] Import blog.easy2patch.com ({migrated.Count} pages)", migrated);
        }

        // FAZ 0 pilot: generate sample posts + yearly stats from files + index
        if (_runPilotOnStartup)
        {
            _logger.LogInformation("FAZ 0: Pilot run starting...");
            await RunPilotAsync(stoppingToken);
            DisablePilotFlag();
        }

        while (!stoppingToken.IsCancellationRequested)
        {
            var now  = DateTimeOffset.UtcNow;
            var next = _cron.GetNextOccurrence(now, TimeZoneInfo.Local);

            if (next == null) break;

            var delay = next.Value - now;
            _logger.LogInformation("Next weekly run at {Next} (in {Hours:F1}h)", next, delay.TotalHours);

            await Task.Delay(delay, stoppingToken);

            if (!stoppingToken.IsCancellationRequested)
                await RunWeeklyPublishAsync(DateTime.Today, stoppingToken);
        }
    }

    private async Task RunPilotAsync(CancellationToken ct)
    {
        var sundays        = GetLastNSundays(2);
        var generatedFiles = new List<string>();

        // Generate weekly posts from SQL
        foreach (var sunday in sundays)
        {
            _logger.LogInformation("Generating pilot post for Sunday {Date}", sunday.ToShortDateString());
            var report = await _queryService.GetWeeklyReportAsync(sunday);

            if (report.TotalCount == 0)
            {
                _logger.LogWarning("No data for week of {Date}, skipping.", sunday.ToShortDateString());
                continue;
            }

            var postPath = await _markdownService.GenerateWeeklyPostAsync(report);
            generatedFiles.Add(postPath);
        }

        // Yearly stats built from existing generated Markdown files (not SQL)
        var yearlyStats = BuildYearlyStatsFromFiles(DateTime.Today.Year);
        var yearlyPath  = await _markdownService.GenerateYearlyStatsAsync(yearlyStats);
        generatedFiles.Add(yearlyPath);

        // Global stats: combine yearly + global SQL counts
        var globalStats = await _queryService.GetGlobalStatsAsync();
        globalStats.CurrentWeek   = ISOWeek.GetWeekOfYear(DateTime.Today);
        globalStats.WeeklyAverage = yearlyStats.WeeklyStats.Count > 0
            ? yearlyStats.WeeklyStats.Average(w => w.Total) : 0;

        var (yearSummaries, recentPosts) = BuildBlogIndex();
        globalStats.YearSummaries = yearSummaries;
        globalStats.RecentPosts   = recentPosts;

        if (sundays.Count > 0)
            globalStats.LatestWeek = await _queryService.GetWeeklyReportAsync(sundays[0]);

        var indexPath = await _markdownService.GenerateIndexPageAsync(globalStats);
        generatedFiles.Add(indexPath);

        var jekyllFiles = await GenerateJekyllConfigAsync();
        generatedFiles.AddRange(jekyllFiles);

        var weekNums = sundays
            .Select(s => $"W{ISOWeek.GetWeekOfYear(s.AddDays(-1)):D2}")
            .ToList();
        var msg = $"[FAZ 0 Pilot] Catalog posts: {string.Join(", ", weekNums)} — {generatedFiles.Count} files";
        _githubService.CommitAndPush(msg, generatedFiles);

        _logger.LogInformation("FAZ 0 Pilot complete. {Count} files published.", generatedFiles.Count);
    }

    private async Task RunWeeklyPublishAsync(DateTime today, CancellationToken ct)
    {
        _logger.LogInformation("Weekly publish started for {Date}", today.ToShortDateString());

        var sunday         = today.DayOfWeek == DayOfWeek.Sunday ? today : today;
        var report         = await _queryService.GetWeeklyReportAsync(sunday);
        var generatedFiles = new List<string>();

        generatedFiles.Add(await _markdownService.GenerateWeeklyPostAsync(report));

        // Yearly stats from files (all previously generated + this new one)
        var yearlyStats = BuildYearlyStatsFromFiles(today.Year);
        generatedFiles.Add(await _markdownService.GenerateYearlyStatsAsync(yearlyStats));

        var globalStats = await _queryService.GetGlobalStatsAsync();
        globalStats.CurrentWeek   = ISOWeek.GetWeekOfYear(today);
        globalStats.LatestWeek    = report;
        globalStats.WeeklyAverage = yearlyStats.WeeklyStats.Count > 0
            ? yearlyStats.WeeklyStats.Average(w => w.Total) : 0;

        var (yearSummaries, recentPosts) = BuildBlogIndex();
        globalStats.YearSummaries = yearSummaries;
        globalStats.RecentPosts   = recentPosts;

        generatedFiles.Add(await _markdownService.GenerateIndexPageAsync(globalStats));

        var msg = $"📦 Catalog Update - Week {report.WeekNumber:D2}, {report.Year} ({report.TotalCount} packages)";
        _githubService.CommitAndPush(msg, generatedFiles);

        _logger.LogInformation("Weekly publish complete: {Total} packages.", report.TotalCount);
    }

    // ---------------------------------------------------------------
    // Build multi-year summaries + recent posts from all blog files on disk
    // (docs/blog/*.md) — newest first
    // ---------------------------------------------------------------
    private (List<YearSummary> summaries, List<BlogPostEntry> recentPosts) BuildBlogIndex()
    {
        var docsPath = Path.Combine(_config["GitHub:RepoPath"]!, "docs");
        var blogDir  = Path.Combine(docsPath, "blog");

        // Only catalog-update blog posts (those with real dates from URL slugs)
        // Exclude articles/stats pages that have no real date (they got today's date)
        var blogPosts = new List<BlogPostEntry>();

        if (Directory.Exists(blogDir))
        {
            foreach (var file in Directory.GetFiles(blogDir, "*.md").OrderBy(f => f))
            {
                var (title, date) = ReadFrontmatterTitleDate(file);
                if (date == null) continue;

                // Skip articles/stats pages that ended up with today's date (no real date in filename)
                var fileName = Path.GetFileNameWithoutExtension(file);
                if (fileName.StartsWith("articles-") || fileName.StartsWith("article-page") ||
                    fileName.StartsWith("weekly-statistics") || fileName.StartsWith("new-products"))
                    continue;

                var slug = fileName;
                var url  = $"/blog/{slug}/";
                blogPosts.Add(new BlogPostEntry { Title = title, Date = date.Value, Url = url });
            }
        }

        // Generated catalog posts from docs/catalogs/YYYY/*.md — these are the authoritative weekly posts
        var catalogPosts = new List<BlogPostEntry>();
        var catalogsDir  = Path.Combine(docsPath, "catalogs");
        if (Directory.Exists(catalogsDir))
        {
            foreach (var yearDir in Directory.GetDirectories(catalogsDir).OrderByDescending(d => d))
            {
                foreach (var file in Directory.GetFiles(yearDir, "*.md").OrderByDescending(f => f))
                {
                    var (title, date) = ReadFrontmatterTitleDate(file);
                    if (date == null) continue;

                    var yearStr = Path.GetFileName(yearDir);
                    var slug    = Path.GetFileNameWithoutExtension(file);
                    var url     = $"/catalogs/{yearStr}/{slug}/";
                    catalogPosts.Add(new BlogPostEntry { Title = title, Date = date.Value, Url = url });
                }
            }
        }

        // Deduplicate blog posts by date — if a catalog post exists for a date, skip the blog mirror
        var catalogDates = new HashSet<DateTime>(catalogPosts.Select(p => p.Date.Date));
        var filteredBlog = blogPosts.Where(p => !catalogDates.Contains(p.Date.Date)).ToList();

        // Merge: catalog posts first (most recent), then older blog-only posts
        var allPosts = catalogPosts
            .Concat(filteredBlog)
            .OrderByDescending(p => p.Date)
            .ToList();

        // Year summaries — count blog catalog posts per year
        var allForYears = catalogPosts.Concat(filteredBlog).ToList();
        var yearDict = allForYears
            .GroupBy(p => p.Date.Year)
            .Select(g => new YearSummary
            {
                Year      = g.Key,
                PostCount = g.Count(),
                Total     = 0
            })
            .OrderByDescending(y => y.Year)
            .ToList();

        // Fill Total packages from yearly stats file (2026 already has one)
        foreach (var ys in yearDict)
        {
            var statsFile = Path.Combine(docsPath, "stats", $"yearly-{ys.Year}.md");
            if (File.Exists(statsFile))
                ys.Total = ReadTotalFromYearlyStats(statsFile);
        }

        return (yearDict, allPosts.Take(30).ToList());
    }

    private static (string title, DateTime? date) ReadFrontmatterTitleDate(string filePath)
    {
        string title = Path.GetFileNameWithoutExtension(filePath);
        DateTime? date = null;
        try
        {
            var lines  = File.ReadAllLines(filePath);
            bool inFm  = false;
            foreach (var line in lines)
            {
                if (line.TrimStart().StartsWith("---")) { inFm = !inFm; continue; }
                if (!inFm) break;
                if (line.StartsWith("title:"))
                    title = line["title:".Length..].Trim().Trim('"').Trim('\'');
                else if (line.StartsWith("date:"))
                {
                    var ds = line["date:".Length..].Trim().Split(' ')[0];
                    if (DateTime.TryParse(ds, out var d)) date = d;
                }
            }
        }
        catch { }
        return (title, date);
    }

    private static int ReadTotalFromYearlyStats(string filePath)
    {
        // Looks for "Total Updates | NNN" in the stats table
        try
        {
            foreach (var line in File.ReadLines(filePath))
            {
                // Match: | **NNN** | or Total: NNN
                var m = Regex.Match(line, @"\|\s*\*\*(\d+)\*\*\s*\|");
                if (m.Success && int.TryParse(m.Groups[1].Value, out int n))
                    return n;
            }
        }
        catch { }
        return 0;
    }

    // ---------------------------------------------------------------
    // Build YearlyStats by parsing the Markdown files already on disk
    // (docs/catalogs/YYYY/*.md)
    // ---------------------------------------------------------------
    private YearlyStats BuildYearlyStatsFromFiles(int year)
    {
        var stats      = new YearlyStats { Year = year };
        var calendar   = CultureInfo.InvariantCulture.Calendar;
        var weekDict   = new Dictionary<int, WeekStat>();
        var pubDict    = new Dictionary<string, int>();
        var monthDict  = new Dictionary<int, int>();

        var docsPath  = Path.Combine(_config["GitHub:RepoPath"]!, "docs");
        var yearDir   = Path.Combine(docsPath, "catalogs", year.ToString());

        if (!Directory.Exists(yearDir))
        {
            _logger.LogWarning("No catalog directory for year {Year}: {Dir}", year, yearDir);
            return stats;
        }

        // Each file: YYYY-MM-DD-week-WW.md
        foreach (var file in Directory.GetFiles(yearDir, "*.md").OrderBy(f => f))
        {
            var name  = Path.GetFileNameWithoutExtension(file);
            var match = Regex.Match(name, @"^(\d{4})-(\d{2})-(\d{2})-week-(\d{2})$");
            if (!match.Success) continue;

            if (!DateTime.TryParse($"{match.Groups[1]}-{match.Groups[2]}-{match.Groups[3]}",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out var postDate))
                continue;

            int wn = int.Parse(match.Groups[4].Value);

            // Parse fix/update/new counts from the Markdown table header lines
            var (fixCount, updateCount, newCount) = ParseCountsFromMarkdown(file);

            if (!weekDict.TryGetValue(wn, out var ws))
            {
                ws = new WeekStat { WeekNumber = wn, PostDate = postDate };
                weekDict[wn] = ws;
            }
            ws.FixCount    += fixCount;
            ws.UpdateCount += updateCount;
            ws.NewCount    += newCount;

            stats.TotalFixes       += fixCount;
            stats.TotalUpdates     += updateCount;
            stats.TotalNewPackages += newCount;
            stats.TotalPackages    += fixCount + updateCount + newCount;

            monthDict.TryGetValue(postDate.Month, out int mc);
            monthDict[postDate.Month] = mc + fixCount + updateCount + newCount;

            // Parse manufacturers from the Updated Software table
            ParseManufacturersFromMarkdown(file, pubDict);
        }

        stats.WeeklyStats   = weekDict.Values.OrderBy(w => w.WeekNumber).ToList();
        stats.TopPublishers = pubDict
            .Select(kv => new PublisherStat { Publisher = kv.Key, Count = kv.Value })
            .OrderByDescending(x => x.Count).Take(10).ToList();
        stats.MonthlyStats = monthDict
            .Select(kv => new MonthlyStat { Month = kv.Key, Count = kv.Value })
            .OrderBy(x => x.Month).ToList();
        stats.TotalPublishers = pubDict.Count;

        _logger.LogInformation("Built yearly stats from files: {Year} — {Total} packages, {Weeks} weeks",
            year, stats.TotalPackages, stats.WeeklyStats.Count);

        return stats;
    }

    // Parse Fix/Update/NewPackage counts from the Markdown file's section headers
    // Looks for "## 🔧 Fixes", "## 🔄 Updates", "## ✨ New Packages" tables
    private static (int fix, int update, int newPkg) ParseCountsFromMarkdown(string filePath)
    {
        int fix = 0, update = 0, newPkg = 0;

        try
        {
            var lines    = File.ReadAllLines(filePath);
            var section  = "";
            foreach (var line in lines)
            {
                if (line.StartsWith("## 🔧 Fixes",     StringComparison.OrdinalIgnoreCase)) { section = "fix";    continue; }
                if (line.StartsWith("## 🔄 Updates",   StringComparison.OrdinalIgnoreCase)) { section = "update"; continue; }
                if (line.StartsWith("## ✨ New Pack",  StringComparison.OrdinalIgnoreCase)) { section = "new";    continue; }
                if (line.StartsWith("## ") && !string.IsNullOrEmpty(section))              { section = "";       continue; }
                if (line.StartsWith("---"))                                                 { section = "";       continue; }

                // Count table data rows (not header or separator)
                if (!string.IsNullOrEmpty(section) && line.StartsWith("|") && !line.Contains("---") &&
                    !line.Contains("Manufacturer") && !line.Contains("Software"))
                {
                    switch (section)
                    {
                        case "fix":    fix++;    break;
                        case "update": update++; break;
                        case "new":    newPkg++; break;
                    }
                }
            }
        }
        catch { }

        return (fix, update, newPkg);
    }

    // Parse manufacturer names from the "## Updated Software" table
    private static void ParseManufacturersFromMarkdown(string filePath, Dictionary<string, int> pubDict)
    {
        try
        {
            var lines   = File.ReadAllLines(filePath);
            bool inTable = false;

            foreach (var line in lines)
            {
                if (line.StartsWith("## Updated Software", StringComparison.OrdinalIgnoreCase))
                {
                    inTable = true;
                    continue;
                }
                if (inTable && line.StartsWith("## "))
                    break;

                if (inTable && line.StartsWith("|") && !line.Contains("---") &&
                    !line.Contains("Manufacturer"))
                {
                    // | Manufacturer | Software |
                    var parts = line.Split('|', StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 1)
                    {
                        var mfg = parts[0].Trim();
                        if (!string.IsNullOrWhiteSpace(mfg))
                        {
                            pubDict.TryGetValue(mfg, out int c);
                            pubDict[mfg] = c + 1;
                        }
                    }
                }
            }
        }
        catch { }
    }

    private async Task<List<string>> GenerateJekyllConfigAsync()
    {
        var files    = new List<string>();
        var repoPath = _config["GitHub:RepoPath"]!;

        var configPath = Path.Combine(repoPath, "docs", "_config.yml");
        await File.WriteAllTextAsync(configPath,
            """
            title: Easy2Patch Catalog
            description: Third-party software update catalog for enterprise patch management
            baseurl: "/easy2patchblog"
            url: "https://direnconen.github.io"

            theme: minima

            plugins:
              - jekyll-feed
              - jekyll-sitemap

            markdown: kramdown
            highlighter: rouge

            exclude:
              - obj/
              - bin/
              - "*.csproj"
              - "*.cs"
              - Services/
              - Models/
              - Templates/
              - Worker.cs
              - Program.cs
            """);
        files.Add(configPath);

        var workflowDir = Path.Combine(repoPath, ".github", "workflows");
        Directory.CreateDirectory(workflowDir);
        var workflowPath = Path.Combine(workflowDir, "pages.yml");
        await File.WriteAllTextAsync(workflowPath,
            """
            name: Deploy GitHub Pages

            on:
              push:
                branches: [master]
              workflow_dispatch:

            permissions:
              contents: read
              pages: write
              id-token: write

            concurrency:
              group: "pages"
              cancel-in-progress: false

            jobs:
              build:
                runs-on: ubuntu-latest
                steps:
                  - uses: actions/checkout@v4
                  - uses: actions/configure-pages@v5
                  - uses: actions/jekyll-build-pages@v1
                    with:
                      source: ./docs
                      destination: ./_site
                  - uses: actions/upload-pages-artifact@v3

              deploy:
                environment:
                  name: github-pages
                  url: ${{ steps.deployment.outputs.page_url }}
                runs-on: ubuntu-latest
                needs: build
                steps:
                  - id: deployment
                    uses: actions/deploy-pages@v4
            """);
        files.Add(workflowPath);

        return files;
    }

    private static List<DateTime> GetLastNSundays(int n)
    {
        var sundays = new List<DateTime>();
        var date    = DateTime.Today;
        while (date.DayOfWeek != DayOfWeek.Sunday)
            date = date.AddDays(-1);
        for (int i = 0; i < n; i++)
        {
            sundays.Add(date);
            date = date.AddDays(-7);
        }
        return sundays;
    }

    private void DisablePilotFlag()
    {
        try
        {
            var path = Path.Combine(_config["GitHub:RepoPath"]!, "appsettings.json");
            var json = File.ReadAllText(path);
            json = json.Replace("\"RunPilotOnStartup\": true", "\"RunPilotOnStartup\": false");
            File.WriteAllText(path, json);
            _logger.LogInformation("RunPilotOnStartup disabled.");
        }
        catch (Exception ex) { _logger.LogWarning(ex, "Could not disable RunPilotOnStartup."); }
    }

    private void DisableMigrationFlag()
    {
        try
        {
            var path = Path.Combine(_config["GitHub:RepoPath"]!, "appsettings.json");
            var json = File.ReadAllText(path);
            json = json.Replace("\"RunMigration\": true", "\"RunMigration\": false");
            File.WriteAllText(path, json);
            _logger.LogInformation("RunMigration disabled.");
        }
        catch (Exception ex) { _logger.LogWarning(ex, "Could not disable RunMigration."); }
    }
}
