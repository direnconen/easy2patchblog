---
layout: post
title: "Scan Microsoft ConfigMgr for Supported Third-Party Products for Patching (Update statistics)"
date: 2026-05-03
categories: [blog]
---

Easy2Patch allows over 400 3rd party software to be updated. Its catalog expands every week and can support more 3rd party products. You can view how well the products in the Easy2Patch catalog are supported in your corporate network with the **Update Statistics** button. The **Update Statistics** button connects to the database of the SCCM server and compares it with the products in the catalogue. Next to each product, it shows how many computers are installed in the system. In order to see this information properly, it is necessary to specify the SCCM database on the settings screen. 

## 


Settings

1. Open the Easy2Patch application,

!

1. Go to the Settings screen,
2. Press the SCCM/WSUS/INTUNE button,
3. Switch to the Database Settings tab,
4. Enter the name of ConfigMgr's database server in the Data Source field,
5. Enter the name of your ConfigMgr database in the Initial Catalog field. This name is usually CM\_ (Site Code is the 3-digit site code specified in the ConfigMgr installation. For example: CM\_ARK,
6. Windows Authentication is preferred. However, if your build uses SQL authentication, you will need to enter your SQL credentials.

!

1. When you press the test button, if you have authorization and network access, the connection is successful.

!

1. Save the settings by pressing the Save button.

## 


Update Statistics

After the settings are made, you go to the Manage screen. While on this screen, press the Update Statistics button. Next to each application, the number of computers it is installed on is written as [X].

!

[PreviousWhat is Easy2Patch?](/articles/what-is-easy2patch)[NextEasy2Patch 1.x End Of Life](/articles/easy2patch-1.x-end-of-life)
Last updated <time data-visual-test="transparent" datetime="2024-02-27T11:54:15.406Z" data-state="closed">2 years ago</time>
