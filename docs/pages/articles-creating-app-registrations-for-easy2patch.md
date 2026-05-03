---
layout: post
title: "Creating App Registrations for Easy2Patch"
date: 2026-05-03
categories: [blog]
---

In this article, where we explain how to give the necessary permissions for the Intune Update and Application Deployment features that come with Easy2Patch 3.0 and the Critical Update Management with Defender features that come with Easy2Patch 3.1, you need to have the appropriate permissions because we will be running AppRegistrations on the Azure Portal.

## 


Creating App Registrations

1.       First, log in to https://portal.azure.com with a user account with appropriate privileges.

2.       Type **App Registrations** in the **Search** field. Click on the **App registrations** link that will appear in the **Services** area.

3.       If you want to use an existing **App registrations**, click it to continue from step [**Authorization**](/articles/creating-app-registrations-for-easy2patch#authorization). If you want to create a new one, continue from step 4.

4.       Click the **New registration** button.

<picture class="relative"><div class="relative overflow-hidden after:block after:absolute after:-inset-0 after:pointer-events-none w-fit mx-auto"><img data-testid="zoom-image" alt="New App registration in Azure Portal" style="max-width:100%;height:auto" loading="eager" class="block" src="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252Fhu8BKEeuJLBSGzs6QpO1%252Fimage.png%3Falt%3Dmedia%26token%3Dc2743896-7781-456a-ab09-eef354f61ba4&width=768&dpr=3&quality=100&sign=bacf85d8&sv=2" srcset="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252Fhu8BKEeuJLBSGzs6QpO1%252Fimage.png%3Falt%3Dmedia%26token%3Dc2743896-7781-456a-ab09-eef354f61ba4&width=400&dpr=1&quality=100&sign=bacf85d8&sv=2 400w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252Fhu8BKEeuJLBSGzs6QpO1%252Fimage.png%3Falt%3Dmedia%26token%3Dc2743896-7781-456a-ab09-eef354f61ba4&width=400&dpr=2&quality=100&sign=bacf85d8&sv=2 800w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252Fhu8BKEeuJLBSGzs6QpO1%252Fimage.png%3Falt%3Dmedia%26token%3Dc2743896-7781-456a-ab09-eef354f61ba4&width=400&dpr=3&quality=100&sign=bacf85d8&sv=2 1200w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252Fhu8BKEeuJLBSGzs6QpO1%252Fimage.png%3Falt%3Dmedia%26token%3Dc2743896-7781-456a-ab09-eef354f61ba4&width=768&dpr=1&quality=100&sign=bacf85d8&sv=2 768w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252Fhu8BKEeuJLBSGzs6QpO1%252Fimage.png%3Falt%3Dmedia%26token%3Dc2743896-7781-456a-ab09-eef354f61ba4&width=768&dpr=2&quality=100&sign=bacf85d8&sv=2 1536w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252Fhu8BKEeuJLBSGzs6QpO1%252Fimage.png%3Falt%3Dmedia%26token%3Dc2743896-7781-456a-ab09-eef354f61ba4&width=768&dpr=3&quality=100&sign=bacf85d8&sv=2 2304w" sizes="(max-width: 640px) 400px, 768px" width="750" height="378"></div><figcaption class="text-xs text-center text-tint mt-2">New registration</figcaption></picture>

5.       After entering a suitable name in the **Name** field, select the organization level, if any, and press the **Register** button. The default settings are as follows.

<picture class="relative"><div class="relative overflow-hidden after:block after:absolute after:-inset-0 after:pointer-events-none w-fit mx-auto"><img data-testid="zoom-image" alt="App registration Information" style="max-width:100%;height:auto" loading="lazy" class="block" src="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252F2LqCUsbhi4cXyPeQqYoj%252Fimage.png%3Falt%3Dmedia%26token%3D39736bd6-fef9-4f9b-a6e9-cf9968a547d3&width=768&dpr=3&quality=100&sign=d920b511&sv=2" srcset="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252F2LqCUsbhi4cXyPeQqYoj%252Fimage.png%3Falt%3Dmedia%26token%3D39736bd6-fef9-4f9b-a6e9-cf9968a547d3&width=400&dpr=1&quality=100&sign=d920b511&sv=2 400w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252F2LqCUsbhi4cXyPeQqYoj%252Fimage.png%3Falt%3Dmedia%26token%3D39736bd6-fef9-4f9b-a6e9-cf9968a547d3&width=400&dpr=2&quality=100&sign=d920b511&sv=2 800w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252F2LqCUsbhi4cXyPeQqYoj%252Fimage.png%3Falt%3Dmedia%26token%3D39736bd6-fef9-4f9b-a6e9-cf9968a547d3&width=400&dpr=3&quality=100&sign=d920b511&sv=2 1200w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252F2LqCUsbhi4cXyPeQqYoj%252Fimage.png%3Falt%3Dmedia%26token%3D39736bd6-fef9-4f9b-a6e9-cf9968a547d3&width=768&dpr=1&quality=100&sign=d920b511&sv=2 768w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252F2LqCUsbhi4cXyPeQqYoj%252Fimage.png%3Falt%3Dmedia%26token%3D39736bd6-fef9-4f9b-a6e9-cf9968a547d3&width=768&dpr=2&quality=100&sign=d920b511&sv=2 1536w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252F2LqCUsbhi4cXyPeQqYoj%252Fimage.png%3Falt%3Dmedia%26token%3D39736bd6-fef9-4f9b-a6e9-cf9968a547d3&width=768&dpr=3&quality=100&sign=d920b511&sv=2 2304w" sizes="(max-width: 640px) 400px, 768px" width="750" height="517"></div><figcaption class="text-xs text-center text-tint mt-2">App registration Information</figcaption></picture>

## 


Creating Credential Information

It is information to be used through the App registration API. Applications will use this record to perform authorized transactions without a user account. The login mechanism of the application will be with the credential information to be created for App registration. The following steps are applied to add a Credential.

1.       Make a note of the **Application (client) ID** and **Directory (tenant) ID** information. Then click on the **Add a certificate or secret** link.

<picture class="relative"><div class="relative overflow-hidden after:block after:absolute after:-inset-0 after:pointer-events-none w-fit mx-auto"><img data-testid="zoom-image" alt="App Registration credential information in Azure  Portal" style="max-width:100%;height:auto" loading="lazy" class="block" src="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FH7uT6OuLEKUHgpCWES9W%252Fimage.png%3Falt%3Dmedia%26token%3D0087ab8b-ef31-451f-af46-2f49820a8a2c&width=768&dpr=3&quality=100&sign=a357f5ca&sv=2" srcset="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FH7uT6OuLEKUHgpCWES9W%252Fimage.png%3Falt%3Dmedia%26token%3D0087ab8b-ef31-451f-af46-2f49820a8a2c&width=400&dpr=1&quality=100&sign=a357f5ca&sv=2 400w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FH7uT6OuLEKUHgpCWES9W%252Fimage.png%3Falt%3Dmedia%26token%3D0087ab8b-ef31-451f-af46-2f49820a8a2c&width=400&dpr=2&quality=100&sign=a357f5ca&sv=2 800w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FH7uT6OuLEKUHgpCWES9W%252Fimage.png%3Falt%3Dmedia%26token%3D0087ab8b-ef31-451f-af46-2f49820a8a2c&width=400&dpr=3&quality=100&sign=a357f5ca&sv=2 1200w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FH7uT6OuLEKUHgpCWES9W%252Fimage.png%3Falt%3Dmedia%26token%3D0087ab8b-ef31-451f-af46-2f49820a8a2c&width=768&dpr=1&quality=100&sign=a357f5ca&sv=2 768w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FH7uT6OuLEKUHgpCWES9W%252Fimage.png%3Falt%3Dmedia%26token%3D0087ab8b-ef31-451f-af46-2f49820a8a2c&width=768&dpr=2&quality=100&sign=a357f5ca&sv=2 1536w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FH7uT6OuLEKUHgpCWES9W%252Fimage.png%3Falt%3Dmedia%26token%3D0087ab8b-ef31-451f-af46-2f49820a8a2c&width=768&dpr=3&quality=100&sign=a357f5ca&sv=2 2304w" sizes="(max-width: 640px) 400px, 768px" width="750" height="206"></div><figcaption class="text-xs text-center text-tint mt-2">Credential Information</figcaption></picture>

2.       Click **New client secret**,

<picture class="relative"><div class="relative overflow-hidden after:block after:absolute after:-inset-0 after:pointer-events-none w-fit mx-auto"><img data-testid="zoom-image" alt="App registration secret key creation" style="max-width:100%;height:auto" loading="lazy" class="block" src="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FU4EinaPu6avB58B5zyo3%252Fimage.png%3Falt%3Dmedia%26token%3D598d9d12-9464-4aab-a049-f8e3023ecbae&width=768&dpr=3&quality=100&sign=419a0303&sv=2" srcset="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FU4EinaPu6avB58B5zyo3%252Fimage.png%3Falt%3Dmedia%26token%3D598d9d12-9464-4aab-a049-f8e3023ecbae&width=400&dpr=1&quality=100&sign=419a0303&sv=2 400w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FU4EinaPu6avB58B5zyo3%252Fimage.png%3Falt%3Dmedia%26token%3D598d9d12-9464-4aab-a049-f8e3023ecbae&width=400&dpr=2&quality=100&sign=419a0303&sv=2 800w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FU4EinaPu6avB58B5zyo3%252Fimage.png%3Falt%3Dmedia%26token%3D598d9d12-9464-4aab-a049-f8e3023ecbae&width=400&dpr=3&quality=100&sign=419a0303&sv=2 1200w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FU4EinaPu6avB58B5zyo3%252Fimage.png%3Falt%3Dmedia%26token%3D598d9d12-9464-4aab-a049-f8e3023ecbae&width=768&dpr=1&quality=100&sign=419a0303&sv=2 768w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FU4EinaPu6avB58B5zyo3%252Fimage.png%3Falt%3Dmedia%26token%3D598d9d12-9464-4aab-a049-f8e3023ecbae&width=768&dpr=2&quality=100&sign=419a0303&sv=2 1536w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FU4EinaPu6avB58B5zyo3%252Fimage.png%3Falt%3Dmedia%26token%3D598d9d12-9464-4aab-a049-f8e3023ecbae&width=768&dpr=3&quality=100&sign=419a0303&sv=2 2304w" sizes="(max-width: 640px) 400px, 768px" width="750" height="157"></div><figcaption class="text-xs text-center text-tint mt-2">Secret</figcaption></picture>

3.       Specify the duration with the optional description field from the pane that will open on the right. For security reasons, App registration secret information is created temporarily. After selecting a suitable time, press the **Add** button.

<picture class="relative"><div class="relative overflow-hidden after:block after:absolute after:-inset-0 after:pointer-events-none w-fit mx-auto"><img data-testid="zoom-image" alt="Secret Key Properties" style="max-width:100%;height:auto" loading="lazy" class="block" src="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FI9bEk4CJqGhvlS9OuBB7%252Fimage.png%3Falt%3Dmedia%26token%3D8d564faa-546e-4f4e-ba63-fde3521de2df&width=768&dpr=3&quality=100&sign=f78aa041&sv=2" srcset="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FI9bEk4CJqGhvlS9OuBB7%252Fimage.png%3Falt%3Dmedia%26token%3D8d564faa-546e-4f4e-ba63-fde3521de2df&width=400&dpr=1&quality=100&sign=f78aa041&sv=2 400w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FI9bEk4CJqGhvlS9OuBB7%252Fimage.png%3Falt%3Dmedia%26token%3D8d564faa-546e-4f4e-ba63-fde3521de2df&width=400&dpr=2&quality=100&sign=f78aa041&sv=2 800w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FI9bEk4CJqGhvlS9OuBB7%252Fimage.png%3Falt%3Dmedia%26token%3D8d564faa-546e-4f4e-ba63-fde3521de2df&width=400&dpr=3&quality=100&sign=f78aa041&sv=2 1200w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FI9bEk4CJqGhvlS9OuBB7%252Fimage.png%3Falt%3Dmedia%26token%3D8d564faa-546e-4f4e-ba63-fde3521de2df&width=768&dpr=1&quality=100&sign=f78aa041&sv=2 768w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FI9bEk4CJqGhvlS9OuBB7%252Fimage.png%3Falt%3Dmedia%26token%3D8d564faa-546e-4f4e-ba63-fde3521de2df&width=768&dpr=2&quality=100&sign=f78aa041&sv=2 1536w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FI9bEk4CJqGhvlS9OuBB7%252Fimage.png%3Falt%3Dmedia%26token%3D8d564faa-546e-4f4e-ba63-fde3521de2df&width=768&dpr=3&quality=100&sign=f78aa041&sv=2 2304w" sizes="(max-width: 640px) 400px, 768px" width="750" height="553"></div><figcaption class="text-xs text-center text-tint mt-2">Secret Key Properties</figcaption></picture>

4.       When the secret is created, it is written to the screen as clear text for once. It is not possible for you to learn this text again. Therefore, the Secret value printed on the screen after this process must be noted. It can be copied with the clipboard button next to it.

<picture class="relative"><div class="relative overflow-hidden after:block after:absolute after:-inset-0 after:pointer-events-none w-fit mx-auto"><img data-testid="zoom-image" alt="Secret Key Information" style="max-width:100%;height:auto" loading="lazy" class="block" src="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FMceb69qZ2NGunUojy55s%252Fimage.png%3Falt%3Dmedia%26token%3D44235272-d56c-4cde-94be-4646a80c0d6d&width=768&dpr=3&quality=100&sign=7be9dda8&sv=2" srcset="https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FMceb69qZ2NGunUojy55s%252Fimage.png%3Falt%3Dmedia%26token%3D44235272-d56c-4cde-94be-4646a80c0d6d&width=400&dpr=1&quality=100&sign=7be9dda8&sv=2 400w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FMceb69qZ2NGunUojy55s%252Fimage.png%3Falt%3Dmedia%26token%3D44235272-d56c-4cde-94be-4646a80c0d6d&width=400&dpr=2&quality=100&sign=7be9dda8&sv=2 800w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FMceb69qZ2NGunUojy55s%252Fimage.png%3Falt%3Dmedia%26token%3D44235272-d56c-4cde-94be-4646a80c0d6d&width=400&dpr=3&quality=100&sign=7be9dda8&sv=2 1200w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FMceb69qZ2NGunUojy55s%252Fimage.png%3Falt%3Dmedia%26token%3D44235272-d56c-4cde-94be-4646a80c0d6d&width=768&dpr=1&quality=100&sign=7be9dda8&sv=2 768w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FMceb69qZ2NGunUojy55s%252Fimage.png%3Falt%3Dmedia%26token%3D44235272-d56c-4cde-94be-4646a80c0d6d&width=768&dpr=2&quality=100&sign=7be9dda8&sv=2 1536w, https://easy2patch.com/~gitbook/image?url=https%3A%2F%2F48322287-files.gitbook.io%2F%7E%2Ffiles%2Fv0%2Fb%2Fgitbook-x-prod.appspot.com%2Fo%2Fspaces%252FcdUOS05wepzb10XGcGgw%252Fuploads%252FMceb69qZ2NGunUojy55s%252Fimage.png%3Falt%3Dmedia%26token%3D44235272-d56c-4cde-94be-4646a80c0d6d&width=768&dpr=3&quality=100&sign=7be9dda8&sv=2 2304w" sizes="(max-width: 640px) 400px, 768px" width="750" height="154"></div><figcaption class="text-xs text-center text-tint mt-2">Secret Key Information</figcaption></picture>

## 


Authorization

Permissions are granted in 2 stages. 1st group permission is **Microsoft Graph**, 2nd group permission is **WindowsDefenderATP** permissions.

### 


Microsoft Graph

1.       Find and click the newly created registration from the list on the **App registrations** screen,

2.       Click on **API permissions** on the screen that comes up,

3.       Click **+ Add permission** button,

4.       Click the **Microsoft Graph** button,

5.       Click the **Application permissions** button,

6.       The permissions in the table below are selected, 

Category

Permission

ApplicationApplication.Read.All

ApplicationApplication.ReadWrite.All

DeviceManagementAppsDeviceManagementApps.ReadWrite.All

DeviceManagementConfigurationDeviceManagementConfiguration.Read.All

DeviceManagementManagedDevicesDeviceManagementManagedDevices.Read.All

DeviceManagementRBACDeviceManagementRBAC.Read.All

DeviceManagementServiceConfigDeviceManagementServiceConfig.Read.All

GroupGroup.Read.All

GroupMemberGroupMember.Read.All

UserUser.Read.All

7.       After the adding process is finished, click the **Grant admin consent for <Organization>** button. Click **Yes** on the confirmation screen.

### 


WindowsDefenderATP

1.       Click **+ Add permission** button,

2.       Switch to **APIs my organization** uses tab,

3.       Type **WindowsDefenderATP** in the Search field and click on **WindowsDefenderATP** from the list,

4.       Click the **Application permissions** button,

5.       Select the permissions in the table below and click the **Add permissions** button.

Category

Permission

AlertAlert.Read.All

IpIp.Read.All

MachineMachine.Read.All

MachineMachine.Scan

RemediationTasksRemediationTasks.Read.All

ScoreScore.Read.All

SecurityBaselinesAssessmentSecurityBaselinesAssessment.Read.All

SecurityConfigurationSecurityConfiguration.Read.All

SecurityRecommendationSecurityRecommendation.Read.All

SoftwareSoftware.Read.All

UserUser.Read.All

VulnerabilityVulnerability.Read.All

 6.       After the adding process is finished, click the **Grant admin consent for <Organization>** button. Click Yes on the confirmation screen.

After app registration creation and authorization processes are completed, **Application (client) ID** and **Directory (tenant) ID** and **Secret** information can be entered on the Easy2Patch Intune settings screen, and the use of the application can be started.

[PreviousMost effective way to up to date 3rd party software in IT environment](/articles/most-effective-way-to-up-to-date-3rd-party-software-in-it-environment)[NextHow to Save Time and Labor via Easy2Patch?](/articles/how-to-save-time-and-labor-via-easy2patch)
Last updated <time data-visual-test="transparent" datetime="2023-06-26T18:07:58.000Z" data-state="closed">2 years ago</time>
