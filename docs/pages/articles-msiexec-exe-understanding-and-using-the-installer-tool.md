---
layout: post
title: "Msiexec.exe: Understanding and Using the Installer Tool"
date: 2026-05-03
categories: [blog]
source_url: "https://blog.easy2patch.com/articles/msiexec.exe-understanding-and-using-the-installer-tool"
---

`msiexec.exe` is a command-line tool used for managing Microsoft Windows Installer packages (.msi files). This tool can perform various operations such as installing, uninstalling, and repairing software. Below are detailed instructions and examples on how to use the `msiexec.exe` command.

### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_gl39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_gl39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Basic Usage

#### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_gt39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_gt39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Installation

To install an .msi file, you can use the `msiexec` command with the `/i` parameter:

<button type="button" class="button group/button inline-flex items-center gap-2 rounded-xl straight-corners:rounded-none circular-corners:rounded-3xl border border-tint hover:border-tint-hover disabled:border-tint depth-subtle:shadow-xs hover:depth-subtle:shadow-md focus-visible:depth-subtle:shadow-md active:depth-subtle:shadow-xs shadow-tint/6 dark:shadow-tint-1 not-focus-visible:outline-0 contrast-more:border-tint-12 contrast-more:hover:outline-2 contrast-more:hover:outline-tint-12 contrast-more:hover:border-tint-12 contrast-more:focus-visible:border-tint-12 contrast-more:focus-visible:outline-tint-12 hover:depth-subtle:-translate-y-px focus-visible:depth-subtle:-translate-y-px data-[state=open]:depth-subtle:-translate-y-px active:depth-subtle:translate-y-0 transition-all grow-0 shrink-0 truncate max-w-full align-middle disabled:cursor-not-allowed disabled:translate-y-0! disabled:shadow-none! bg-tint depth-flat:bg-transparent text-tint hover:bg-tint-hover hover:not-disabled:depth-flat:bg-tint-hover hover:not-disabled:text-tint contrast-more:bg-tint-subtle disabled:bg-transparent disabled:text-tint/8 p-1 text-sm/tight rounded-corners:rounded-lg px-2 absolute top-2 right-2 z-2 self-start justify-self-end font-sans leading-none opacity-0 backdrop-blur-md group-hover/codeblock:opacity-11 translate-y-0! print:hidden"><span class="button-content truncate">Copy</span></button>

```
msiexec /i package.msi
```

Example:

<button type="button" class="button group/button inline-flex items-center gap-2 rounded-xl straight-corners:rounded-none circular-corners:rounded-3xl border border-tint hover:border-tint-hover disabled:border-tint depth-subtle:shadow-xs hover:depth-subtle:shadow-md focus-visible:depth-subtle:shadow-md active:depth-subtle:shadow-xs shadow-tint/6 dark:shadow-tint-1 not-focus-visible:outline-0 contrast-more:border-tint-12 contrast-more:hover:outline-2 contrast-more:hover:outline-tint-12 contrast-more:hover:border-tint-12 contrast-more:focus-visible:border-tint-12 contrast-more:focus-visible:outline-tint-12 hover:depth-subtle:-translate-y-px focus-visible:depth-subtle:-translate-y-px data-[state=open]:depth-subtle:-translate-y-px active:depth-subtle:translate-y-0 transition-all grow-0 shrink-0 truncate max-w-full align-middle disabled:cursor-not-allowed disabled:translate-y-0! disabled:shadow-none! bg-tint depth-flat:bg-transparent text-tint hover:bg-tint-hover hover:not-disabled:depth-flat:bg-tint-hover hover:not-disabled:text-tint contrast-more:bg-tint-subtle disabled:bg-transparent disabled:text-tint/8 p-1 text-sm/tight rounded-corners:rounded-lg px-2 absolute top-2 right-2 z-2 self-start justify-self-end font-sans leading-none opacity-0 backdrop-blur-md group-hover/codeblock:opacity-11 translate-y-0! print:hidden"><span class="button-content truncate">Copy</span></button>

```
msiexec /i example.msi
```

#### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_i539bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_i539bsnqj6iv5ubsnpfivb_)"></rect></svg>

Uninstallation

To uninstall an installed program, you can use the `msiexec` command with the `/x` parameter:

<button type="button" class="button group/button inline-flex items-center gap-2 rounded-xl straight-corners:rounded-none circular-corners:rounded-3xl border border-tint hover:border-tint-hover disabled:border-tint depth-subtle:shadow-xs hover:depth-subtle:shadow-md focus-visible:depth-subtle:shadow-md active:depth-subtle:shadow-xs shadow-tint/6 dark:shadow-tint-1 not-focus-visible:outline-0 contrast-more:border-tint-12 contrast-more:hover:outline-2 contrast-more:hover:outline-tint-12 contrast-more:hover:border-tint-12 contrast-more:focus-visible:border-tint-12 contrast-more:focus-visible:outline-tint-12 hover:depth-subtle:-translate-y-px focus-visible:depth-subtle:-translate-y-px data-[state=open]:depth-subtle:-translate-y-px active:depth-subtle:translate-y-0 transition-all grow-0 shrink-0 truncate max-w-full align-middle disabled:cursor-not-allowed disabled:translate-y-0! disabled:shadow-none! bg-tint depth-flat:bg-transparent text-tint hover:bg-tint-hover hover:not-disabled:depth-flat:bg-tint-hover hover:not-disabled:text-tint contrast-more:bg-tint-subtle disabled:bg-transparent disabled:text-tint/8 p-1 text-sm/tight rounded-corners:rounded-lg px-2 absolute top-2 right-2 z-2 self-start justify-self-end font-sans leading-none opacity-0 backdrop-blur-md group-hover/codeblock:opacity-11 translate-y-0! print:hidden"><span class="button-content truncate">Copy</span></button>

```
msiexec /x {ProductCode}
```

Example:

<button type="button" class="button group/button inline-flex items-center gap-2 rounded-xl straight-corners:rounded-none circular-corners:rounded-3xl border border-tint hover:border-tint-hover disabled:border-tint depth-subtle:shadow-xs hover:depth-subtle:shadow-md focus-visible:depth-subtle:shadow-md active:depth-subtle:shadow-xs shadow-tint/6 dark:shadow-tint-1 not-focus-visible:outline-0 contrast-more:border-tint-12 contrast-more:hover:outline-2 contrast-more:hover:outline-tint-12 contrast-more:hover:border-tint-12 contrast-more:focus-visible:border-tint-12 contrast-more:focus-visible:outline-tint-12 hover:depth-subtle:-translate-y-px focus-visible:depth-subtle:-translate-y-px data-[state=open]:depth-subtle:-translate-y-px active:depth-subtle:translate-y-0 transition-all grow-0 shrink-0 truncate max-w-full align-middle disabled:cursor-not-allowed disabled:translate-y-0! disabled:shadow-none! bg-tint depth-flat:bg-transparent text-tint hover:bg-tint-hover hover:not-disabled:depth-flat:bg-tint-hover hover:not-disabled:text-tint contrast-more:bg-tint-subtle disabled:bg-transparent disabled:text-tint/8 p-1 text-sm/tight rounded-corners:rounded-lg px-2 absolute top-2 right-2 z-2 self-start justify-self-end font-sans leading-none opacity-0 backdrop-blur-md group-hover/codeblock:opacity-11 translate-y-0! print:hidden"><span class="button-content truncate">Copy</span></button>

```
msiexec /x {12345678-1234-1234-1234-123456789012}
```

You can find the product code by using the registry or system auditing tools.

#### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_jl39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_jl39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Repair

To repair an .msi installation, you can use the `msiexec` command with the `/f` parameter:

<button type="button" class="button group/button inline-flex items-center gap-2 rounded-xl straight-corners:rounded-none circular-corners:rounded-3xl border border-tint hover:border-tint-hover disabled:border-tint depth-subtle:shadow-xs hover:depth-subtle:shadow-md focus-visible:depth-subtle:shadow-md active:depth-subtle:shadow-xs shadow-tint/6 dark:shadow-tint-1 not-focus-visible:outline-0 contrast-more:border-tint-12 contrast-more:hover:outline-2 contrast-more:hover:outline-tint-12 contrast-more:hover:border-tint-12 contrast-more:focus-visible:border-tint-12 contrast-more:focus-visible:outline-tint-12 hover:depth-subtle:-translate-y-px focus-visible:depth-subtle:-translate-y-px data-[state=open]:depth-subtle:-translate-y-px active:depth-subtle:translate-y-0 transition-all grow-0 shrink-0 truncate max-w-full align-middle disabled:cursor-not-allowed disabled:translate-y-0! disabled:shadow-none! bg-tint depth-flat:bg-transparent text-tint hover:bg-tint-hover hover:not-disabled:depth-flat:bg-tint-hover hover:not-disabled:text-tint contrast-more:bg-tint-subtle disabled:bg-transparent disabled:text-tint/8 p-1 text-sm/tight rounded-corners:rounded-lg px-2 absolute top-2 right-2 z-2 self-start justify-self-end font-sans leading-none opacity-0 backdrop-blur-md group-hover/codeblock:opacity-11 translate-y-0! print:hidden"><span class="button-content truncate">Copy</span></button>

```
msiexec /f package.msi
```

Example:
<template id="B:1"></template>
### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_kt39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_kt39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Parameters

Here are some important parameters you can use with the `msiexec` command:

- `/i`: Install.
- `/x`: Uninstall.
- `/f`: Repair.
- `/qn`: Quiet installation (no user interface).
- `/qb`: Basic user interface installation.
- `/l*v log_file`: Generate a detailed log file.

#### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_ll39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_ll39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Quiet Installation

To install an .msi file quietly (without a user interface):
<template id="B:2"></template>
Example:
<template id="B:3"></template>
#### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_mt39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_mt39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Generating a Log File

To generate a log file during the installation process:
<template id="B:4"></template>
Example:
<template id="B:5"></template>
### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_o539bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_o539bsnqj6iv5ubsnpfivb_)"></rect></svg>

Customized Installation

Some MSI files allow for the selection of specific features or settings. You can specify these features using the `PROPERTY=VALUE` format:
<template id="B:6"></template>
Example:
<template id="B:7"></template>
### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_pd39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_pd39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Examples

#### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_pl39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_pl39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Basic Installation

<template id="B:8"></template>
#### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_q539bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_q539bsnqj6iv5ubsnpfivb_)"></rect></svg>

Quiet Installation

<template id="B:9"></template>
#### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_ql39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_ql39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Uninstallation

<template id="B:a"></template>
#### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_r539bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_r539bsnqj6iv5ubsnpfivb_)"></rect></svg>

Installation with Log File

<template id="B:b"></template>
#### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_rl39bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_rl39bsnqj6iv5ubsnpfivb_)"></rect></svg>

Customized Quiet Installation

<template id="B:c"></template>
### 
<svg class="gb-icon self-center transition-colors text-transparent group-hover/hash:text-tint-subtle contrast-more:group-hover/hash:text-tint-strong size-4"><title>hashtag</title><defs><mask id="_R_s539bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/hashtag.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_s539bsnqj6iv5ubsnpfivb_)"></rect></svg>

Conclusion

`msiexec.exe` is a powerful tool for software deployment and management in a Windows environment. The examples and parameters above show how the `msiexec` command can be used in various scenarios. For more information, you can refer to the official Microsoft documentation.

[PreviousGoogle Chrome 131.0.6778.204/205 Update Released<svg class="gb-icon hidden size-4 text-tint-subtle contrast-more:text-tint-strong group-hover:text-primary md:block"><title>chevron-left</title><defs><mask id="_R_jb9bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/chevron-left.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_jb9bsnqj6iv5ubsnpfivb_)"></rect></svg>](/articles/google-chrome-131.0.6778.204-205-update-released)[NextPassword Safe 3.66.0 (x64/x86) (MSI) Failed to Install Error 1683<svg class="gb-icon hidden size-4 text-tint-subtle contrast-more:text-tint-strong group-hover:text-primary md:block"><title>chevron-right</title><defs><mask id="_R_lb9bsnqj6iv5ubsnpfivb_" style="mask-type:alpha"><image data-testid="mask-image" href="https://ka-p.fontawesome.com/releases/v7.2.0/svgs/regular/chevron-right.svg?v=2&token=a463935e93" width="100%" height="100%" preserveaspectratio="xMidYMid meet"></image></mask></defs><rect width="100%" height="100%" fill="currentColor" mask="url(#_R_lb9bsnqj6iv5ubsnpfivb_)"></rect></svg>](/articles/password-safe-3.66.0-x64-x86-msi-failed-to-install-error-1683)
Last updated <time data-visual-test="transparent" datetime="2024-06-19T06:54:03.053Z" data-state="closed">1 year ago</time>
