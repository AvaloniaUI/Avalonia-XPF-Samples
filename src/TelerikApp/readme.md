![banner](/assets/banner.png)

## Telerik XPF Controls Demo
This example demonstrates how to integrate and utilize Telerik UI components within XPF.
Features Demonstrated:

✅ Barcode

✅ Book

✅ Calendar

✅ Grid View

✅ Rating

✅ Time Picker

![Telerik Screenshot](/assets/telerik-app.png)


You can find a list of all supported Telerik controls here [`Here`](https://avaloniaui.net/xpf/packages/telerik).

## Getting started

### XPF Licensing
This project includes the XPF NuGet feed, which is configured in [`NuGet.Config`](./NuGet.config). The XPF package source and csproj utilize an environment variable (%XpfLicenseKey%) for authentication.
- Set your XPF license key as the `XpfLicenseKey` environment variable before restoring dependencies.
- Alternatively, add your XPF license key directly in [`NuGet.Config`](./NuGet.config) and [`TelerikApp.csproj`](./TelerikApp.csproj)

### Telerik Licensing
This app demo uses a manually installed Telerik license. Documentation on manual license installation can be found
[`Here`](https://docs.telerik.com/devtools/wpf/getting-started/licensing/installing-license-key#manual-license-key-installation).

1) Download telerik-license.txt file from License Keys page in your Telerik account.
2) Copy the content of downloaded file to [`telerik-license.txt`](./telerik-license.txt) or replace this file with the downloaded one.
3) Add Telerik NuGet feed authentication credentials to [`NuGet.Config`](./NuGet.config).