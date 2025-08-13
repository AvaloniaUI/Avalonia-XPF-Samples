![banner](/assets/banner.png)

## DotNetBrowser XPF Demo
This example demonstrates how to integrate and utilize TeamDev's DotNetBrowser web browser component within XPF together 
with MVVM pattern.

Features Demonstrated:

✅ Web browser embedding

✅ Navigation controls (Back, Forward, Refresh)

✅ URL navigation bar

✅ MVVM pattern implementation

✅ `AvaloniaHost` integration

✅ Browser events handling

![DotNetBrowser Screenshot](/assets/dotnetbrowser-app.png)

You can find more information about DotNetBrowser [`Here`](https://www.teamdev.com/dotnetbrowser).

## Getting started

### XPF Licensing
This project includes the XPF NuGet feed, which is configured in [`NuGet.Config`](../../NuGet.config). The XPF package source and csproj utilize an environment variable (%XpfLicenseKey%) for authentication.
- Set your XPF license key as the `XpfLicenseKey` environment variable before restoring dependencies.
- Alternatively, add your XPF license key directly in [`NuGet.Config`](../../NuGet.config) and [`XpfDotNetBrowserApp.csproj`](./XpfDotNetBrowserApp.csproj)

### DotNetBrowser Licensing
This app requires DotNetBrowser license key to be provided in [`dotnetbrowser.license`](./dotnetbrowser.license) file.