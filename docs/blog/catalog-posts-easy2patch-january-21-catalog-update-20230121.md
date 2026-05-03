---
layout: post
title: "21 January 2023 Catalog Update - Easy2Patch"
date: 2023-01-21
categories: [blog]
---

Our Easy2Patch catalog with **20230121** (Catalog version **2.1.8**) is available to our customers.

This week **21** software updates have been provided in the E2P catalog. We support **107** products of **145** individual manufacturers in total. We are updating **216** products with 32/64-bit and language options.

Üretici

Yazilim

AmazonAmazon Corretto 17.0.6

AmazonAmazon Corretto 19.0.2.7

ApacheApache Tomcat 10.1.5

ApacheApache Tomcat 9.0.71

CCleanerCCleaner Slim 6.8.0

EvernoteEvernote 10.52.8

Filezilla ProjectFileZilla Server 1.6.4

MicrosoftEdge WebView2 Runtime 109.0.1518.61

MicrosoftMicrosoft Edge 109.0.1518.61

MozillaMozilla Firefox 109.0.0

MozillaMozilla Firefox ESR 102.7.0

NlitesoftNTLite 2.3.9.9039

OperaOpera 94.0.4606.76

OracleJava SE Development Kit 17.0.6

OracleJava SE Development Kit 19.0.2

OracleMySQL Connector ODBC 8.0.32

OracleOracle Java 8 8.361

TeamViewerTeamViewer 15.37.8

uvnc bvbaUltraVNC 1.4.0.6

WiresharkWireshark 4.0.3

Zoom Video CommunicationsZoom Desktop Client 5.13.5

### 


Amazon Corretto 17.0.6

> More Info: [https://github.com/corretto/corretto-17/blob/release-17.0.6.10.1/CHANGELOG.md](https://github.com/corretto/corretto-17/blob/release-17.0.6.10.1/CHANGELOG.md)
> Support Info: [https://aws.amazon.com/corretto/faqs/](https://aws.amazon.com/corretto/faqs/)
> Change Log for Amazon Corretto 17 The following sections describe the changes for each release of Amazon Corretto 17. Corretto version: 17.0.6.10.1 Release Date: January 17, 2023 Target Platforms 1 RPM-based Linux using glibc 2.12 or later, x86, x86\_64 Debian-based Linux using glibc 2.12 or later, x86, x86\_64 RPM-based Linux using glibc 2.17 or later, aarch64 Debian-based Linux using glibc 2.17 or later, aarch64 Alpine-based Linux, x86\_64 Windows 10 or later, x86\_64 macos 10.15 and later, x86\_64 macos 11.0 and later, aarch64

### 


Amazon Corretto 19.0.2.7

> More Info: [https://github.com/corretto/corretto-19/blob/develop/CHANGELOG.md](https://github.com/corretto/corretto-19/blob/develop/CHANGELOG.md)
> Support Info: [https://aws.amazon.com/corretto/faqs/](https://aws.amazon.com/corretto/faqs/)
> Change Log for Amazon Corretto 19 The following sections describe the changes for each release of Amazon Corretto 19. Corretto version: 19.0.2.7.1 Release Date: January 17, 2023 Target Platforms 1 RPM-based Linux using glibc 2.12 or later, x86\_64 Debian-based Linux using glibc 2.12 or later, x86\_64 RPM-based Linux using glibc 2.17 or later, aarch64 Debian-based Linux using glibc 2.17 or later, aarch64 Alpine-based Linux, x86\_64 Windows 10 or later, x86\_64 macos 10.15 and later, x86\_64 macos 11.0 and later, aarch64

### 


Apache Tomcat 10.1.5

> More Info: [https://downloads.apache.org/tomcat/tomcat-10/v10.1.5/RELEASE-NOTES](https://downloads.apache.org/tomcat/tomcat-10/v10.1.5/RELEASE-NOTES)
> Support Info: [https://tomcat.apache.org/tomcat-10.1-doc/changelog.html](https://tomcat.apache.org/tomcat-10.1-doc/changelog.html)
> Changelog Tomcat 10.1.5 (markt) Catalina Fix: 66388: Correct a regression in the refactoring that replaced the use of the URL constructors. The regression broke lookups for resources that contained one or more characters in their name that required escaping when used in a URI path. (markt) Fix: 66392: Change the default value of AccessLogValue's file encoding to UTF-8 and update documentation. (lihan) Fix: 66393: Align ExtendedAccessLogValve's x-P(XXX) with the documentation. (lihan) Coyote Fix: When resetting an HTTP/2 stream because the final response has been generated before the request has been fully read, use the HTTP/2 error code NO\_ERROR so that client does not discard the response. Based on a suggestion by Lorenzo Dalla Vecchia. (markt) Fix: 66385: Correct a bug in HTTP/2 where a non-blocking read for a new frame with the NIO2 connector was incorrectly made using the read timeout leading to unexpected stream closure. (markt) Jasper Fix: 66370: Change the default of the org.apache.el.GET\_CLASSLOADER\_USE\_PRIVILEGED system property to true unless the EL library is running on Tomcat in which case the default remains false as the EL library is already called from within a privileged block and skipping the unnecessary privileged block improves performance. (markt)

### 


Apache Tomcat 9.0.71

> More Info: [https://downloads.apache.org/tomcat/tomcat-9/v9.0.71/RELEASE-NOTES](https://downloads.apache.org/tomcat/tomcat-9/v9.0.71/RELEASE-NOTES)
> Support Info: [https://tomcat.apache.org/tomcat-9.0-doc/changelog.html](https://tomcat.apache.org/tomcat-9.0-doc/changelog.html)
> Tomcat 9.0.71 (remm) Catalina Fix: 66388: Correct a regression in the refactoring that replaced the use of the URL constructors. The regression broke lookups for resources that contained one or more characters in their name that required escaping when used in a URI path. (markt) Fix: 66392: Change the default value of AccessLogValue's file encoding to UTF-8 and update documentation. (lihan) Fix: 66393: Align ExtendedAccessLogValve's x-P(XXX) with the documentation. (lihan) Coyote Fix: When resetting an HTTP/2 stream because the final response has been generated before the request has been fully read, use the HTTP/2 error code NO\_ERROR so that client does not discard the response. Based on a suggestion by Lorenzo Dalla Vecchia. (markt) Fix: 66196: Align HTTP/1.1 with HTTP/2 and throw an exception when attempting to commit a response with an header value that includes one or more characters with a code point above 255. (markt) Fix: 66385: Correct a bug in HTTP/2 where a non-blocking read for a new frame with the NIO2 connector was incorrectly made using the read timeout leading to unexpected stream closure. (markt) Jasper Fix: 66370: Change the default of the org.apache.el.GET\_CLASSLOADER\_USE\_PRIVILEGED system property to true unless the EL library is running on Tomcat in which case the default remains false as the EL library is already called from within a privileged block and skipping the unnecessary privileged block improves performance. (markt)

### 


CCleaner Slim 6.8.0

> More Info: [https://www.ccleaner.com/ccleaner/release-notes](https://www.ccleaner.com/ccleaner/release-notes)
> Support Info: [https://support.piriform.com/hc/en-us](https://support.piriform.com/hc/en-us)
> Release Notes v6.08.10255 (18 Jan 2023) Taking the hassle out of PC maintenance In Driver Updater, we've added some new information next to the progress bar to give you realtime information when installing new updates You can now see what stage each driver update is at Fixing bugs We fixed an issue where crashes could occur after cleaning a closed browser In Driver Updater, we fixed alignment issues with text in some languages In Software Updater, we aligned how errors are shown

### 


Edge WebView2 Runtime 109.0.1518.61

> More Info: [https://docs.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel](https://docs.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel)
> Support Info: [https://docs.microsoft.com/en-us/microsoft-edge/webview2/](https://docs.microsoft.com/en-us/microsoft-edge/webview2/)
> Version 109.0.1518.61: January 19, 2023 Fixed various bugs and performance issues. Stable channel security updates are listed here. Version 109.0.1518.55: January 15, 2023 Fixed various bugs and performance issues. Version 109.0.1518.52: January 13, 2023 Fixed various bugs and performance issues. Stable channel security updates are listed here.

### 


Evernote 10.52.8

> More Info: [https://help.evernote.com/hc/en-us/articles/360058361833](https://help.evernote.com/hc/en-us/articles/360058361833)
> Support Info: [https://help.evernote.com/hc/en-us](https://help.evernote.com/hc/en-us)
> The most recent version is 10.51.7. Released January 5, 2022. Evernote for Windows 10.51.7 is available now from the Windows Store, or as a direct download version from our website. If you're already running the direct download version, you do not need to take any action and will see an automatic update soon. NEW Introducing backlinks! Now you can see which notes link to the one you're working in, so it's easier to connect ideas and keep your information organized. To see older release notes, visit Previous release notes for Evernote for Windows.

### 


FileZilla Server 1.6.4

> More Info: [https://filezilla-project.org/versions.php?type=server](https://filezilla-project.org/versions.php?type=server)
> Support Info: [https://filezilla-project.org/index.php](https://filezilla-project.org/index.php)
> 1.6.4 (2023-01-18) Bugfixes and minor changes: Fixed a deadlock if sessions destroyed during ongoing authentication Fixed issues with the ABOR command Fixed a crash in the converter for old 0.9.x configurations 1.6.1 (2022-12-07) Bugfixes and minor changes: MSW: Fixed an installation issue due to a service handle not being closed

### 


Java SE Development Kit 17.0.6

> More Info: [https://www.oracle.com/java/technologies/javase/17u-relnotes.html](https://www.oracle.com/java/technologies/javase/17u-relnotes.html)
> Support Info: [https://www.oracle.com/java/technologies/downloads/#jdk17-windows](https://www.oracle.com/java/technologies/downloads/#jdk17-windows)
> Java™ SE Development Kit 17.0.6 (JDK 17.0.6) January 17, 2023 The full version string for this update release is 17.0.6+9 (where "+" means "build"). The version number is 17.0.6. IANA TZ Data 2022d, 2022e, 2022f JDK 17.0.6 contains IANA time zone data 2022d, 2022e, 2022f. Palestine transitions are now Saturdays at 02:00. Simplify three Ukraine zones into one. Jordan and Syria switch from +02/+03 with DST to year-round +03. Mexico will no longer observe DST except near the US border. Chihuahua moves to year-round -06 on 2022-10-30. Fiji no longer observes DST. Move links to 'backward'. In vanguard form, GMT is now a Zone and Etc/GMT a link. zic now supports links to links, and vanguard form uses this. Simplify four Ontario zones. Fix a Y2438 bug when reading TZif data. Enable 64-bit time\_t on 32-bit glibc platforms. Omit large-file support when no longer needed. In C code, use some C23 features if available. Remove no-longer-needed workaround for Qt bug 53071.

### 


Java SE Development Kit 19.0.2

> More Info: [https://www.oracle.com/java/technologies/javase/19u-relnotes.html](https://www.oracle.com/java/technologies/javase/19u-relnotes.html)
> Support Info: [https://www.oracle.com/java/technologies/downloads/#jdk19-windows](https://www.oracle.com/java/technologies/downloads/#jdk19-windows)
> Java™ SE Development Kit 19.0.2 (JDK 19.0.2) January 17, 2023 The full version string for this update release is 19.0.2+7 (where "+" means "build"). The version number is 19.0.2. IANA TZ Data 2022d, 2022e, 2022f JDK 19.0.2 contains IANA time zone data 2022d, 2022e, 2022f. Palestine transitions are now Saturdays at 02:00. Simplify three Ukraine zones into one. Jordan and Syria switch from +02/+03 with DST to year-round +03. Mexico will no longer observe DST except near the US border. Chihuahua moves to year-round -06 on 2022-10-30. Fiji no longer observes DST. Move links to 'backward'. In vanguard form, GMT is now a Zone and Etc/GMT a link. zic now supports links to links, and vanguard form uses this. Simplify four Ontario zones. Fix a Y2438 bug when reading TZif data. Enable 64-bit time\_t on 32-bit glibc platforms. Omit large-file support when no longer needed. In C code, use some C23 features if available. Remove no-longer-needed workaround for Qt bug 53071.

### 


Microsoft Edge 109.0.1518.61

> More Info: [https://docs.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel](https://docs.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel)
> Support Info: [https://support.microsoft.com/en-us/microsoft-edge](https://support.microsoft.com/en-us/microsoft-edge)
> Version 109.0.1518.61: January 19, 2023 Fixed various bugs and performance issues. Stable channel security updates are listed here. Version 109.0.1518.55: January 15, 2023 Fixed various bugs and performance issues. Version 109.0.1518.52: January 13, 2023 Fixed various bugs and performance issues. Stable channel security updates are listed here.

### 


Mozilla Firefox 109.0.0

> More Info: [https://www.mozilla.org/en-US/firefox/109.0/releasenotes/](https://www.mozilla.org/en-US/firefox/109.0/releasenotes/)
> Support Info: [https://www.mozilla.org/en-US/security/advisories/mfsa2023-01/](https://www.mozilla.org/en-US/security/advisories/mfsa2023-01/)
> 109.0 Firefox Release January 17, 2023 Version 109.0, first offered to Release channel users on January 17, 2023 New Manifest Version 3 (MV3) extension support is now enabled by default (MV2 remains enabled/supported). This major update also ushers an exciting user interface change in the form of the new extensions button. The Arbitrary Code Guard exploit protection has been enabled in the media playback utility processes, improving security for Windows users. The native HTML date picker for date and datetime inputs can now be used with a keyboard alone, improving its accessibility for screen reader users. Users with limited mobility can also now use common keyboard shortcuts to navigate the calendar grid and month selection spinners. Firefox builds in the Spanish from Spain (es-ES) and Spanish from Argentina (es-AR) locales now come with a built-in dictionary for the Firefox spellchecker. Fixed Various security fixes. Changed Effective on January 16, Colorways will no longer be in Firefox. Users will still be able to access saved and active Colorways from the Add-ons and themes menu option. On macOS, Ctrl or Cmd + trackpad or mouse wheel now scrolls the page instead of zooming. This avoids accidental zooming and matches the behavior of other web browsers on macOS. The Recently Closed section of Firefox View now equips users with the ability to manually close/remove url links from the list.

### 


Mozilla Firefox ESR 102.7.0

> More Info: [https://www.mozilla.org/en-US/firefox/102.7.0/releasenotes/](https://www.mozilla.org/en-US/firefox/102.7.0/releasenotes/)
> Support Info: [https://www.mozilla.org/en-US/security/advisories/mfsa2023-02/](https://www.mozilla.org/en-US/security/advisories/mfsa2023-02/)
> 102.7.0 Firefox ESR January 17, 2023 Version 102.7.0, first offered to ESR channel users on January 17, 2023 Fixed Various stability, functionality, and security fixes.

### 


MySQL Connector ODBC 8.0.32

> More Info: [https://dev.mysql.com/doc/relnotes/connector-odbc/en/](https://dev.mysql.com/doc/relnotes/connector-odbc/en/)
> Support Info: [https://dev.mysql.com/downloads/connector/odbc/](https://dev.mysql.com/downloads/connector/odbc/)
> Bugs Fixed Adding a 64-bit MySQL ODBC ANSI System Data Source via the ODBC Data Source Administrator would yield this error while testing the connection via the GUI: "Connection failed with the following error: [MySQL]ODBC 8.0(a) Driver]String data, right truncated.[010040]." (Bug #34786939) Upgraded Cyrus SASL to version 2.1.28, which has been publicly reported as not vulnerable to CVE-2022-24407. (Bug #34680978) SQLColumns() would use prepared statements with NO\_SSPS=1. (Bug #108126, Bug #34643065) The MySQL ODBC driver would report the incorrect DATA\_TYPE value for DATETIME when calling SQLColumns(). The correct concise type for DATETIME is SQL\_TYPE\_TIMESTAMP, and this is now used instead of the verbose type SQL\_DATETIME. (Bug #107235, Bug #34291904)

### 


NTLite 2.3.9.9039

> More Info: [https://www.ntlite.com/changelog/](https://www.ntlite.com/changelog/)
> Support Info: [https://www.ntlite.com/support/](https://www.ntlite.com/support/)
> 2.3.9.9039 UPGRADE Components: ‘OOBE’ removal leftovers with newer updates Components: ‘Windows Media Player’ File Explorer thumbnails generation moved to Codecs removal Components: ‘MobilePC Sensors’ not needed for the Xbox app Settings: ‘Cloud optimized content’ option includes more policie UI-Translation: Thanks for French (tistou77), Chinese Simplified (Gskening), Romanian (Coman) FIX Updates: .NET Framework 3.5 enabling on an isolated WIM file (outside of ISO file structure) was causing Windows Update redownloading an already integrated cumulative update Updates: Retry download updates list after blocked connection without resetting the tool UI: Select All button on Updates page wasn’t working without first clicking on a grid

### 


Opera 94.0.4606.76

> More Info: [https://blogs.opera.com/desktop/changelog-for-94/](https://blogs.opera.com/desktop/changelog-for-94/)
> Support Info: [https://www.opera.com/help](https://www.opera.com/help)
> 94.0.4606.76 – 2023-01-19 blog post DNA-104276 News categories layers messed up in other languages

### 


Oracle Java 8 8.361

> More Info: [https://www.oracle.com/java/technologies/javase/8u361-relnotes.html](https://www.oracle.com/java/technologies/javase/8u361-relnotes.html)
> Support Info: [http://www.java.com/en/download/support.jsp](http://www.java.com/en/download/support.jsp)
> Changes in Java SE 8u361 b31 Bug Fixes BugId Category Subcategory Summary JDK-8205959 core-libs java.net Do not restart close if errno is EINTR JDK-8280890 security-libs java.security Cannot use '-Djava.system.class.loader' with class loader in signed JAR JDK-8299628 (Confidential) javafx graphics BMP top-down images fail to load after JDK-8289336 JDK-8297804 core-libs java.time (tz) Update Timezone Data to 2022g

### 


TeamViewer 15.37.8

> More Info: [https://community.teamviewer.com/English/categories/change-logs](https://community.teamviewer.com/English/categories/change-logs)
> Support Info: [https://www.teamviewer.com/en/support/documents/](https://www.teamviewer.com/en/support/documents/)
> [Windows] v15.37.8 JeanK JeanK Posts: 6,491 Community Manager 🌍 January 17 Operating system: Windows Version: 15.37.8 Release date: 2023-01-17 Bugfixes image.png Fixed a bug that prevented changing connection modes on the Remote Control tab in certain circumstances.

### 


UltraVNC 1.4.0.6

> More Info: [https://uvnc.com/downloads/ultravnc.html](https://uvnc.com/downloads/ultravnc.html)
> Support Info: [https://forum.uvnc.com/](https://forum.uvnc.com/)
> CHANGES 1.4.0.6 some parameters are not saved 1.4.0.5 internal 1.4.0.4 internal 1.4.0.3 client-name-bigger-then-40-chars-crash-server 1.4.0.2 DSMplugin-crash-64bit-fix 1.4.0.1 Viewer to client inital message fix 1.4.0.0 removed cloud connect for main, stay in development clipboard update-certificat-2022-2025-part2

### 


Wireshark 4.0.3

> More Info: [https://www.wireshark.org/news/20221004.html](https://www.wireshark.org/news/20221004.html)
> Support Info: [https://www.wireshark.org/docs/](https://www.wireshark.org/docs/)
> Wireshark 4.0.3 and 3.6.11 Released January 18, 2023 Wireshark 4.0.3 and 3.6.11 have been released. Installers for Windows, Mac OS X 10.14 and later, and source code are now available. In 4.0.3 Several vulnerabilities have been fixed. See the release notes for details. For a complete list of changes, please refer to the 4.0.3 release notes. In 3.6.11 Several vulnerabilities have been fixed. See the release notes for details. For a complete list of changes, please refer to the 3.6.11 release notes. Official releases are available right now from the download page.

### 


Zoom Desktop Client 5.13.5

> More Info: [https://support.zoom.us/hc/en-us/articles/201361953-Release-notes-for-Windows](https://support.zoom.us/hc/en-us/articles/201361953-Release-notes-for-Windows)
> Support Info: [https://support.zoom.us/hc/en-us](https://support.zoom.us/hc/en-us)
> Current Release January 16, 2023 version 5.13.5 (12053) Download type: Manual Download here: Download Center Changes to existing features New meeting chat experience default setting The default for the New meeting chat experience setting is changed to on for most accounts.

[PreviousEasy2Patch January 28 Catalog Update #20230128](/catalog-posts/easy2patch-january-28-catalog-update-20230128)[NextEasy2Patch January 14 Catalog Update #20230114](/catalog-posts/easy2patch-january-14-catalog-update-20230114)
Last updated <time data-visual-test="transparent" datetime="2023-05-07T18:19:22.000Z" data-state="closed">2 years ago</time>
