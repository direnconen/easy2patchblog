---
layout: post
title: "Local Publishing Maximum Cab Size Setting"
date: 2026-05-03
categories: [blog]
source_url: "https://blog.easy2patch.com/articles/local-publishing-maximum-cab-size-setting"
---

There is a default limit for CAB files that can be published / created within WSUS Local Publishing. This limit is 384 MB. Therefore, updates larger than 384MB cannot be published over WSUS. However, this limit value may be changed and larger updates may be released. There are several ways to change this setting.

1. Powershell

<button type="button" class="button group/button inline-flex items-center gap-2 rounded-xl straight-corners:rounded-none circular-corners:rounded-3xl border border-tint hover:border-tint-hover disabled:border-tint depth-subtle:shadow-xs hover:depth-subtle:shadow-md focus-visible:depth-subtle:shadow-md active:depth-subtle:shadow-xs shadow-tint/6 dark:shadow-tint-1 not-focus-visible:outline-0 contrast-more:border-tint-12 contrast-more:hover:outline-2 contrast-more:hover:outline-tint-12 contrast-more:hover:border-tint-12 contrast-more:focus-visible:border-tint-12 contrast-more:focus-visible:outline-tint-12 hover:depth-subtle:-translate-y-px focus-visible:depth-subtle:-translate-y-px data-[state=open]:depth-subtle:-translate-y-px active:depth-subtle:translate-y-0 transition-all grow-0 shrink-0 truncate max-w-full align-middle disabled:cursor-not-allowed disabled:translate-y-0! disabled:shadow-none! bg-tint depth-flat:bg-transparent text-tint hover:bg-tint-hover hover:not-disabled:depth-flat:bg-tint-hover hover:not-disabled:text-tint contrast-more:bg-tint-subtle disabled:bg-transparent disabled:text-tint/8 p-1 text-sm/tight rounded-corners:rounded-lg px-2 absolute top-2 right-2 z-2 self-start justify-self-end font-sans leading-none opacity-0 backdrop-blur-md group-hover/codeblock:opacity-11 translate-y-0! print:hidden"><span class="button-content truncate">Copy</span></button>

```
$wsus = [Microsoft.UpdateServices.Administration.AdminProxy]::GetUpdateServer()
$CurrentSize = $wsus.GetConfiguration().LocalPublishingMaxCabSize
Write-host "Current Max Size" $CurrentSize
$config = $wsus.GetConfiguration()
$NewSize = 1024
$config.LocalPublishingMaxCabSize = $NewSize
$config.save()
```

1. Easy2Patch

Within Easy2Patch settings there is a field to set the LocalPublishingMaxCabSize value. The "Local Publishing Max Size" value can be changed under {Settings}{SCCM/WSUS}{WSUS Settings}. The value in MB is determined. The maximum value that can be entered in this field will be 2048 MB. For updates distributed with Easy2Patch, a value of 1024 will be sufficient as of the writing date of the article. However, you can increase this area according to your needs.

!

[PreviousImportance of Updating 3rd Party Applications<svg class="gb-icon hidden size-4 text-tint-subtle contrast-more:text-tint-strong group-hover:text-primary md:block"><title>chevron-left</title><defs><mask id="_R_jb9bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/chevron-left.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_jb9bsnqj6iv5ubsnpfivb_)"></rect></svg>](/articles/importance-of-updating-3rd-party-applications)[NextWhat should be considered to use 3rd Party software safely?<svg class="gb-icon hidden size-4 text-tint-subtle contrast-more:text-tint-strong group-hover:text-primary md:block"><title>chevron-right</title><defs><mask id="_R_lb9bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/chevron-right.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_lb9bsnqj6iv5ubsnpfivb_)"></rect></svg>](/articles/what-should-be-considered-to-use-3rd-party-software-safely)
Last updated <time data-visual-test="transparent" datetime="2023-05-07T18:22:22.000Z" data-state="closed">2 years ago</time>
