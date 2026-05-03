---
layout: post
title: "10 February 2024 Catalog Update - Easy2Patch"
date: 2024-02-10
categories: [blog]
---

Our catalog with **#20240210** (Catalog version **3.4.154** ) is available to our **Easy2Patch** customers.

This week, **29** software updates are provided in the E2P catalog. We support **314** products of **216** individual manufacturers in total. We are updating **421** products with 32/64-bit and language options.

Manufacturer

Software

AmazonAmazon Command Line Interface 2.15.18

AmazonAmazon WorkSpaces 5.18.0

AmazonAWS SAM Command Line Interface 1.109.0

AmazonSSM Agent 3.3.40

Arduino SAArduino Ide 2.3.0

Belgium e-IDBelgium e-ID Viewer 5.1.14

Bitwarden, Inc.Bitwarden Desktop 2024.2.0

Bloomberg Finance L.P.Bloomberg Terminal 136.5.80

DBeaverDBeaver CE 23.3.4

Docker Inc.Docker Desktop 4.27.1

dRofus ASDRofus 2.12.18

ElasticBeats Winlogbeat V8 8.12.1

EsetESET Server Security 10.0

EvernoteEvernote 10.75.1

Filezilla ProjectFileZilla Client 3.66.5

GolangGo Programming Language 1.22.0

GoogleGoogle Chrome 121.0.6167.161

KeePassKeePass 2.56.0

Mendeley Ltd.Mendeley Reference Manager 2.109.1

MicrosoftEdge WebView2 Runtime 121.0.2277.112

MicrosoftMicrosoft Edge 121.0.2277.112

MicrosoftPowerBI Desktop 2.124.2028

MozillaMozilla Firefox 122.0.1

Nord SecurityNordLayer 3.2.3

OperaOpera 107.0.5045.15

Python Software FoundationPython 3.12.2

QNAPQNAP Qsync Client 5.1.4

SteelSeriesSteel Series GG 56.0.0

VivaldiVivaldi 6.5.3206

### 


Amazon Command Line Interface 2.15.18

> More Info: [https://raw.githubusercontent.com/aws/aws-cli/v2/CHANGELOG.rst](https://raw.githubusercontent.com/aws/aws-cli/v2/CHANGELOG.rst)
> Support Info: [https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/building-rust.html](https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/building-rust.html)
> 2.15.18 ======= \* api-change:``ecs``: This release is a documentation only update to address customer issues. \* api-change:``workspaces``: Added definitions of various WorkSpace states \* api-change:``es``: This release adds clear visibility to the customers on the changes that they make on the domain. \* api-change:``dynamodb``: Any number of users can execute up to 50 concurrent restores (any type of restore) in a given account. \* api-change:``sagemaker``: Amazon SageMaker Canvas adds GenerativeAiSettings support for CanvasAppSettings.

### 


Amazon WorkSpaces 5.18.0

> More Info: [https://docs.aws.amazon.com/workspaces/latest/userguide/amazon-workspaces-windows-client.html#windows-release-notes](https://docs.aws.amazon.com/workspaces/latest/userguide/amazon-workspaces-windows-client.html#windows-release-notes)
> Support Info: [https://aws.amazon.com/tr/contact-us/sales-support-workspaces/](https://aws.amazon.com/tr/contact-us/sales-support-workspaces/)
> 5.18.0 January 22, 2024 Added Web Authn support for in-session authentication. 5.17.0 November 16, 2023 Fixed USB redirection issue for PCoIP WorkSpaces. Fixed a client crash when users change running mode. Fixed a client crash related to printer redirection on WSP client. Bug fixes and enhancements.

### 


Arduino Ide 2.3.0

> More Info: [https://github.com/arduino/arduino-ide/releases/tag/2.3.0](https://github.com/arduino/arduino-ide/releases/tag/2.3.0)
> Support Info: [https://support.arduino.cc/hc/en-us](https://support.arduino.cc/hc/en-us)
> 2.3.0 Latest Added Identify boards from manually installed platforms in "Select Other Board and Port" dialog tooltip (#2270) Support .cc and .cxx extensions for sketch files (#2265) Intellisense and validation for custom\_debug.json (#2281) Support direct modification of debugger's launch.json configuration file (#2281) Show progress information in the status bar when Arduino CLI is running debug --info --programmer command (#2281)

### 


AWS SAM Command Line Interface 1.109.0

> More Info: [https://github.com/aws/aws-sam-cli/releases/tag/v1.109.0](https://github.com/aws/aws-sam-cli/releases/tag/v1.109.0)
> Support Info: [https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/serverless-sam-cli-install-windows.html](https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/serverless-sam-cli-install-windows.html)
> Release version: 1.109.0 Latest Changes: 5dedfbb - Add logging for files pulled from S3 + enable RIE debug for flaky test (#6604) f2c7fcc - chore(deps-dev): bump ruff from 0.1.13 to 0.1.14 in /requirements (#6590) b442b11 - chore(deps): bump markupsafe from 2.1.3 to 2.1.4 in /requirements (#6588) c145cb5 - chore(deps): bump the boto group in /requirements with 4 updates (#6609) 759e7a0 - chore(deps): bump the types group in /requirements with 4 updates (#6608)

### 


Beats Winlogbeat V8 8.12.1

> More Info: [https://www.elastic.co/guide/en/beats/libbeat/current/release-notes-8.12.0.html](https://www.elastic.co/guide/en/beats/libbeat/current/release-notes-8.12.0.html)
> Support Info: [https://www.elastic.co](https://www.elastic.co)
> Beats version 8.12.1 Affecting all Beats Performance regression in AWS S3 inputs using SQS notification. In 8.12 the default memory queue flush interval was raised from 1 second to 10 seconds. In many configurations this improves performance because it allows the output to batch more events per round trip, which improves efficiency. However, the SQS input has an extra bottleneck that interacts badly with the new value. For more details see 37754.

### 


Belgium e-ID Viewer 5.1.14

> More Info: [https://eid.belgium.be/sites/default/files/software/RN5114.pdf](https://eid.belgium.be/sites/default/files/software/RN5114.pdf)
> Support Info: [https://eid.belgium.be/en/contact](https://eid.belgium.be/en/contact)
> eID Viewer 5.1.14 Release Notes Release Date: 14/12/2023 Supported Operating Systems eID Viewer 5.1.14 is supported on the following operating systems: Microsoft • Windows 8.1 • Windows 10 • Windows 11 eID Viewer • Support of the new Kids Foreigner A, B, K, L, M, F, F+, EU, EU+ cards • Add a scroll bar when needed

### 


Bitwarden Desktop 2024.2.0

> More Info: [https://github.com/bitwarden/clients/releases/](https://github.com/bitwarden/clients/releases/)
> Support Info: [https://bitwarden.com/help](https://bitwarden.com/help)
> Desktop v2024.2.0 Increased import item quantity maximum Small bug fixes and enhancements Desktop v2024.1.0 Added password complexity checks to password protected export Disallow XXE in import Bug-fixes for imports Bug-fix for minimum/maximum values in generator Bug-fix for screen-readers not announcing stored passkeys

### 


Bloomberg Terminal 136.5.80

> More Info: [https://www.bloomberg.com/professional/support/release-notes/](https://www.bloomberg.com/professional/support/release-notes/)
> Support Info: [https://www.bloomberg.com/professional/support/software-updates/](https://www.bloomberg.com/professional/support/software-updates/)
> 136.5.80 February 1st 2024 • Enhancements to Bloomberg Keyboard 5 detection • BBComm installer update 135.3.80 January 22nd 2024 • Bloomberg update service enhancements • Performance Improvements to Bloomberg Application

### 


DBeaver CE 23.3.4

> More Info: [https://github.com/dbeaver/dbeaver/releases/tag/23.3.4](https://github.com/dbeaver/dbeaver/releases/tag/23.3.4)
> Support Info: [https://github.com/dbeaver/dbeaver/issues](https://github.com/dbeaver/dbeaver/issues)
> 23.3.4 Latest Metadata Editor: Constraint creation was fixed Editor performance on Linux was enhanced SQL Editor: Autocomplete for aggregate functions was added Arrays highlighting was added SELECT query validation was fixed

### 


Docker Desktop 4.27.1

> More Info: [https://docs.docker.com/desktop/release-notes/#4271](https://docs.docker.com/desktop/release-notes/#4271)
> Support Info: [https://www.docker.com/blog/](https://www.docker.com/blog/)
> 4.27.1 Upgrades Docker Engine v25.0.2 which contains a fix for CVE-2024-24557, CVE-2024-23650, CVE-2024-23651, CVE-2024-23652 and CVE-2024-23653 Containerd v1.6.28 Runc v1.1.12 which contains a fix for CVE-2024-21626 Bug fixes and enhancements For Mac Fixed a bug that caused Docker Desktop to hang when applying an update.

### 


DRofus 2.12.18

> More Info: [https://www.drofus.com/release-notes](https://www.drofus.com/release-notes)
> Support Info: [https://support.drofus.com/support/home](https://support.drofus.com/support/home)
> 2.12.18 Bug Fixes [PB-6039] Fixed PowerQuery issues on certain filters. [PB-6051] Fixed Log in window on Italian Windows environment does not load translation. [PB-6058] Fixed issue when deleting occurrences one by one in Items in Rooms pane. [PB-6073] Fixed issue using drag and drop to change document categories. [DROFUS-73983] Fixed issue accessing procurement settings.

### 


Edge WebView2 Runtime 121.0.2277.112

> More Info: [https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel)
> Support Info: [https://docs.microsoft.com/en-us/microsoft-edge/webview2/](https://docs.microsoft.com/en-us/microsoft-edge/webview2/)
> Version 121.0.2277.112: February 8, 2024 Fixed various bugs and performance issues. Stable channel security updates are listed here. Version 121.0.2277.110: February 7, 2024 Fixed various bugs and performance issues. Version 121.0.2277.106: February 5, 2024 Fixed various bugs and performance issues. Fixes Resolved an issue where the IntranetFileLinksEnabled policy did not work as expected while opening file:// links.

### 


ESET Server Security 10.0

> More Info: [https://www.eset.com/int/business/download/file-security-windows/](https://www.eset.com/int/business/download/file-security-windows/)
> Support Info: [https://support.eset.com/](https://support.eset.com/)
> Version 10.0.12015.2 Improved: More granular information on reasons why a file was not scanned (e.g. password protected…) in OneDrive scan logs Improved: OneDrive registration error window has the text aligned and selectable now Improved: ESET Cluster wizard now informs about the result of product activation on individual nodes Fixed: A problem where product ignored new features that came with upgrade through automatic-updates

### 


Evernote 10.75.1

> More Info: [https://evernote.com/release-notes](https://evernote.com/release-notes)
> Support Info: [https://help.evernote.com/hc/en-us](https://help.evernote.com/hc/en-us)
> Version 10.75.1 - Latest Fixes: Performance improvements and miscellaneous bug fixes Version 10.74.1 - Latest Fixes: Fixes Remote Code Execution Vulnerability issue (CVE-2023-50643) Fixes a problem with disappearing notes when merging notes in the stack view Fixes an issue where a note’s icon would be partially cut off in the sidebar when the title is very long

### 


FileZilla Client 3.66.5

> More Info: [https://filezilla-project.org/changelog.php](https://filezilla-project.org/changelog.php)
> Support Info: [https://filezilla-project.org/support.php](https://filezilla-project.org/support.php)
> Bump to 3.66.5 2024-02-06 16:23 codesquid, revision 11089 M /FileZilla3/trunk/src/commonui/updater.cpp M /FileZilla3/trunk/src/commonui/xml\_file.cpp M /FileZilla3/trunk/src/interface/clearprivatedata.cpp M /FileZilla3/trunk/src/interface/edithandler.cpp M /FileZilla3/trunk/src/interface/filelistctrl.cpp M /FileZilla3/trunk/src/interface/wrapengine.cpp Fix warnings

### 


Go Programming Language 1.22.0

> More Info: [https://go.dev/doc/devel/release#go1.22.0](https://go.dev/doc/devel/release#go1.22.0)
> Support Info: [https://go.dev/doc](https://go.dev/doc)
> go1.22.0 (released 2024-02-06) Go 1.22.0 is a major release of Go. Read the Go 1.22 Release Notes for more information. go1.21.0 (released 2023-08-08) Go 1.21.0 is a major release of Go. Read the Go 1.21 Release Notes for more information. Minor revisions go1.21.1 (released 2023-09-06) includes four security fixes to the cmd/go, crypto/tls, and html/template packages, as well as bug fixes to the compiler, the go command, the linker, the runtime, and the context, crypto/tls, encoding/gob, encoding/xml, go/types, net/http, os, and path/filepath packages. See the Go 1.21.1 milestone on our issue tracker for details.

### 


Google Chrome 121.0.6167.161

> More Info: [https://chromereleases.googleblog.com/2024/02/stable-channel-update-for-desktop.html](https://chromereleases.googleblog.com/2024/02/stable-channel-update-for-desktop.html)
> Support Info: [https://support.google.com/chrome/a](https://support.google.com/chrome/a)
> Stable Channel Update for Desktop Tuesday, February 6, 2024 The Stable channel has been updated to 121.0.6167.160 for Mac and Linux and 121.0.6167.160/161 to Windows which will roll out over the coming days/weeks. A full list of changes in this build is available in the log. Security Fixes and Rewards Note: Access to bug details and links may be kept restricted until a majority of users are updated with a fix. We will also retain restrictions if the bug exists in a third party library that other projects similarly depend on, but haven’t yet fixed

### 


KeePass 2.56.0

> More Info: [https://keepass.info/news/n240204_2.56.html](https://keepass.info/news/n240204_2.56.html)
> Support Info: [https://keepass.info/help/base/index.html](https://keepass.info/help/base/index.html)
> KeePass 2.56 has been released today! You can get it here: Download KeePass 2.56. This is a stable release. It is recommended to upgrade from any previous 2.x version to 2.56. KeePass 2.56 mainly features user interface and integration enhancements, and various other minor new features and improvements. Hashes and signatures for integrity checking are available, and program binaries are digitally signed (Authenticode). New translations are available, too.

### 


Mendeley Reference Manager 2.109.1

> More Info: [https://www.mendeley.com/release-notes-reference-manager/](https://www.mendeley.com/release-notes-reference-manager/)
> Support Info: [https://www.mendeley.com/?interaction_required=true](https://www.mendeley.com/?interaction_required=true)
> Mendeley Reference Manager v2.109.1 We have fixed: An issue with group invitation link Support If you encounter any problems using Mendeley or have questions to ask please contact our support team. For news and updates about Mendeley see our blog.

### 


Microsoft Edge 121.0.2277.112

> More Info: [https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel)
> Support Info: [https://support.microsoft.com/en-us/microsoft-edge](https://support.microsoft.com/en-us/microsoft-edge)
> Version 121.0.2277.112: February 8, 2024 Fixed various bugs and performance issues. Stable channel security updates are listed here. Version 121.0.2277.110: February 7, 2024 Fixed various bugs and performance issues. Version 121.0.2277.106: February 5, 2024 Fixed various bugs and performance issues. Fixes Resolved an issue where the IntranetFileLinksEnabled policy did not work as expected while opening file:// links.

### 


Mozilla Firefox 122.0.1

> More Info: [https://www.mozilla.org/en-US/firefox/122.0.1/releasenotes/](https://www.mozilla.org/en-US/firefox/122.0.1/releasenotes/)
> Support Info: [https://www.mozilla.org/en-US/security/advisories/mfsa2023-08/](https://www.mozilla.org/en-US/security/advisories/mfsa2023-08/)
> 122.0.1 Firefox Release February 6, 2024 Version 122.0.1, first offered to Release channel users on February 6, 2024 Fixed Fixed the Library and Sidebar context menus only displaying Multi-Account Containers icons in the "Open in New Container Tab" menu. (Bug 1876518) Fixed an issue when clicking the Dismiss button in notification pop-ups on Windows causing a webpage in a new tab. (Bug 1848801) Fixed the yaru-remix system theme not applying correctly on Linux. (Bug 1877002)

### 


NordLayer 3.2.3

> More Info: [https://help.nordlayer.com/docs/windows](https://help.nordlayer.com/docs/windows)
> Support Info: [https://help.nordlayer.com/docs](https://help.nordlayer.com/docs)
> Windows 3.2.3 February 1, 2024 Bug Fixes Minor fixes and improvements. Windows 3.2.2 January 30, 2024 Bug Fixes Minor fixes and improvements.

### 


Opera 107.0.5045.15

> More Info: [https://blogs.opera.com/desktop/2024/02/opera-107/](https://blogs.opera.com/desktop/2024/02/opera-107/)
> Support Info: [https://www.opera.com/help](https://www.opera.com/help)
> Opera 107 Dear Opera Users, Exciting news! We’ve rolled out Opera Browser’s stable update, introducing Version 107. Here are the key highlights from the changelog: Tab Cycler Enhancements: Say hello to animated text in the tab cycler, centered screen tab thumbnails with shadows, and a fade-out effect for long tab titles. These enhancements not only improve aesthetics but also streamline your browsing workflow. Visual and Stylistic Improvements: We’ve updated font colors, shadows (glow) of tabs, and the position of text and tabs when cycling through tabs. These changes contribute to a more polished and visually pleasing browsing experience.

### 


PowerBI Desktop 2.124.2028

> More Info: [https://www.microsoft.com/en-us/download/details.aspx?id=58494](https://www.microsoft.com/en-us/download/details.aspx?id=58494)
> Support Info: [https://powerbi.microsoft.com/en-us/support/](https://powerbi.microsoft.com/en-us/support/)
> With Power BI Desktop, you can: Get data The Power BI Desktop makes discovering data easy. You can import data from a wide variety of data sources. After you connect to a data source, you can shape the data to match your analysis and reporting needs. Create relationships and enrich your data model with new measures and data formats When you import two or more tables, oftentimes you'll need to create relationships between those tables. The Power BI Desktop includes the Manage Relationships dialog and the Relationships view, where you can use Autodetect to let the Power BI Desktop find and create any relationships, or you can create them yourself. You can also very easily create your own measures and calculations or customize data formats and categories to enrich your data for additional insights.

### 


Python 3.12.2

> More Info: [https://www.python.org/downloads/release/python-3122/](https://www.python.org/downloads/release/python-3122/)
> Support Info: [https://www.python.org/doc/](https://www.python.org/doc/)
> This is the second maintenance release of Python 3.12 Python 3.12 is the newest major release of the Python programming language, and it contains many new features and optimizations. 3.12.2 is the latest maintenance release, containing more than 350 bugfixes, build improvements and documentation changes since 3.12.1. Major new features of the 3.12 series, compared to 3.11 New features More flexible f-string parsing, allowing many things previously disallowed (PEP 701). Support for the buffer protocol in Python code (PEP 688).

### 


QNAP Qsync Client 5.1.4

> More Info: [https://www.qnap.com/en/utilities/essentials?utilityId=3¬es=Windows](https://www.qnap.com/en/utilities/essentials?utilityId=3&notes=Windows)
> Support Info: [https://www.qnap.com/go/how-to](https://www.qnap.com/go/how-to)
> 5.1.4 [Enhancements] - Improved connection stability when connected via myQNAPcloud Link. - You can now pair again with a folder in space-saving mode that had been unpaired abnormally. [Fixed Issues] - Qsync Client can now successfully connect to the NAS when using a third-party DDNS and specifying a WAN port for establishing connections. - Qsync now does not display an error message when users connect to a device shared with them via myQNAPcloud.

### 


SSM Agent 3.3.40

> More Info: [https://github.com/aws/amazon-ssm-agent/releases/tag/3.3.40.0](https://github.com/aws/amazon-ssm-agent/releases/tag/3.3.40.0)
> Support Info: [https://aws.amazon.com/systems-manager/](https://aws.amazon.com/systems-manager/)
> Amazon SSM Agent - Release 3.3.40.0 - 2024-02-07 Latest Fix issue to execute aws:updateSSMAgent plugin through aws:rundocument plugin Update Messaging module to switch off ec2messages when ssmmessages connected successfully Update SSM Agent Minor version from 3.2 to 3.3

### 


Steel Series GG 56.0.0

> More Info: [https://techblog.steelseries.com/2024/02/07/GG-notes-56.0.0.html](https://techblog.steelseries.com/2024/02/07/GG-notes-56.0.0.html)
> Support Info: [https://support.steelseries.com/hc/en-us](https://support.steelseries.com/hc/en-us)
> RELEASE NOTES FOR GG 56.0.0 07 FEB 2024BY THE STEELSERIES SOFTWARE TEAM Sonar Dive into Palworld, Tekken 8, Like a Dragon: Infinite Wealth, and Prince of Persia: The Lost Crown with custom Sonar presets designed by SteelSeries audio experts to elevate your gameplay. We’ve improved the config/preset import modal screen with a new reference to the channel. Now when importing a config/preset you know exactly to which channel it will be imported. Exclusion List UI Enhancement: you can now manage your device preferences with ease using the redesigned side-by-side layout for included/excluded devices (go to GG Settings/Sonar/Backup device switch.)

### 


Vivaldi 6.5.3206

> More Info: [https://vivaldi.com/blog/desktop/minor-update-eight-6-5/](https://vivaldi.com/blog/desktop/minor-update-eight-6-5/)
> Support Info: [https://help.vivaldi.com/](https://help.vivaldi.com/)
> Minor update (8) for Vivaldi Desktop Browser 6.5 This update includes various security improvements from the Chromium project. The following improvements were made since the seventh 6.5 minor update: [Chromium] Upgraded to 120.0.6099.285

[PreviousFebruary 17 Catalog Update #20240217 - Easy2Patch](/catalog-posts-2024/february-17-catalog-update-20240217-easy2patch)[NextFebruary 3 Catalog Update #20240203 - Easy2Patch](/catalog-posts-2024/february-3-catalog-update-20240203-easy2patch)
Last updated <time data-visual-test="transparent" datetime="2024-02-10T10:32:41.878Z" data-state="closed">2 years ago</time>
