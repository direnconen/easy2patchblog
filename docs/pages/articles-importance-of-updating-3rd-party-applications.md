---
layout: post
title: "Importance of Updating 3rd Party Applications"
date: 2026-05-03
categories: [blog]
---

**Why it is important to update third-party applications**

**With the help of using updated versions, patch potential vulnerabilities fast**

The operating systems installed on our computers and the vulnerabilities of the applications running on those computers could create a security vulnerability at least as serious as external threats and viruses. Software vendors gives us the ability to fix the vulnerability by publishing new versions and patches. It is very important to use up-to-date versions of applications to avoid vulnerabilities that cause from older versions of them. Easy2Patch helps you fix these vulnerabilities by analyzing current versions and new patches of the applications and distributing them in a central manner.

**Google Chrome Remote Code Execution vulnerability**

Firstly, we start with preparing our test environment to see the effects of vulnerability in Google Chrome. We will use Kali machine to exploit the vulnerability and Windows 10 machine as the target.

**Google Chrome version:** v80.0.3987.87

**CVE Code:** CVE-2020-6418

**CVE details link:** [https://nvd.nist.gov/vuln/detail/CVE-2020-6418](https://nvd.nist.gov/vuln/detail/CVE-2020-6418)

**CVE explanation:** These attacks potentially let an attacker to exploit heap corruption vulnerability by using an HTML page. Even though this vulnerability is patched by Google, it still exists in all V8 versions of Google Chrome version 80.0.3987.122 **.**

**Preparation Phase**

- We first configure both Kali and Windows 10 machines such that they will be in the same network.
- We install vulnerable Google Chrome version to our target machine.
- We turn back to Kali machine and start Msfconsole
- We search for the exploit named “chrome\_js”

!

- We will use this exploit to penetrate the system
- We select the exploit by writing “use 0”

!

- By writing “show options”, we fill the required information

    - At this point, first of all, we look for the ip address of my Kali machine

!

- Then we start configuring our exploit

<picture class="relative"><div class="relative overflow-hidden after:block after:absolute after:-inset-0 after:pointer-events-none w-fit mx-auto"><img data-testid="zoom-image" alt="" style="max-width:100%;width:784px;height:153px" loading="lazy" class="block" src="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2Feasy2patch.com%2Fwp-content%2Fuploads%2F2023%2F02%2Fimage-3.png&width=768&dpr=3&quality=100&sign=4495d69&sv=2"></div><figcaption class="text-xs text-center text-tint mt-2">Here, I give the ip address of my Kali machine</figcaption></picture>

- By typing “info” we can see under which operating systems this exploit can be used

!

- Lastly, by selecting the target, we start the attack

<picture class="relative"><div class="relative overflow-hidden after:block after:absolute after:-inset-0 after:pointer-events-none w-fit mx-auto"><img data-testid="zoom-image" alt="" style="max-width:100%;width:620px;height:194px" loading="lazy" class="block" src="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2Feasy2patch.com%2Fwp-content%2Fuploads%2F2023%2F02%2Fimage-5.png&width=768&dpr=3&quality=100&sign=6f61e153&sv=2"></div><figcaption class="text-xs text-center text-tint mt-2">We start waiting on the Kali side. If the target visits the given url, we can get a meterpreter session.</figcaption></picture>

- 
- Now, we enter the given url above in our Google Chrome on Windows 10 machine
- After that, when we look at Kali machine, we will that we got a session successfully

!

- At this point, we can see that we successfully penetrated the Windows 10 machine

<picture class="relative"><div class="relative overflow-hidden after:block after:absolute after:-inset-0 after:pointer-events-none w-fit mx-auto"><img data-testid="zoom-image" alt="" style="max-width:100%;width:637px;height:257px" loading="lazy" class="block" src="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2Feasy2patch.com%2Fwp-content%2Fuploads%2F2023%2F02%2Fimage-7.png&width=768&dpr=3&quality=100&sign=25d30745&sv=2"></div><figcaption class="text-xs text-center text-tint mt-2">As can be seen from that, hackers can not only steal information from browser but also hack the system by using this vulnerability.</figcaption></picture>

* * *

**Result**

You can protect your machines by automating third party application update process with the help of Easy2Patch. Along with it, also, you can make update process easy and make your systems more secure by updating your applications for which we provide a detailed update catalogue.

[PreviousCVE-2023-2033 Google Chrome Zero-Day Vulnerability](/articles/cve-2023-2033-google-chrome-zero-day-vulnerability)[NextLocal Publishing Maximum Cab Size Setting](/articles/local-publishing-maximum-cab-size-setting)
Last updated <time data-visual-test="transparent" datetime="2023-05-07T18:21:49.000Z" data-state="closed">2 years ago</time>
