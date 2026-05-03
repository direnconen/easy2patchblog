---
layout: post
title: "Scan Microsoft ConfigMgr for Supported Third-Party Products for Patching (Update statistics)"
date: 2026-05-03
categories: [blog]
source_url: "https://blog.easy2patch.com/articles/scan-microsoft-configmgr-for-supported-third-party-products-for-patching-update-statistics"
---

Easy2Patch allows over 400 3rd party software to be updated. Its catalog expands every week and can support more 3rd party products. You can view how well the products in the Easy2Patch catalog are supported in your corporate network with the **Update Statistics** button. The **Update Statistics** button connects to the database of the SCCM server and compares it with the products in the catalogue. Next to each product, it shows how many computers are installed in the system. In order to see this information properly, it is necessary to specify the SCCM database on the settings screen. 

## 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_4l39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_4l39bsnqj6iv5ubsnpfivb_)"></rect></svg>

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
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_6l39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_6l39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Update Statistics

After the settings are made, you go to the Manage screen. While on this screen, press the Update Statistics button. Next to each application, the number of computers it is installed on is written as [X].

!

[PreviousWhat is Easy2Patch?<svg class="gb-icon hidden size-4 text-tint-subtle contrast-more:text-tint-strong group-hover:text-primary md:block"><title>chevron-left</title><defs><mask id="_R_jb9bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/chevron-left.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_jb9bsnqj6iv5ubsnpfivb_)"></rect></svg>](/articles/what-is-easy2patch)[NextEasy2Patch 1.x End Of Life<svg class="gb-icon hidden size-4 text-tint-subtle contrast-more:text-tint-strong group-hover:text-primary md:block"><title>chevron-right</title><defs><mask id="_R_lb9bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/chevron-right.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_lb9bsnqj6iv5ubsnpfivb_)"></rect></svg>](/articles/easy2patch-1.x-end-of-life)
Last updated <time data-visual-test="transparent" datetime="2024-02-27T11:54:15.406Z" data-state="closed">2 years ago</time>
