![banner](/assets/banner.png)

## Actipro XPF Controls Demo
This example demonstrates how to integrate and utilize Actipro UI components within XPF.
Features Demonstrated:

✅ Barcode

✅ TimePicker

✅ MicroChart

✅ ToggleSwitch

✅ DataGrid

![Actipro Screenshot](/assets/actipro-app.png)

You can find a list of all supported Actipro controls here [`Here`](https://avaloniaui.net/xpf/packages/actipro).

## Getting started

### XPF Licensing
This project includes the XPF NuGet feed, which is configured in [`NuGet.Config`](./NuGet.config). The XPF package source and csproj utilize an environment variable (%XpfLicenseKey%) for authentication.
To ensure proper package resolution, set your XpfLicenseKey API key as an environment variable before restoring dependencies.

### Actipro Licensing
This app requires Actipro license keys to be provided in [`App.xaml.cs`](./App.xaml.cs)