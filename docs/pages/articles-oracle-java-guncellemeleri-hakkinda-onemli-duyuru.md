---
layout: post
title: "Oracle Java Güncellemeleri Hakkında Önemli Duyuru"
date: 2026-05-03
categories: [blog]
---

Son yayınlanan güncellemeler sırasında **Oracle Java** paketinde tespit edilen bir yönlendirme hatası nedeniyle, bazı ortamlarda **beklenmedik davranışlar veya servis kesintileri** yaşanma riski tespit edilmiştir.

Bu durum yalnızca **Oracle Java** paketini ilgilendirmektedir. Diğer uygulamalar etkilenmemiştir.

Easy2Patch olarak katalog içerisindeki tüm yazılımları kontrol ediyoruz. Ancak otomatik ve manuel süreçler bu tarz problemlerin oluşmasına sebep olabilmektedir. Bu nedenle, güncellemelerin canlı ortama geçmeden önce test edilmesi ve onaylanması Easy2Patch tarafından önerilmektedir.

### 


Ne Yapmalısınız?

1. **Tüm Java güncellemelerini geçici olarak durdurun.**
Oracle Java içeren ADR, otomatik dağıtım, veya manuel dağıtım görevlerini geçici süreyle durdurun.
2. **Kataloğu güncelleyin.**
En son ve doğrulanmış kataloğu indirip kullanıma alın. Yeni katalogda Oracle Java paketi **doğru yapılandırmayla** yayınlanmıştır.
3. **Dağıtımdan önce test yapın.**
Özellikle Oracle Java gibi **iş-kritik bileşenleri** canlı sistemlerde uygulamadan önce mutlaka **test ortamında** doğrulayın. Uygulama veya servis bağımlılıklarını kontrol etmeden yapılan dağıtımlar, sistem kararlılığını etkileyebilir.

### 


Neden Önemli?

Oracle Java, birçok uygulamanın **doğrudan çalıştığı runtime bileşenidir**. Yanlış yapılandırılmış bir JRE/JDK güncellemesi uygulamaların açılmaması, servislerin durması gibi risklere neden olabilir. Bu yüzden tüm kullanıcılarımızdan, özellikle **Java tabanlı iş uygulamaları** bulunan sistemlerde, yeni katalogla birlikte test ve dağıtım süreçlerini dikkatle yürütmeleri rica olunur.

### 


Son Durum

- Güncel ve doğrulanmış katalog **yayınlanmıştır.**
- Yeni dağıtımlarda Oracle Java paketi **doğru sürüm ve referanslarla** yer almaktadır.

[PreviousApplications added to the E2P catalog in February (#202302)](/new-products/applications-added-to-the-e2p-catalog-in-february-202302)[NextImportant Notice: Oracle Java JRE Updates](/articles/important-notice-oracle-java-jre-updates)
Last updated <time data-visual-test="transparent" datetime="2025-10-16T14:03:13.269Z" data-state="closed">6 months ago</time>
