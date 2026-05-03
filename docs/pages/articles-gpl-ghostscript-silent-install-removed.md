---
layout: post
title: "GPL Ghostscript Silent Install Removed"
date: 2026-05-03
categories: [blog]
---

Ghostscript has the most comprehensive conversion capabilities and flexibility of any Page Description Language (PDL) software. Multi-platform support and a wide array of customizable modules make Ghostscript the premier solution to drive your print and document management needs.

Ghostscript is an interpreter for the PostScript® language and PDF files. Ghostscript consists of a PostScript interpreter layer and a graphics library.

According to the statement made by Artifex company, GPL Ghostscript distribution has included a silent installer option for system administrators to deploy the software across multiple machines without notifying end users about the installation or the GNU AGPL license. However, with Ghostscript 10.01.0, Artifex has reluctantly decided to disable this feature.

Nonetheless, faced with undeniable evidence that this option has been abused, the company has made the decision that we are no longer prepared to ship a GNU AGPL licensed binary with this option enabled by default. We have received numerous concerning reports from users who were unaware that Ghostscript was installed on their systems, often running outdated and vulnerable releases.

When you try to deploy this application (as update or installation), on your systems with Easy2Patch, Configuration Manager or Intune, the user will encounter the setup UI of the application. Considering this situation, you should distribute the application to your users.

[PreviousPassword Safe 3.66.0 (x64/x86) (MSI) Failed to Install Error 1683](/articles/password-safe-3.66.0-x64-x86-msi-failed-to-install-error-1683)[NextWhat is Easy2Patch?](/articles/what-is-easy2patch)
Last updated <time data-visual-test="transparent" datetime="2024-06-01T10:09:05.907Z" data-state="closed">1 year ago</time>
