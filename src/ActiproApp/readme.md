![banner](/assets/banner.png)

## Actipro XPF Controls Demo
This example demonstrates how to integrate and utilize Actipro UI components within XPF.
Features Demonstrated:

✅ Barcode

✅ DataGrid

✅ MicroChart

✅ TimePicker

✅ ToggleSwitch

![Actipro Screenshot](/assets/actipro-app.png)

You can find a list of all supported Actipro controls here [`Here`](https://avaloniaui.net/xpf/packages/actipro).

## Getting started

### XPF Licensing
This project includes the XPF NuGet feed, which is configured in [`NuGet.Config`](./NuGet.config). The XPF package source and csproj utilize an environment variable (%XpfLicenseKey%) for authentication.
- Set your XPF license key as the `XpfLicenseKey` environment variable before restoring dependencies.
- Alternatively, add your XPF license key directly in [`NuGet.Config`](./NuGet.config) and [`ActiproApp.csproj`](./ActiproApp.csproj)

### Actipro Licensing
This app requires Actipro license keys to be provided in [`App.xaml.cs`](./App.xaml.cs)