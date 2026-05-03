---
layout: post
title: "Msiexec.exe: Understanding and Using the Installer Tool"
date: 2026-05-03
categories: [blog]
---

`msiexec.exe` is a command-line tool used for managing Microsoft Windows Installer packages (.msi files). This tool can perform various operations such as installing, uninstalling, and repairing software. Below are detailed instructions and examples on how to use the `msiexec.exe` command.

### 


Basic Usage

#### 


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


Repair

To repair an .msi installation, you can use the `msiexec` command with the `/f` parameter:

<button type="button" class="button group/button inline-flex items-center gap-2 rounded-xl straight-corners:rounded-none circular-corners:rounded-3xl border border-tint hover:border-tint-hover disabled:border-tint depth-subtle:shadow-xs hover:depth-subtle:shadow-md focus-visible:depth-subtle:shadow-md active:depth-subtle:shadow-xs shadow-tint/6 dark:shadow-tint-1 not-focus-visible:outline-0 contrast-more:border-tint-12 contrast-more:hover:outline-2 contrast-more:hover:outline-tint-12 contrast-more:hover:border-tint-12 contrast-more:focus-visible:border-tint-12 contrast-more:focus-visible:outline-tint-12 hover:depth-subtle:-translate-y-px focus-visible:depth-subtle:-translate-y-px data-[state=open]:depth-subtle:-translate-y-px active:depth-subtle:translate-y-0 transition-all grow-0 shrink-0 truncate max-w-full align-middle disabled:cursor-not-allowed disabled:translate-y-0! disabled:shadow-none! bg-tint depth-flat:bg-transparent text-tint hover:bg-tint-hover hover:not-disabled:depth-flat:bg-tint-hover hover:not-disabled:text-tint contrast-more:bg-tint-subtle disabled:bg-transparent disabled:text-tint/8 p-1 text-sm/tight rounded-corners:rounded-lg px-2 absolute top-2 right-2 z-2 self-start justify-self-end font-sans leading-none opacity-0 backdrop-blur-md group-hover/codeblock:opacity-11 translate-y-0! print:hidden"><span class="button-content truncate">Copy</span></button>

```
msiexec /f package.msi
```

Example:
<template id="B:1"></template>
### 


Parameters

Here are some important parameters you can use with the `msiexec` command:

- `/i`: Install.
- `/x`: Uninstall.
- `/f`: Repair.
- `/qn`: Quiet installation (no user interface).
- `/qb`: Basic user interface installation.
- `/l*v log_file`: Generate a detailed log file.

#### 


Quiet Installation

To install an .msi file quietly (without a user interface):
<template id="B:2"></template>
Example:
<template id="B:3"></template>
#### 


Generating a Log File

To generate a log file during the installation process:
<template id="B:4"></template>
Example:
<template id="B:5"></template>
### 


Customized Installation

Some MSI files allow for the selection of specific features or settings. You can specify these features using the `PROPERTY=VALUE` format:
<template id="B:6"></template>
Example:
<template id="B:7"></template>
### 


Examples

#### 


Basic Installation

<template id="B:8"></template>
#### 


Quiet Installation

<template id="B:9"></template>
#### 


Uninstallation

<template id="B:a"></template>
#### 


Installation with Log File

<template id="B:b"></template>
#### 


Customized Quiet Installation

<template id="B:c"></template>
### 


Conclusion

`msiexec.exe` is a powerful tool for software deployment and management in a Windows environment. The examples and parameters above show how the `msiexec` command can be used in various scenarios. For more information, you can refer to the official Microsoft documentation.

[PreviousGoogle Chrome 131.0.6778.204/205 Update Released](/articles/google-chrome-131.0.6778.204-205-update-released)[NextPassword Safe 3.66.0 (x64/x86) (MSI) Failed to Install Error 1683](/articles/password-safe-3.66.0-x64-x86-msi-failed-to-install-error-1683)
Last updated <time data-visual-test="transparent" datetime="2024-06-19T06:54:03.053Z" data-state="closed">1 year ago</time>
