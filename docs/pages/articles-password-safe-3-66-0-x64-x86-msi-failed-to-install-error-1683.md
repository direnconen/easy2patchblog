---
layout: post
title: "Password Safe 3.66.0 (x64/x86) (MSI) Failed to Install Error 1683"
date: 2026-05-03
categories: [blog]
---

Product installations fail because the MSI ProductCode values ​​of the Password Safe application installation file are the same in 3.65.1 and 3.66.0 versions. Error 1683 is received in Easy2Patch, Configuration Manager, Intune and manual installations of the application and the installation cannot be performed.

An update is expected in the setup file by the manufacturer of the application.

In both versions, the ProductCode value of both the 64-bit and 32-bit installation file is assigned as c2a02857-d138-446b-b181-442dee20c8e6.

[PreviousMsiexec.exe: Understanding and Using the Installer Tool](/articles/msiexec.exe-understanding-and-using-the-installer-tool)[NextGPL Ghostscript Silent Install Removed](/articles/gpl-ghostscript-silent-install-removed)
Last updated <time data-visual-test="transparent" datetime="2024-06-01T20:05:04.855Z" data-state="closed">1 year ago</time>
