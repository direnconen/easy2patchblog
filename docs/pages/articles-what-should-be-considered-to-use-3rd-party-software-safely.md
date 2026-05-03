---
layout: post
title: "What should be considered to use 3rd Party software safely?"
date: 2026-05-03
categories: [blog]
source_url: "https://blog.easy2patch.com/articles/what-should-be-considered-to-use-3rd-party-software-safely"
---

> 
> In our previous article, we briefly talked about 3rd Party software. Click the [link <svg class="gb-icon ml-0.5 inline size-3 links-accent:text-tint-subtle"><title>arrow-up-right</title><defs><mask id="_R_j4d39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/arrow-up-right.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_j4d39bsnqj6iv5ubsnpfivb_)"></rect></svg>](https://blog.easy2patch.com/2022/11/07/what-is-a-3rd-party-product/)to read this article. In this article, we will try to explain the methods of using 3rd Party software safely and the do's and don'ts.
> 
> Some of the 3rd Party software is paid and can be downloaded from the manufacturer's page with a subscription after purchasing a certain license. However, most of the 3rd Party software is offered free of charge and can be downloaded from the manufacturer's web pages or obtained in different formats from different sources.

### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_4l39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_4l39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Right File from the Right Source

> 
> The sources from which the software is obtained, whether paid or not, are very important. Users can sometimes obtain 3rd party products from different download pages for different interface visuals presented in the software, sometimes different versions with added capabilities that are not in the original product, and sometimes differentiated setup files to be used in management tools such as SCCM that can install automatic software. One of the most common examples of this (now the manufacturer provides it!) is the Mozilla Firefox product. Since the msi package of this product has not been released for years, we have seen that the SCCM administrators distribute the Mozilla Firefox packages, which are provided as msi of unknown origin, in large corporate networks to take advantage of the blessings of distribution with MSI. Although this seems like a very innocent request, those who know the NotPetya attack in 2017 know that this distribution process did not lead to such optimistic results. Here, the attackers have infiltrated the systems by hiding behind the update of a very famous accounting software and caused billions of dollars of damage around the world. It should be ensured that the products are downloaded from the CORRECT SOURCE and the CORRECT FILE, and it should be confirmed that the file is NOT corrupted or changed during the download.
> 
> It is seen that some of the IT managers are not very selective when choosing the 3rd party software to be used in their IT structures, sometimes they distribute the software containing trojan and malware ad-aware to all computers in the network environment because it is very popular. Some of this software stays dormant until the attacker takes action and never shows itself. With the attacker's command, the systems on which this software is installed can be used as zombie computers, as well as infiltrating the IT structure and used to access computer/server systems with critical information.

### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_5539bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_5539bsnqj6iv5ubsnpfivb_)"></rect></svg>

Testing

> 
> Testing has a very important place in the updating processes of 3rd Party products. System and Cyber security administrators should test the software updates they use in their IT structures in a small test environment before distributing them to the general public. Even if it is downloaded from the right source, it must be tested and after the test results are positive, it should be disseminated in parts. After this stage, the updated systems should be followed up and it should be ensured that no negativity is observed.

### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_5l39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_5l39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Manufacturer Selection

> 
> Another important issue is the correct selection of the manufacturers of the software to be installed on computers in IT structures. Features such as support, update frequency, communication are important in the selection of manufacturers and software. Sometimes software that has plenty of vulnerabilities but is quickly closed may not be well looked after because it has too many vulnerabilities. However, issues such as who the manufacturer is and how quickly it responds to these deficits should be considered. As of the date of publication of this article, 100s of High, Medium and low vulnerabilities have been released by Google Chrome Web browsers in 2022, and 6 zero-day vulnerabilities have emerged in addition. However, despite so many vulnerabilities, the manufacturer's healthy communication and fast closing of the gaps enable Google Chrome to be used almost like a single browser, except for a few browsers (including Chromium-based browsers).

### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_6539bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_6539bsnqj6iv5ubsnpfivb_)"></rect></svg>

Financial Loss / Prestige Loss

> 
> Or both? There are 2 basic ideas that are wrong. First, cybersecurity does not contribute directly to revenue, and second, cybersecurity is a feature that can be easily added to the project later if needed. Cyber ​​security has long been considered as software such as Firewall, IPS, WAF, WAP. However, almost all of them are software that protects against external attacks. Software such as anti-virus and anti-malware have been effective against viruses with software containing harmful code. However, a coding error made by the manufacturer unknowingly in the native code of the software is an innocent code snippet that can only be used by attackers. If these vulnerabilities are not noticed by the manufacturer or the cyber security teams, or even if they are noticed and fixed, it is easy to become the target of cyber attacks. After these attacks, the service interruption and the loss of prestige against the customers in parallel with this, and the monetary loss will begin to occur depending on the work done by the company during each service interruption.

### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_6l39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_6l39bsnqj6iv5ubsnpfivb_)"></rect></svg>

3rd Party update management with Easy2Patch

> 
> Easy2Patch is an important cyber security product that integrates with SCCM/WSUS and provides automatic and unattended updates to the software in its catalog. The products in the catalog are constantly monitored almost every day by automatic and manual methods. Published CVEs for updates are tracked and added to the Easy2Patch CVE database. Cybersecurity administrators can use this information to see a list of possible malicious vulnerabilities in their structures. With the rules on the SCCM/WSUS side, they can ensure that the distributions are sent sequentially in test and production environments. You can download Easy2Patch for free, easily integrate it into your structure and start using it. You can download the product from the Easy2Patch web page to try it for free. You can get information about the installation of the product from the help pages, and request a demo from [\[email protected\]](/cdn-cgi/l/email-protection).

[PreviousLocal Publishing Maximum Cab Size Setting<svg class="gb-icon hidden size-4 text-tint-subtle contrast-more:text-tint-strong group-hover:text-primary md:block"><title>chevron-left</title><defs><mask id="_R_jb9bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/chevron-left.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_jb9bsnqj6iv5ubsnpfivb_)"></rect></svg>](/articles/local-publishing-maximum-cab-size-setting)[NextWhat is a 3rd Party Product?<svg class="gb-icon hidden size-4 text-tint-subtle contrast-more:text-tint-strong group-hover:text-primary md:block"><title>chevron-right</title><defs><mask id="_R_lb9bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/chevron-right.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_lb9bsnqj6iv5ubsnpfivb_)"></rect></svg>](/articles/what-is-a-3rd-party-product)
Last updated <time data-visual-test="transparent" datetime="2023-05-07T18:22:45.000Z" data-state="closed">2 years ago</time>
