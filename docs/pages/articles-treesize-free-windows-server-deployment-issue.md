---
layout: post
title: "TreeSize Free Windows Server Deployment Issue"
date: 2026-05-03
categories: [blog]
---

## 


Issue Description

TreeSize Free is a widely used disk space analyzer. The latest versions of this software, which is available in the Easy2Patch catalog, now require a license to run on Windows Server operating systems. As a result, the free version of TreeSize Free can no longer be installed or updated on Windows Server.

When updating TreeSize Free through Easy2Patch, the update is successfully applied to Windows client systems. However, it fails on Windows Server due to licensing restrictions, resulting in the 0x87D00668 (Software update still detected as actionable after apply) error.

## 


Error Explanation

This error indicates that after the software update is applied, the system still detects it as required. In other words, the update was not successfully installed, or the system could not verify that the update was applied as expected.

### 


Possible Causes:

- Incomplete or Failed Installation: The update may not have been properly installed.
- Issues with Detection Rules: SCCM or Intune may not be able to verify that the update was successfully applied.
- Incorrect Deployment Scope: The update may have been targeted at the wrong systems, leading to an improper installation.
- Missing Prerequisite Updates: The required previous patches or dependencies may be missing.

### 


Recommended Solutions:

- Verify whether the update has been manually installed.
- Review detection rules in SCCM or Intune to ensure proper validation of the update.
- Check update logs (e.g., under C:\Windows\CCM\Logs) for additional error details.
- Assess whether the update is truly needed on the system and verify proper targeting.

## 


Solution Approaches

To prevent this issue and avoid deploying TreeSize Free updates to Windows Server, consider the following steps:

Update SCCM or Intune Deployment Rules:

- Ensure that SCCM or Intune deployments of TreeSize Free updates are targeted only at Windows Client versions.
- Exclude collections that include Windows Server systems from receiving this update.

Consider Alternative Solutions:

- Use TreeSize Professional or other licensed alternatives for Windows Server environments.
- Explore built-in Windows tools or open-source alternatives for disk space analysis on servers.

By implementing these measures, you can prevent the accidental deployment of TreeSize Free to Windows Server systems and avoid the 0x87D00668 error.

[PreviousGit for Windows 2.48.1 is the final version of 32-bit](/articles/git-for-windows-2.48.1-is-the-final-version-of-32-bit)[NextGoogle Chrome 131.0.6778.204/205 Update Released](/articles/google-chrome-131.0.6778.204-205-update-released)
Last updated <time data-visual-test="transparent" datetime="2025-01-30T04:05:51.630Z" data-state="closed">1 year ago</time>
