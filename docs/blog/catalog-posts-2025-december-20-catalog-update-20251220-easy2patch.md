---
layout: post
title: "20 December 2025 Catalog Update - Easy2Patch"
date: 2025-12-20
categories: [blog]
---

Our catalog with **#20251220** (Catalog version **3.4.490** ) is available to our **Easy2Patch** customers.

This week, **64** software updates are provided in the E2P catalog. We support **586** products of **355** individual manufacturers in total. We are updating **756** products with 32/64-bit and language options.

***Note:*** *VirusTotal and Kaspersky Opentip scans are the responsibility of the manufacturer. E2P Bilisim has no responsibility or liability for the virus scanning results of the files.*

Manufacturer

Software

PostgreSQLPostgreSQL 17.7.1

PostgreSQLPostgreSQL 18.1.1

Python Software FoundationPython 3.14.2

3CX3CX Phone System

Abacus ResearchAbaclient 4.0.1124

Absolute Software CorporationAbsolute Secure Access Client 14.12

Active Directory ProADProToolkit 2.4.5

Airtame IncAirtame 4.15.0

AmazonAmazon Command Line Interface v2 2.32.21

ApacheApache Tomcat 9.0.113

AppDynamicsAppDynamics .Net Agent 25.10.1

BandicamBandicut 4.2.4

BeswareArtweaver Free 8 8.1.1

Binary FortressFileSeek 7.1.0

Cato NetworksCato Client VPN 5.18.5

CiscoCisco Webex Meetings 45.6.3

CloudflareCloudflare WARP Client 25.9.558

Datacomp IT Sp zooBIMvision 3.1.1

ElasticBeats Winlogbeat 9.2.3

GoogleGoogle Chrome 143.0.7499.170

GoTo Group IncLogMeIn Client 1.3.5662

MicrosoftEdge WebView2 Runtime 143.0.3650.96

MicrosoftMicrosoft Edge 143.0.3650.96

MicrosoftMicrosoft ODBC Driver 18 for SQL Server 18.6.1

MozillaMozilla Firefox 146.0.1

MozillaMozilla Thunderbird 146.0.1

MozillaMozilla Thunderbird 146.0.1

NlitesoftNTLite 2025.12

NSClient++NSClient++ 0.10.9

OBS ProjectOBS Studio 32.0.3

OpenJSNode.js 20.19.6 LTS

OpenJSNode.js 23.11.1

OperaOpera 125.0.5729.49

SalesforceSalesforce CLI v2 2.116.6

Scooter SoftwareBeyond Compare 5.1.7

Siber Systems IncRoboForm for Windows 9.9.1

Siber SystemsGoodSync 12.9.19

TeamViewerTeamViewer 15.73.5

The jamovi ProjectJamovi Desktop 2.7.14

WireGuardTailscale 1.92.3

Zabbix LLCZabbix Agent 2 7.4.6

Zabbix LLCZabbix Agent 7.4.6

### 


PostgreSQL 17.7.1 (x64) (EXE)

> **More Info:** [https://www.postgresql.org/docs/release/17.7/](https://www.postgresql.org/docs/release/17.7/)
> **Support Info:** [https://www.postgresql.org/support/](https://www.postgresql.org/support/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/71e1bd69bf7ccebe0cfda89385d11b51b4dab29bc0b86ab85abf5749fe57ee47)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/71e1bd69bf7ccebe0cfda89385d11b51b4dab29bc0b86ab85abf5749fe57ee47)
> PostgreSQL 17.7 Release date: 2025-11-13 This release contains a variety of fixes from 17.6. For information about new features in major release 17, see Section E.8. A dump/restore is not required for those running 17.X. However, if you are upgrading from a version earlier than 17.6, see Section E.2. Check for CREATE privileges on the schema in CREATE STATISTICS (Jelte Fennema-Nio) § This omission allowed table owners to create statistics in any schema, potentially leading to unexpected naming conflicts. The PostgreSQL Project thanks Jelte Fennema-Nio for reporting this problem. (CVE-2025-12817) Avoid integer overflow in allocation-size calculations within libpq (Jacob Champion) § Several places in libpq were not sufficiently careful about computing the required size of a memory allocation. Sufficiently large inputs could cause integer overflow, resulting in an undersized buffer, which would then lead to writing past the end of the buffer. The PostgreSQL Project thanks Aleksey Solovev of Positive Technologies for reporting this problem. (CVE-2025-12818) Prevent “unrecognized node type” errors when a SQL/JSON function such as JSON\_VALUE has a DEFAULT clause containing a COLLATE expression (Jian He) § § Correctly treat JSON constructor expressions, such as JSON\_OBJECT(), as non-strict (Tender Wang, Richard Guo) § In some cases these expressions can yield a non-null result despite having one or more null inputs, making them non-strict. The planner incorrectly classif

### 


PostgreSQL 18.1.1 (x64) (EXE)

> **More Info:** [https://www.postgresql.org/docs/release/18.1/](https://www.postgresql.org/docs/release/18.1/)
> **Support Info:** [https://www.postgresql.org/support/](https://www.postgresql.org/support/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/f9c556921479782fcdd99c83ee1a4a69d5333d3f6c0dd5b7cb46ae39c4a95b8e)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/f9c556921479782fcdd99c83ee1a4a69d5333d3f6c0dd5b7cb46ae39c4a95b8e)
> PostgreSQL 18.1 Release date: 2025-11-13 This release contains a variety of fixes from 18.0. For information about new features in major release 18, see Section E.2. A dump/restore is not required for those running 18.X. Check for CREATE privileges on the schema in CREATE STATISTICS (Jelte Fennema-Nio) § This omission allowed table owners to create statistics in any schema, potentially leading to unexpected naming conflicts. The PostgreSQL Project thanks Jelte Fennema-Nio for reporting this problem. (CVE-2025-12817) Avoid integer overflow in allocation-size calculations within libpq (Jacob Champion) § Several places in libpq were not sufficiently careful about computing the required size of a memory allocation. Sufficiently large inputs could cause integer overflow, resulting in an undersized buffer, which would then lead to writing past the end of the buffer. The PostgreSQL Project thanks Aleksey Solovev of Positive Technologies for reporting this problem. (CVE-2025-12818) Prevent “unrecognized node type” errors when a SQL/JSON function such as JSON\_VALUE has a DEFAULT clause containing a COLLATE expression (Jian He) § § Avoid incorrect optimization of variable-free HAVING clauses with grouping sets (Richard Guo) § § Do not use parallelism in hash right semi joins (Richard Guo) § The case does not work reliably due to a race condition in updating the join's shared hash table. Avoid possible division-by-zero when creating ordered-append plans (Richard Guo) § Thi

### 


Python 3.14.2 (x64) (EXE)

> **More Info:** [https://www.python.org/downloads/release/python-3142](https://www.python.org/downloads/release/python-3142)
> **Support Info:** [https://www.python.org/doc/](https://www.python.org/doc/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/9db919cefe30a0051658c600a9912acb0cd2b872aaf35842c9ec2bf401efa848)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/9db919cefe30a0051658c600a9912acb0cd2b872aaf35842c9ec2bf401efa848)
> Python 3.14.2 This is the second maintenance release of Python 3.14 Python 3.14.2 is the second maintenance release of 3.14, containing 18 bugfixes, build improvements and documentation changes since 3.14.1. This is an expedited release to fix the following regressions: gh-142206: Exceptions in multiprocessing in running programs while upgrading Python.

### 


Python 3.14.2 (x86) (EXE)

> **More Info:** [https://www.python.org/downloads/release/python-3142](https://www.python.org/downloads/release/python-3142)
> **Support Info:** [https://www.python.org/doc/](https://www.python.org/doc/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/1f408e675682d03b29b74a29857f9ccd7e02c737533c57d921f49174f2f78822)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/1f408e675682d03b29b74a29857f9ccd7e02c737533c57d921f49174f2f78822)
> Python 3.14.2 This is the second maintenance release of Python 3.14 Python 3.14.2 is the second maintenance release of 3.14, containing 18 bugfixes, build improvements and documentation changes since 3.14.1. This is an expedited release to fix the following regressions: gh-142206: Exceptions in multiprocessing in running programs while upgrading Python.

### 


3CX Phone System (x64) (EXE)

> **More Info:** [https://www.3cx.com/blog/change-log/phone-system-change-log-v20/](https://www.3cx.com/blog/change-log/phone-system-change-log-v20/)
> **Support Info:** [https://www.3cx.com/docs/manual/](https://www.3cx.com/docs/manual/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/e2fa481978672a73d2cff5632175c926d7b28af31b4fdfa41e862efc69bc7d42)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/e2fa481978672a73d2cff5632175c926d7b28af31b4fdfa41e862efc69bc7d42)
> 3CX Version 20, Update 7 Hotfix, Build 20.0.7.1080, October 2025 Fixed syslog writing sip messages. Updated Microsoft ASP.NET Libraries. 3CX Version 20, Update 7, Build 20.0.7.1057, October 2025 Added protection to prevent queues from being looped. Added tracking of active calls to protect against delays inside Queue Manager to prevent stuck calls. Fixed issue with microphone settings not saving due to recent Chromium changes. Fixed issues with custom time zone filters when searching recordings. Fixed Intro prompt no longer continues playing when call is routed to Destination No Answer. Fixed memory leaks caused by OAuth authentication. Fixed memory leaks during callback operations. Fixed stuck calls occurring under race conditions when a caller answered while the agent dropped simultaneously.

### 


Abaclient 4.0.1124 (x86) (MSI) (copy)

> **More Info:** [https://downloads.abacus.ch/fileadmin/ablage/dokumente/05_abaclient/AbaClient_4.1-Referenz_EN.pdf](https://downloads.abacus.ch/fileadmin/ablage/dokumente/05_abaclient/AbaClient_4.1-Referenz_EN.pdf)
> **Support Info:** [https://www.abacus.ch/en/contact](https://www.abacus.ch/en/contact)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/ebb66c295d83527d7bd5bd54fc072804bedc6beee2a0100009da77dbe4431b20)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/ebb66c295d83527d7bd5bd54fc072804bedc6beee2a0100009da77dbe4431b20)
> AbaClient Version 4.0 Installed AbaClients with activated update function will receive an automatic update notification within the next 14 days. Please note before updating: As of AbaClient Version 4.0, only Abacus versions from Version 2021 are supported. Older Abacus installations can no longer be started with this client. Abacus Version 2026 requires the use of AbaClient Version 4.0. Release notes: Supported Abacus versions: From Version 2021 Login is only possible via the standard web browser Java 8 has been removed Conversion from 32-bit to 64-bit JxBrowser has been removed

### 


Absolute Secure Access Client 14.12 (x64) (MSI)

> **More Info:** [https://community.absolute.com/s/secure-access](https://community.absolute.com/s/secure-access)
> **Support Info:** [https://www.absolute.com/customers/support/windows-and-macos-client-files](https://www.absolute.com/customers/support/windows-and-macos-client-files)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/d1bdf1953a2e9003a43cd7fd5236c9f6eb233cf4c5faaf35380b225776d0c324)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/d1bdf1953a2e9003a43cd7fd5236c9f6eb233cf4c5faaf35380b225776d0c324)
> Secure Access 14.12 Release Notes 14.12 is a general maintenance release for all customers and includes the server and all client platforms. The update addresses several quality-of-life issues and two security vulnerabilities that would allow attackers to crash the server or a client. Server updates include: Security fix for a denial-of-service CVE, rated 8.2 – High. Resolved an issue with the connections page that could keep it from loading. Resolved an issue with console roles when combining the ‘SSO Only’ role with the default admin role. Resolved an issue with policy UI when using process names as conditions. Updates for all clients include: Resolved an issue with device-only authentication prompting the user after upgrading to 14.10. Windows client updates include: Security fix for a denial-of-service CVE, rated 6.0 – Medium. Improved compatibility with Axon body cameras after upgrading to 14.10. Improved bypass mode reliability during network transitions. For details regarding security fixes in this release, see our security advisory for Secure Access 14.12. For details regarding all other fixes, see Secure Access v14.1x Known and Resolved Issues (KARI).

### 


ADProToolkit 2.4.5 (x64) (EXE)

> **More Info:** [https://activedirectorypro.com/release-notes/](https://activedirectorypro.com/release-notes/)
> **Support Info:** [https://activedirectorypro.com/docs/](https://activedirectorypro.com/docs/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/1a0e872df835e419dab111d01d531bf9257ed7222b25217be3eb6126037ffded)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/1a0e872df835e419dab111d01d531bf9257ed7222b25217be3eb6126037ffded)
> 2.4.5 (12/16/2025) Fixed: Excessive API calls for license activation. 2.4.4 (12/15/2025) New Report No Links Enabled: This is a GPO report that shows GPOs that have all links disabled. Fixed: Can now edit existing scheduled task name. Fixed: Adding single user now correctly sets the co attribute

### 


Airtame 4.15.0 (x86) (MSI)

> **More Info:** [https://help.airtame.com/en/](https://help.airtame.com/en/)
> **Support Info:** [https://help.airtame.com/hc/en-us/articles/5348392729117-Changelog-Product-Changes-Airtame-Application-](https://help.airtame.com/hc/en-us/articles/5348392729117-Changelog-Product-Changes-Airtame-Application-)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/ae06a1b9ab3a5c706a8d701b9d49e750a3945e6028a9d49ad727d7da30570320)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/ae06a1b9ab3a5c706a8d701b9d49e750a3945e6028a9d49ad727d7da30570320)
> Desktop app 4.15 Airtame Desktop app version 4.15 is bringing the essential upgrades to support our newest hardware - Airtame 3! Therefore, for the best experience and access to all functionality, this update is essential. Beyond new hardware support, we have also made some improvements for call and streaming quality for all users across all devices. This release is being rolled out gradually and will soon be visible to all users. The latest version can always be found on airtame.com/download Desktop app 4.15 - main updates: 🚀 Airtame 3 updates The desktop app is now adjusted to support the Airtame 3 device setup flow (Note: Airtame 3 can now also be set up without the desktop app via Bluetooth) Added support for conferencing and streaming capabilities specifically for Airtame 3 devices. 🐞 Improvements and Bug fixes: Fixed an issue where the red sharing frame was misplaced when presenting from a device with an external monitor connected Cleaned up confusing error messages that appeared when an Airtame device left a call (or was rejected) from the lobby

### 


Amazon Command Line Interface v2 2.32.21 (x64) (MSI)

> **More Info:** [https://raw.githubusercontent.com/aws/aws-cli/v2/CHANGELOG.rst](https://raw.githubusercontent.com/aws/aws-cli/v2/CHANGELOG.rst)
> **Support Info:** [https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/building-rust.html](https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/building-rust.html)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/3c413f25947d8247000bbdf279baf1350e0383f8c26e0b9e1cdbfbcd625e982a)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/3c413f25947d8247000bbdf279baf1350e0383f8c26e0b9e1cdbfbcd625e982a)
> 2.32.21 ======= \* api-change:``qbusiness``: It is a internal bug fix for region expansion \* api-change:``iot``: This release adds event-based logging feature that enables granular event logging controls for AWS IoT logs. \* api-change:``connect``: Adding support for Custom Metrics and Pre-Defined Attributes to GetCurrentMetricData API.

### 


Apache Tomcat 9.0.113 (x86) (EXE)

> **More Info:** [https://downloads.apache.org/tomcat/tomcat-9/v9.0.113/RELEASE-NOTES](https://downloads.apache.org/tomcat/tomcat-9/v9.0.113/RELEASE-NOTES)
> **Support Info:** [https://tomcat.apache.org/tomcat-9.0-doc/changelog.html](https://tomcat.apache.org/tomcat-9.0-doc/changelog.html)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/4d56de530aaacf419efc9d4069dbb1178f4386a498f00546da57bf2ec6a9f0d5)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/4d56de530aaacf419efc9d4069dbb1178f4386a498f00546da57bf2ec6a9f0d5)
> Catalina Fix: 69871: Increase log level to INFO for missing configuration for the rewrite valve. (remm) Fix: Add log warnings for additional Host appBase suspicious values. (remm) Fix: Remove hard dependency on tomcat-jni.jar for catalina.jar. org.apache.catalina.Connector no longer requires org.apache.tomcat.jni.AprStatus to be present. (markt) Add: Add the ability to use a custom function to generate the client identifier in the CrawlerSessionManagerValve. This is only available programmatically. Pull request #902 by Brian Matzon. (markt) Fix: Change the SSO reauthentication behaviour for SPNEGO authentication so that a normal SPNEGO authentication is performed if the SSL Valve is configured with reauthentication enabled. This is so that the delegated credentials will be available to the web application. (markt)

### 


AppDynamics .Net Agent 25.10.1 (x64) (MSI)

> **More Info:** [https://help.splunk.com/en/appdynamics-saas/release-notes-and-references/agents-release-notes](https://help.splunk.com/en/appdynamics-saas/release-notes-and-references/agents-release-notes)
> **Support Info:** [https://docs.appdynamics.com/en](https://docs.appdynamics.com/en)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/1c84952a2003933d207ffb1017e3717a39b2f475a24edd8b495ca0be01359a7c)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/1c84952a2003933d207ffb1017e3717a39b2f475a24edd8b495ca0be01359a7c)
> Agent Enhancements When there is an update to an artifact, you can find the new version numbers in the following tables. Version numbers are also displayed on the Downloads Portal. Agent Summary Release Version Release Date Smart Agent With this release, you can now provide the basic authentication for download portal using the custom configuration section. See Configure Basic Authentication for Custom Artifactory Location.

### 


Artweaver Free 8 8.1.1 (x64) (EXE)

> **More Info:** [https://www.artweaver.de/en/help/272](https://www.artweaver.de/en/help/272)
> **Support Info:** [https://www.artweaver.de/en/help](https://www.artweaver.de/en/help)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/2afade5a8b8fe53ee28bcb49c056bd5003b908bf8f12d1c2dd470230f613b656)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/2afade5a8b8fe53ee28bcb49c056bd5003b908bf8f12d1c2dd470230f613b656)
> Artweaver 8.1.1 This version includes the following improvements and fixes Improved events playback Improved fitting document on screen Improved mirror painting quality Improved brush tool reset

### 


Bandicut 4.2.4 (x64) (EXE)

> **More Info:** [https://www.bandicam.com/bandicut-video-cutter/history/](https://www.bandicam.com/bandicut-video-cutter/history/)
> **Support Info:** [https://www.bandicam.com/bandicut-video-cutter/support/faq/](https://www.bandicam.com/bandicut-video-cutter/support/faq/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/927ca646f03086b877e83b9814ba5d9e95abde610192ebc2efe7e233f3df044b)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/927ca646f03086b877e83b9814ba5d9e95abde610192ebc2efe7e233f3df044b)
> 4.2.4 (Bandicut 2025) 12/19/2025 Fixed an issue where encoders and decoders were not showing on NVIDIA driver 591.44 and 591.59. 4.2.2 11/18/2025 Improved performance when adding large files. Bugs fixed Encoding settings reset after using High-Speed mode.

### 


Beats Winlogbeat 9.2.3 (x64) (MSI)

> **More Info:** [https://www.elastic.co/docs/release-notes/beats](https://www.elastic.co/docs/release-notes/beats)
> **Support Info:** [https://www.elastic.co](https://www.elastic.co)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/268288d2d2d9046c1019923b151fdf4edca66a4c4b37f7a46b6f8053903b031a)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/268288d2d2d9046c1019923b151fdf4edca66a4c4b37f7a46b6f8053903b031a)
> 9.2.3 Features and enhancements All Make beats receivers emit status for their subcomponents. #48015 Add GUID translation, base DN inference, and SSPI authentication to LDAP processor. #47827

### 


Beyond Compare 5.1.7 (x86) (EXE)

> **More Info:** [https://www.scootersoftware.com/download/v5changelog](https://www.scootersoftware.com/download/v5changelog)
> **Support Info:** [https://www.scootersoftware.com/support](https://www.scootersoftware.com/support)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/ac4220d3ef13a4253a7a4b408c14096e34da14027973b8f960f8b9b3945736aa)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/ac4220d3ef13a4253a7a4b408c14096e34da14027973b8f960f8b9b3945736aa)
> 5.1.7.31736 - December 18, 2025 Notable Changes macOS: Fixed hangs when opening "Settings" dialog or using "Install Command Line Tools..." on macOS 26.2 Tahoe. Windows: Installer and executables are now only signed with an SHA-256 digital signature and no longer include an SHA-1 one.

### 


BIMvision 3.1.1 (x86) (EXE)

> **More Info:** [https://bimvision.eu/release-notes/](https://bimvision.eu/release-notes/)
> **Support Info:** [https://helpcenter.bimvision.eu/](https://helpcenter.bimvision.eu/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/8d95f0431575ea1f2bb341fea2badba1e5ed690b17381ab1ef3a65a5673c13b7)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/8d95f0431575ea1f2bb341fea2badba1e5ed690b17381ab1ef3a65a5673c13b7)
> 3.1.1 (current version) release date 2025-12-12 Modified grid behavior to facilitate navigation in large models Cross-section with the ability to snap to a 3D curve Modified length measurement using the “Points” method Simultaneous measurement of several arbitrary angles (Multiple selection)

### 


Cato Client VPN 5.18.5 (x86) (MSI)

> **More Info:** [https://support.catonetworks.com/hc/en-us/articles/11276483327389-Summary-of-Cato-Windows-Client-Releases](https://support.catonetworks.com/hc/en-us/articles/11276483327389-Summary-of-Cato-Windows-Client-Releases)
> **Support Info:** [https://support.catonetworks.com/hc/en-us/categories/4965374551581-Support](https://support.catonetworks.com/hc/en-us/categories/4965374551581-Support)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/963784f3a23fa88734d950f69b640a14ba673ed68d40b1f1fbebbe8167edc599)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/963784f3a23fa88734d950f69b640a14ba673ed68d40b1f1fbebbe8167edc599)
> Windows Client v5.18 During the week of October 19, 2025, we will begin rolling out the Windows Client version 5.18. This version includes the following resolved issues: Resolved Issues v5.18 ID Description Severity Impacted Versions 111721 Fixed an issue where Windows clients behind a Socket in Office Mode with Always-On intermittently failed to report the configured Device Posture Profile. Critical 5.12 and higher 148024 Fixed a stability issue causing occasional client crashes under specific runtime conditions. Critical 5.17 147493 Fixed a reauthentication issue. Critical 5.16 and higher 143835 Fixed intermittent failures in device posture evaluation during the first sign-in. Critical 5.16 and higher 143205 Fixed a mismatch between Windows Defender ATP status and Client Connectivity Policy (CCP) evaluation when the client operated behind an office socket. Critical 5.17 143249 Fixed an issue where the client could not be installed on 32-bit sytems running Windows 10. High 5.16 and higher 146936 Fixed an issue where the client failed to reauthenticate using an embedded browser. High 5.16 and higher 142952 Fixed an issue where the client was opening normally instead of minimized. High

### 


Cisco Webex Meetings 45.6.3 (x86) (MSI)

> **More Info:** [https://help.webex.com/en-us/article/xcwws1/Release-notes-for-Webex-Meetings](https://help.webex.com/en-us/article/xcwws1/Release-notes-for-Webex-Meetings)
> **Support Info:** [https://help.webex.com/contact](https://help.webex.com/contact)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/22c761c7666d890b232ce627f5952e0a6d922706fc3dd95eb8f8b24f9f9ce780)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/22c761c7666d890b232ce627f5952e0a6d922706fc3dd95eb8f8b24f9f9ce780)
> December 15, 2025 We've released an update for Webex App 45.12, this update contains some stability fixes. The following app version corresponds to today's update.

### 


Cloudflare WARP Client 25.9.558 (x64) (MSI)

> **More Info:** [https://developers.cloudflare.com/cloudflare-one/connections/connect-devices/warp/download-warp/](https://developers.cloudflare.com/cloudflare-one/connections/connect-devices/warp/download-warp/)
> **Support Info:** [https://developers.cloudflare.com/warp-client/get-started/windows/](https://developers.cloudflare.com/warp-client/get-started/windows/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/ac519bcc2937d93d67d31497d72a6262801d30cea98894a9584c0b92d0635ba2)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/ac519bcc2937d93d67d31497d72a6262801d30cea98894a9584c0b92d0635ba2)
> Version: Windows 2025.9.558.0 Date: 2025-11-11 Size: 136 MB Download Release notes This release contains minor fixes, improvements, and new features including Path Maximum Transmission Unit Discovery (PMTUD). When PMTUD is enabled, the client will dynamically adjust packet sizing to optimize connection performance. There is also a new connection status message in the GUI to inform users that the local network connection may be unstable. This will make it easier to diagnose connectivity issues.

### 


Edge WebView2 Runtime 143.0.3650.96 (x64) (EXE)

> **More Info:** [https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel)
> **Support Info:** [https://docs.microsoft.com/en-us/microsoft-edge/webview2/](https://docs.microsoft.com/en-us/microsoft-edge/webview2/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/96ba497132f4a0bd9ed97b4496212801b092002c72ff921cfc5e51a7b51c7e6a)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/96ba497132f4a0bd9ed97b4496212801b092002c72ff921cfc5e51a7b51c7e6a)
> Version 143.0.3650.96: December 18, 2025 Fixed various bugs, and performance issues. Stable channel security updates are listed here. Version 142.0.3595.136: December 18, 2025 Fixed various bugs, and performance issues for Extended Stable Channel.

### 


Edge WebView2 Runtime 143.0.3650.96 (x86) (EXE)

> **More Info:** [https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel)
> **Support Info:** [https://docs.microsoft.com/en-us/microsoft-edge/webview2/](https://docs.microsoft.com/en-us/microsoft-edge/webview2/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/6e685f2fb51c89caa4f038150f99577342bb3333c5ab401da397d0c94ce4fa0f)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/6e685f2fb51c89caa4f038150f99577342bb3333c5ab401da397d0c94ce4fa0f)
> Version 143.0.3650.96: December 18, 2025 Fixed various bugs, and performance issues. Stable channel security updates are listed here. Version 142.0.3595.136: December 18, 2025 Fixed various bugs, and performance issues for Extended Stable Channel.

### 


FileSeek 7.1.0 (x64) (EXE)

> **More Info:** [https://www.fileseek.ca/changelog](https://www.fileseek.ca/changelog)
> **Support Info:** [https://www.fileseek.ca/support](https://www.fileseek.ca/support)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/e8d9475900ddfdaf134c4519468f5e80c8326c1cc0e54d3364689c55fd4ce430)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/e8d9475900ddfdaf134c4519468f5e80c8326c1cc0e54d3364689c55fd4ce430)
> v7.1 • December 18, 2025 Change: You can now delete items from the history drop-downs using Shift + Delete Fix: Text boxes no longer overlap buttons with 225% display scaling Fix: Resolved a string length error

### 


GoodSync 12.9.19 (x86) (MSI)

> **More Info:** [http://www.goodsync.com/news-windows](http://www.goodsync.com/news-windows)
> **Support Info:** [http://www.goodsync.com/support](http://www.goodsync.com/support)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/69fcf1f094d62d27b40be81d120961a687e1351aabd3ad0df8d568bce1844afd)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/69fcf1f094d62d27b40be81d120961a687e1351aabd3ad0df8d568bce1844afd)
> Version 12.9.19 -- 2025-12-12 \* Backblaze B2: Fixed (auth\_token\_limit) more than one upload using auth token. \* SFTP: Limit number of unauthenticated connections, to prevent server blocking. \* Rename Job: Fixed GUI updating when job is renamed.

### 


Google Chrome 143.0.7499.170 (x64) (MSI)

> **More Info:** [https://chromereleases.googleblog.com/search?max-results=50](https://chromereleases.googleblog.com/search?max-results=50)
> **Support Info:** [https://support.google.com/chrome/a](https://support.google.com/chrome/a)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/4d46a94b048b9ee0f7d4b9354612a055da30e0d9e5ed016d06d64114c4b44ac5)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/4d46a94b048b9ee0f7d4b9354612a055da30e0d9e5ed016d06d64114c4b44ac5)
> Stable Channel Update for Desktop Thursday, December 18, 2025 The Stable channel has been updated to 143.0.7499.169/.170 for Windows/Mac and 143.0.7499.169 for Linux, which will roll out over the coming days/weeks. A full list of changes in this build is available in the Log. Interested in switching release channels? Find out how here. If you find a new issue, please let us know by filing a bug. The community help forum is also a great place to reach out for help or learn about common issues.

### 


Google Chrome 143.0.7499.170 (x86) (MSI)

> **More Info:** [https://chromereleases.googleblog.com/search?max-results=50](https://chromereleases.googleblog.com/search?max-results=50)
> **Support Info:** [https://support.google.com/chrome/a](https://support.google.com/chrome/a)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/77d37d4654e81e0193b98be82327dafec6e6eeb1542960e4cabdcd32eba06739)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/77d37d4654e81e0193b98be82327dafec6e6eeb1542960e4cabdcd32eba06739)
> Stable Channel Update for Desktop Thursday, December 18, 2025 The Stable channel has been updated to 143.0.7499.169/.170 for Windows/Mac and 143.0.7499.169 for Linux, which will roll out over the coming days/weeks. A full list of changes in this build is available in the Log. Interested in switching release channels? Find out how here. If you find a new issue, please let us know by filing a bug. The community help forum is also a great place to reach out for help or learn about common issues.

### 


Jamovi Desktop 2.7.14 (x64) (EXE)

> **More Info:** [https://www.jamovi.org/release-notes.html](https://www.jamovi.org/release-notes.html)
> **Support Info:** [https://forum.jamovi.org/](https://forum.jamovi.org/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/83785195bf2e0ea4b8ce82de663d3e6e3d950b4483bd3ef2800dcf18aa941aeb)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/83785195bf2e0ea4b8ce82de663d3e6e3d950b4483bd3ef2800dcf18aa941aeb)
> 2.7.14 – 12 December 2025 Added option for comma decimal point Added Latex export (thanks SJ!) Added Latex copy (thanks SJ!) General bug-fixes and improvements 2.7.13 – 28 November 2025 Added .ods (LibreOffice) export (thanks SJ!) RM ANOVA - Added contrasts (thanks SJ!) General bug-fixes and improvements

### 


LogMeIn Client 1.3.5662 (x86) (MSI)

> **More Info:** [https://support.logmeininc.com/pro/help/whats-new-in-pro](https://support.logmeininc.com/pro/help/whats-new-in-pro)
> **Support Info:** [https://support.lastpass.com/home](https://support.lastpass.com/home)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/ee200fbb6856396a3ba355fc79479d181687c668fc744364fa8ce5dc62960131)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/ee200fbb6856396a3ba355fc79479d181687c668fc744364fa8ce5dc62960131)
> December 10, 2025 Windows component New icon Client 1.3.0.5662 Plugin 1.0.0.5911 Mac component New icon Client 4.1.0.8056 Plugin 1.0.0.3211 Fixed an issue on Windows computers where the sign-in process did not start after changing the account or subscription in the LogMeIn Control Panel. This problem only affected computers with a new installation of the LogMeIn host or LogMeIn Client app since the previous release. With this update, first-time installations no longer require restarting the host or client application to complete the sign-in. In some cases, when connecting to a remote host from the LogMeIn Client app with previously saved user credentials, the following message was displayed: "Login failed. Stored credentials have been wiped. Please log in manually. (1327)". From now on, you can access such remote devices without re-entering your credentials.

### 


Microsoft Edge 143.0.3650.96 (x64) (MSI)

> **More Info:** [https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel)
> **Support Info:** [https://support.microsoft.com/en-us/microsoft-edge](https://support.microsoft.com/en-us/microsoft-edge)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/e041d7134a3933dbc09d4a7ba46049ce465cc7203098fc7b8f3f35451c2c6827)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/e041d7134a3933dbc09d4a7ba46049ce465cc7203098fc7b8f3f35451c2c6827)
> Version 143.0.3650.96: December 18, 2025 Fixed various bugs, and performance issues. Stable channel security updates are listed here. Version 142.0.3595.136: December 18, 2025 Fixed various bugs, and performance issues for Extended Stable Channel.

### 


Microsoft Edge 143.0.3650.96 (x86) (MSI)

> **More Info:** [https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-relnote-stable-channel)
> **Support Info:** [https://www.microsoft.com/en-us/edge/business/download](https://www.microsoft.com/en-us/edge/business/download)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/8a21891e71fe5e22d0c871303a3a15d933244cb251665f573ea65b1dff1958e5)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/8a21891e71fe5e22d0c871303a3a15d933244cb251665f573ea65b1dff1958e5)
> Version 143.0.3650.96: December 18, 2025 Fixed various bugs, and performance issues. Stable channel security updates are listed here. Version 142.0.3595.136: December 18, 2025 Fixed various bugs, and performance issues for Extended Stable Channel.

### 


Microsoft ODBC Driver 18 for SQL Server 18.6.1 (x64) (MSI)

> **More Info:** [https://learn.microsoft.com/en-us/sql/connect/odbc/windows/release-notes-odbc-sql-server-windows?view=sql-server-ver16](https://learn.microsoft.com/en-us/sql/connect/odbc/windows/release-notes-odbc-sql-server-windows?view=sql-server-ver16)
> **Support Info:** [https://go.microsoft.com/fwlink/?LinkId=191752](https://go.microsoft.com/fwlink/?LinkId=191752)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/000861b703ac28f59f8cc3c7996ef2690ec0f3b20ef9ab2df4b4690a23a3bf16)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/000861b703ac28f59f8cc3c7996ef2690ec0f3b20ef9ab2df4b4690a23a3bf16)
> Version number: 18.6.1.1 Feature added Details New data type Added support for new Vector data type (float32). ConcatNullYieldsNull property Added support for ConcatNullYieldsNull property as both a connection string property and a registry key option.

### 


Microsoft ODBC Driver 18 for SQL Server 18.6.1 (x86) (MSI)

> **More Info:** [https://learn.microsoft.com/en-us/sql/connect/odbc/windows/release-notes-odbc-sql-server-windows?view=sql-server-ver16](https://learn.microsoft.com/en-us/sql/connect/odbc/windows/release-notes-odbc-sql-server-windows?view=sql-server-ver16)
> **Support Info:** [https://go.microsoft.com/fwlink/?LinkId=191752](https://go.microsoft.com/fwlink/?LinkId=191752)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/fc82ccf1b1801d4d6c8b680ad2bbce329e1195d2812635052c1def2df7de3262)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/fc82ccf1b1801d4d6c8b680ad2bbce329e1195d2812635052c1def2df7de3262)
> Version number: 18.6.1.1 Feature added Details New data type Added support for new Vector data type (float32). ConcatNullYieldsNull property Added support for ConcatNullYieldsNull property as both a connection string property and a registry key option.

### 


Mozilla Firefox 146.0.1 ar-AR (x64) (EXE)

> **More Info:** [https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/](https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/ee3cf93afd0c37fcfe5af36a60825907ec44db384724cc221846e45f1edf6c29)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/ee3cf93afd0c37fcfe5af36a60825907ec44db384724cc221846e45f1edf6c29)
> 146.0.1 Firefox Release December 18, 2025 Version 146.0.1, first offered to Release channel users on December 18, 2025 Fixed Improved overall stability by fixing crashes related to browsing, graphics, and accessibility features. (Bugs 2001160, 1998185, 1998188)

### 


Mozilla Firefox 146.0.1 ar-AR (x86) (EXE)

> **More Info:** [https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/](https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/34fa20dbd36db9054a1559dae23a9a1edae893e2c51bf03346f259f0f3f15025)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/34fa20dbd36db9054a1559dae23a9a1edae893e2c51bf03346f259f0f3f15025)
> 146.0.1 Firefox Release December 18, 2025 Version 146.0.1, first offered to Release channel users on December 18, 2025 Fixed Improved overall stability by fixing crashes related to browsing, graphics, and accessibility features. (Bugs 2001160, 1998185, 1998188)

### 


Mozilla Firefox 146.0.1 de-DE (x64) (EXE)

> **More Info:** [https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/](https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/55fabb62ae95963770f271ed274898d3831028408b2e921404f4d580789684e6)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/55fabb62ae95963770f271ed274898d3831028408b2e921404f4d580789684e6)
> 146.0.1 Firefox Release December 18, 2025 Version 146.0.1, first offered to Release channel users on December 18, 2025 Fixed Improved overall stability by fixing crashes related to browsing, graphics, and accessibility features. (Bugs 2001160, 1998185, 1998188)

### 


Mozilla Firefox 146.0.1 de-DE (x86) (EXE)

> **More Info:** [https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/](https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/b3a96837c9357df70bbcb41b162ebe5ff5af23f0f51b9b951cfc1f20308a07e6)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/b3a96837c9357df70bbcb41b162ebe5ff5af23f0f51b9b951cfc1f20308a07e6)
> 146.0.1 Firefox Release December 18, 2025 Version 146.0.1, first offered to Release channel users on December 18, 2025 Fixed Improved overall stability by fixing crashes related to browsing, graphics, and accessibility features. (Bugs 2001160, 1998185, 1998188)

### 


Mozilla Firefox 146.0.1 en-US (x64) (EXE)

> **More Info:** [https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/](https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/4e32935d0b9e423e718c2c31066fa096860771afca4a988709acb448e371de22)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/4e32935d0b9e423e718c2c31066fa096860771afca4a988709acb448e371de22)
> 146.0.1 Firefox Release December 18, 2025 Version 146.0.1, first offered to Release channel users on December 18, 2025 Fixed Improved overall stability by fixing crashes related to browsing, graphics, and accessibility features. (Bugs 2001160, 1998185, 1998188)

### 


Mozilla Firefox 146.0.1 en-US (x86) (EXE)

> **More Info:** [https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/](https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/196061e92b99df0efc76283340539b8ce6e3ec1485e6f79c0f10d682e6a29eee)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/196061e92b99df0efc76283340539b8ce6e3ec1485e6f79c0f10d682e6a29eee)
> 146.0.1 Firefox Release December 18, 2025 Version 146.0.1, first offered to Release channel users on December 18, 2025 Fixed Improved overall stability by fixing crashes related to browsing, graphics, and accessibility features. (Bugs 2001160, 1998185, 1998188)

### 


Mozilla Firefox 146.0.1 tr-TR (x64) (EXE)

> **More Info:** [https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/](https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/190bedebc3a646a727045b627ffdb33f95a393aef5aeaad63dd67ccd7f602f49)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/190bedebc3a646a727045b627ffdb33f95a393aef5aeaad63dd67ccd7f602f49)
> 146.0.1 Firefox Release December 18, 2025 Version 146.0.1, first offered to Release channel users on December 18, 2025 Fixed Improved overall stability by fixing crashes related to browsing, graphics, and accessibility features. (Bugs 2001160, 1998185, 1998188)

### 


Mozilla Firefox 146.0.1 tr-TR (x86) (EXE)

> **More Info:** [https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/](https://www.mozilla.org/en-US/firefox/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-92/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/8cfc4b91905c5065ecc33c78d16f07142c06df0733d9198974e3a5339bad2a81)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/8cfc4b91905c5065ecc33c78d16f07142c06df0733d9198974e3a5339bad2a81)
> 146.0.1 Firefox Release December 18, 2025 Version 146.0.1, first offered to Release channel users on December 18, 2025 Fixed Improved overall stability by fixing crashes related to browsing, graphics, and accessibility features. (Bugs 2001160, 1998185, 1998188)

### 


Mozilla Thunderbird 146.0.1 tr-TR (x64) (EXE)

> **More Info:** [https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/](https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/4e4fa2e8647b649580d66e7c2e9c1c4e2f4f1f5367e9596d23d2d1c53f7bf4ac)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/4e4fa2e8647b649580d66e7c2e9c1c4e2f4f1f5367e9596d23d2d1c53f7bf4ac)
> Thunderbird Desktop Version 146.0.1 | Released December 17, 2025 What’s Fixed fixed Reverted fix that localized consistent special folder names in server’s language

### 


Mozilla Thunderbird 146.0.1 tr-TR (x86) (EXE)

> **More Info:** [https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/](https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/0f0439711ab0a91e8fc8b25f46fa8f35db4d9aca0407ad4b3d0254739dfb6a95)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/0f0439711ab0a91e8fc8b25f46fa8f35db4d9aca0407ad4b3d0254739dfb6a95)
> Thunderbird Desktop Version 146.0.1 | Released December 17, 2025 What’s Fixed fixed Reverted fix that localized consistent special folder names in server’s language

### 


Mozilla Thunderbird 146.0.1 ar-AR (x64) (EXE)

> **More Info:** [https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/](https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/fed3b3548ebaced81e04471180cf141607727294a79b8f5c584cd39619896c82)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/fed3b3548ebaced81e04471180cf141607727294a79b8f5c584cd39619896c82)
> Thunderbird Desktop Version 146.0.1 | Released December 17, 2025 What’s Fixed fixed Reverted fix that localized consistent special folder names in server’s language

### 


Mozilla Thunderbird 146.0.1 ar-AR (x86) (EXE)

> **More Info:** [https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/](https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/95d60558556db1828e7fade69909bc9631a624c9ad6c8858aded1c3a744b36d1)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/95d60558556db1828e7fade69909bc9631a624c9ad6c8858aded1c3a744b36d1)
> Thunderbird Desktop Version 146.0.1 | Released December 17, 2025 What’s Fixed fixed Reverted fix that localized consistent special folder names in server’s language

### 


Mozilla Thunderbird 146.0.1 de-DE (x64) (EXE)

> **More Info:** [https://www.thunderbird.net/en-US/thunderbird/146.0/releasenotes/](https://www.thunderbird.net/en-US/thunderbird/146.0/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/5dd61c8e907bd8cce43da6227de6d7397c1bfe03b906b571fe4f10259e1e3b8a)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/5dd61c8e907bd8cce43da6227de6d7397c1bfe03b906b571fe4f10259e1e3b8a)
> Thunderbird Desktop Version 146.0.1 | Released December 17, 2025 What’s Fixed fixed Reverted fix that localized consistent special folder names in server’s language

### 


Mozilla Thunderbird 146.0.1 de-DE (x86) (EXE)

> **More Info:** [https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/](https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/1044fb2c81ea85d69b8010fe3bc83b319aa89a12807bcc3d9c69eedca34d66bc)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/1044fb2c81ea85d69b8010fe3bc83b319aa89a12807bcc3d9c69eedca34d66bc)
> Thunderbird Desktop Version 146.0.1 | Released December 17, 2025 What’s Fixed fixed Reverted fix that localized consistent special folder names in server’s language

### 


Mozilla Thunderbird 146.0.1 en-US (x64) (EXE)

> **More Info:** [https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/](https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/ef7183efd37cc7c69d9b5f11a41db72b23f3e669d223ab08404a4a05d434e30d)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/ef7183efd37cc7c69d9b5f11a41db72b23f3e669d223ab08404a4a05d434e30d)
> Thunderbird Desktop Version 146.0.1 | Released December 17, 2025 What’s Fixed fixed Reverted fix that localized consistent special folder names in server’s language

### 


Mozilla Thunderbird 146.0.1 en-US (x86) (EXE)

> **More Info:** [https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/](https://www.thunderbird.net/en-US/thunderbird/146.0.1/releasenotes/)
> **Support Info:** [https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/](https://www.mozilla.org/en-US/security/advisories/mfsa2025-95/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/ddc5a87c6bf02bbe86b6ba823c92e713bbac479b238136a319aec78656349189)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/ddc5a87c6bf02bbe86b6ba823c92e713bbac479b238136a319aec78656349189)
> Thunderbird Desktop Version 146.0.1 | Released December 17, 2025 What’s Fixed fixed Reverted fix that localized consistent special folder names in server’s language

### 


Node.js 20.19.6 LTS (x64) (MSI)

> **More Info:** [https://github.com/nodejs/node/releases/tag/v20.19.6](https://github.com/nodejs/node/releases/tag/v20.19.6)
> **Support Info:** [https://nodejs.org/en/docs](https://nodejs.org/en/docs)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/5df7e1bd7de661a3eacd3cd26e9a5828214a0ac8e4021e643f7c7929cda95e5f)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/5df7e1bd7de661a3eacd3cd26e9a5828214a0ac8e4021e643f7c7929cda95e5f)
> 2025-11-25, Version 20.19.6 'Iron' (LTS), @marco-ippolito Notable Changes [6277910a15] - crypto: update root certificates to NSS 3.114 (Node.js GitHub Bot) #59571 [082e50d4a2] - doc: update the instruction on how to verify releases (Antoine du Hamel) #59113 [db68cec4cb] - doc: deprecate HTTP/2 priority signaling (Matteo Collina) #58313

### 


Node.js 20.19.6 LTS (x86) (MSI)

> **More Info:** [https://github.com/nodejs/node/releases/tag/v20.19.6](https://github.com/nodejs/node/releases/tag/v20.19.6)
> **Support Info:** [https://nodejs.org/en/docs](https://nodejs.org/en/docs)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/ab05bb1d0bd3381239cc8f22c6aa7515310f9f8a315c155e4711b103abd212b1)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/ab05bb1d0bd3381239cc8f22c6aa7515310f9f8a315c155e4711b103abd212b1)
> 2025-11-25, Version 20.19.6 'Iron' (LTS), @marco-ippolito Notable Changes [6277910a15] - crypto: update root certificates to NSS 3.114 (Node.js GitHub Bot) #59571 [082e50d4a2] - doc: update the instruction on how to verify releases (Antoine du Hamel) #59113 [db68cec4cb] - doc: deprecate HTTP/2 priority signaling (Matteo Collina) #58313

### 


Node.js 23.11.1 (x64) (MSI)

> **More Info:** [https://github.com/nodejs/node/releases/tag/v23.11.1](https://github.com/nodejs/node/releases/tag/v23.11.1)
> **Support Info:** [https://nodejs.org/en/docs](https://nodejs.org/en/docs)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/5d096e1405e07e995f0dd017dd3575b4e16c8d3e1f583f67b945f55997baf5ad)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/5d096e1405e07e995f0dd017dd3575b4e16c8d3e1f583f67b945f55997baf5ad)
> 2025-05-14, Version 23.11.1 (Current), @RafaelGSS @RafaelGSS RafaelGSS released this May 15 · 3040 commits to main since this release v23.11.1 9b666af This is a security release. Notable Changes src: (CVE-2025-23166) fix error handling on async crypto operation Commits [a271810ce2] - deps: update c-ares to v1.34.5 (Node.js GitHub Bot) #57792 [a12107f0dd] - (CVE-2025-23166) src: fix error handling on async crypto operations (RafaelGSS) nodejs-private/node-private#688

### 


NSClient++ 0.10.9 (x64) (MSI)

> **More Info:** [https://github.com/mickem/nscp/releases](https://github.com/mickem/nscp/releases)
> **Support Info:** [https://nsclient.org/nsclient/](https://nsclient.org/nsclient/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/c99c4e8fc00ad0544fa5e06378b03c6c3453221150f3bfbf17402e94289464fc)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/c99c4e8fc00ad0544fa5e06378b03c6c3453221150f3bfbf17402e94289464fc)
> 0.10.9 Latest What's Changed Minor update which has some code and documentation changes as well as one bugfix: check\_process should show memory values in human readable form i.e. 1234567 (bytes) should be converted to 1.236MB. This is similar to how other size related check work.

### 


NSClient++ 0.10.9 (x86) (MSI)

> **More Info:** [https://github.com/mickem/nscp/releases](https://github.com/mickem/nscp/releases)
> **Support Info:** [https://nsclient.org/nsclient/](https://nsclient.org/nsclient/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/d7c0c4a0ddc8c86e5b041e3573496f3d2303a3aecf55a779756c5cbd653d2564)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/d7c0c4a0ddc8c86e5b041e3573496f3d2303a3aecf55a779756c5cbd653d2564)
> 0.10.9 Latest What's Changed Minor update which has some code and documentation changes as well as one bugfix: check\_process should show memory values in human readable form i.e. 1234567 (bytes) should be converted to 1.236MB. This is similar to how other size related check work.

### 


NTLite 2025.12 (x64) (EXE)

> **More Info:** [https://www.ntlite.com/changelog/](https://www.ntlite.com/changelog/)
> **Support Info:** [https://www.ntlite.com/support/](https://www.ntlite.com/support/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/8219daa8d91a327f691111b22d5dda047ecb9a88373b74616882803e7b485ded)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/8219daa8d91a327f691111b22d5dda047ecb9a88373b74616882803e7b485ded)
> 2025.12.10736 Fix General: Windows 7 & 8.1 host support with a separate download, same features Upgrade UI-Translation: Thanks for Chinese Traditional (Matt), French (tistou77), Hungarian (John), Italian (clarensio), Russian (RDS), wedish (1FF)

### 


OBS Studio 32.0.3 (x64) (EXE)

> **More Info:** [https://github.com/obsproject/obs-studio/releases](https://github.com/obsproject/obs-studio/releases)
> **Support Info:** [https://obsproject.com/help](https://obsproject.com/help)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/8c69a00e23cfeaa441725160586ca0a51c27e557652ed65000df67179dad9ac3)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/8c69a00e23cfeaa441725160586ca0a51c27e557652ed65000df67179dad9ac3)
> 32.0.3 Hotfix Changes Adjusted application shutdown logic [Warchamp7] This is a fairly large change that aims to stabilize OBS Studio's application shutdown process. This reduces the number of scenarios in which the "OBS Studio Unclean Shutdown" dialog will appear and also fixes a crash when forcing a log off or shutdown with active outputs. Fixed a crash during canvas removal [dsaedtler] Fixed a forced application shutdown while changing scene collections due to attempting to access removed sources [exeldro] Fixed several audio monitoring deduplication issues [pkv]

### 


Opera 125.0.5729.49 (x64) (EXE)

> **More Info:** [https://blogs.opera.com/desktop/2025/12/opera-125-0-5729-49-stable-update/](https://blogs.opera.com/desktop/2025/12/opera-125-0-5729-49-stable-update/)
> **Support Info:** [https://www.opera.com/help](https://www.opera.com/help)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/37476581b9bdf1845875cdd27bfc9672a056d6218612597f1ed836f047d9e829)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/37476581b9bdf1845875cdd27bfc9672a056d6218612597f1ed836f047d9e829)
> Opera 125.0.5729.49 Stable update What’s included in this update: Fixed an issue where Start Page tiles were cut off, ensuring a cleaner layout. Restored the missing Third-Party Cookies blocking section in Settings. Resolved a red flash on launch and window maximization on Windows 10. Corrected a shifted Snapshot image on macOS.

### 


Opera 125.0.5729.49 (x86) (EXE)

> **More Info:** [https://blogs.opera.com/desktop/2025/12/opera-125-0-5729-49-stable-update/](https://blogs.opera.com/desktop/2025/12/opera-125-0-5729-49-stable-update/)
> **Support Info:** [https://www.opera.com/help](https://www.opera.com/help)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/20ee0a58d03b0edb517f8a14011480fed2cb71f9059f37bd5ef41056ef083534)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/20ee0a58d03b0edb517f8a14011480fed2cb71f9059f37bd5ef41056ef083534)
> Opera 125.0.5729.49 Stable update What’s included in this update: Fixed an issue where Start Page tiles were cut off, ensuring a cleaner layout. Restored the missing Third-Party Cookies blocking section in Settings. Resolved a red flash on launch and window maximization on Windows 10. Corrected a shifted Snapshot image on macOS.

### 


RoboForm for Windows 9.9.1 (x86) (MSI)

> **More Info:** [https://www.roboform.com/news-windows](https://www.roboform.com/news-windows)
> **Support Info:** [https://www.roboform.com/support](https://www.roboform.com/support)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/b9b36f1c4e1d7f3446d79a756cd46fcdd5f01854ef1d61562cb7ef1b57efd016)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/b9b36f1c4e1d7f3446d79a756cd46fcdd5f01854ef1d61562cb7ef1b57efd016)
> Version 9.9.1 on 2025-12-17 \* Updated RoboForm icon for the locked state. \* Fixed auto-backup creation for user data. \* Applied new client-side policies for new authentication method. \* Added Caps Lock indicator in Unlock UI.

### 


Salesforce CLI v2 2.116.6 (x64) (EXE)

> **More Info:** [https://github.com/forcedotcom/cli/blob/main/releasenotes/README.md](https://github.com/forcedotcom/cli/blob/main/releasenotes/README.md)
> **Support Info:** [https://developer.salesforce.com/docs](https://developer.salesforce.com/docs)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/a02875cfdfa22439b4254c56ec7c6252af0ab1b58dec9174e799fe41cdf318af)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/a02875cfdfa22439b4254c56ec7c6252af0ab1b58dec9174e799fe41cdf318af)
> 2.116.6 (Dec 17, 2025) [stable] NEW: Specify the number of seconds to poll the org to check for the test status when you run apex test run with the new --poll-interval. Previously the poll interval was hard-coded to 1 second. This example shows how to set the poll interval to 5 seconds: sf apex run test --class-names MyClassTest --result-format human --poll-interval 5 --target-org my-org (GitHub Issue #3456, plugin-apex PR #832, salesforcedx-apex PR #597) FIX: If an org is configured to block API connections, running one of the org login CLI commands now fails quickly rather than going into a loop until, for example, maximum login requests are reached. (GitHub Issue #3428, sfdx-core PR #1248, jsforce PR #1774)

### 


Tailscale 1.92.3 (x86) (EXE)

> **More Info:** [https://tailscale.com/changelog/](https://tailscale.com/changelog/)
> **Support Info:** [https://tailscale.com/contact/support/](https://tailscale.com/contact/support/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/03b89281094a39bc83888d86a5cbdfcd4decd0727a2278ee64cf14acf7e924f1)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/03b89281094a39bc83888d86a5cbdfcd4decd0727a2278ee64cf14acf7e924f1)
> Tailscale container image v1.92.3 A new release of the Tailscale container image is available. You can download it from Docker Hub or from our GitHub packages repository. iptables can be used on hosts that don't support nftables, as expected. Tailscale Kubernetes Operator v1.92.3 A new release of the Tailscale Kubernetes Operator is available. For guidance on installing and updating, refer to our installation instructions.

### 


TeamViewer 15.73.5 (x64) (EXE)

> **More Info:** [https://community.teamviewer.com/English/discussion/142915/windows-v15-73-5](https://community.teamviewer.com/English/discussion/142915/windows-v15-73-5)
> **Support Info:** [https://www.teamviewer.com/en/support/documents/](https://www.teamviewer.com/en/support/documents/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/02193a04b0120c9016b94e80ea6992939db4a904f8d2b35df7cc042d3db53a99)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/02193a04b0120c9016b94e80ea6992939db4a904f8d2b35df7cc042d3db53a99)
> [Windows] v15.73.5 Bugfixes Fixed a critical issue that could cause a delay when connecting to devices. Windows LAPS integration: UAC autofill reliability has been improved

### 


TeamViewer 15.73.5 (x86) (EXE)

> **More Info:** [https://community.teamviewer.com/English/discussion/142915/windows-v15-73-5](https://community.teamviewer.com/English/discussion/142915/windows-v15-73-5)
> **Support Info:** [https://www.teamviewer.com/en/support/documents/](https://www.teamviewer.com/en/support/documents/)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/46ee270fc61004e1421f1d804a48315afafba68d448272c37c615ed080bc6343)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/46ee270fc61004e1421f1d804a48315afafba68d448272c37c615ed080bc6343)
> [Windows] v15.73.5 Bugfixes Fixed a critical issue that could cause a delay when connecting to devices. Windows LAPS integration: UAC autofill reliability has been improved

### 


Zabbix Agent 2 7.4.6 (x64) (MSI)

> **More Info:** [https://www.zabbix.com/release_notes](https://www.zabbix.com/release_notes)
> **Support Info:** [https://www.zabbix.com/services](https://www.zabbix.com/services)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/f86df9b5703a094e70c7c169d6b16b41f831351cb3063314ed43fa7ab74ddaff)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/f86df9b5703a094e70c7c169d6b16b41f831351cb3063314ed43fa7ab74ddaff)
> Release Notes for Zabbix 7.4.6 18 December 2025 Zabbix Team is pleased to announce the availability of Zabbix 7.4.6. Zabbix is an enterprise-class open source distributed monitoring solution. Zabbix is released under the GNU Affero General Public License version 3 (AGPLv3), thus it is free of charge for both commercial and non-commercial use. More about Zabbix license.

### 


Zabbix Agent 7.4.6 (x64) (MSI)

> **More Info:** [https://www.zabbix.com/release_notes](https://www.zabbix.com/release_notes)
> **Support Info:** [https://www.zabbix.com/services](https://www.zabbix.com/services)
> **VirusTotal:** [GoTo: VirusTotal](https://www.virustotal.com/gui/file/6a3f4a8f16b281187ce084b4f16ce7fcf806702187d63c6d3e9721ab25d65ab8)
> **Kaspersky:** [GoTo: OpenTip](https://opentip.kaspersky.com/6a3f4a8f16b281187ce084b4f16ce7fcf806702187d63c6d3e9721ab25d65ab8)
> Release Notes for Zabbix 7.4.6 18 December 2025 Zabbix Team is pleased to announce the availability of Zabbix 7.4.6. Zabbix is an enterprise-class open source distributed monitoring solution. Zabbix is released under the GNU Affero General Public License version 3 (AGPLv3), thus it is free of charge for both commercial and non-commercial use. More about Zabbix license.

[PreviousDecember 27 Catalog Update #20251227 - Easy2Patch](/catalog-posts-2025/december-27-catalog-update-20251227-easy2patch)[NextDecember 13 Catalog Update #20251212 - Easy2Patch](/catalog-posts-2025/december-13-catalog-update-20251212-easy2patch)
Last updated <time data-visual-test="transparent" datetime="2025-12-23T17:24:51.595Z" data-state="closed">4 months ago</time>
