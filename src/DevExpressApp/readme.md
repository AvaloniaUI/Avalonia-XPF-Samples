![banner](/assets/banner.png)

## DevExpress XPF Controls Demo
This example demonstrates how to integrate and utilize DevExpress UI components within XPF.
Features Demonstrated:

✅ Barcode

✅ Buttons

✅ GridControl

✅ TimePicker

✅ ToggleSwitch

✅ Trackbar

![DevExpress Screenshot](/assets/devExpress-app.png)

You can find a list of all supported DevExpress controls here [`Here`](https://avaloniaui.net/xpf/packages/devexpress).

## Getting started

### XPF Licensing
This project includes the XPF NuGet feed, which is configured in [`NuGet.Config`](./NuGet.config). The XPF package source and csproj utilize an environment variable (%XpfLicenseKey%) for authentication.
- Set your XPF license key as the `XpfLicenseKey` environment variable before restoring dependencies.
- Alternatively, add your XPF license key directly in [`NuGet.Config`](./NuGet.config) and [`DevExpressApp.csproj`](./DevExpressApp.csproj)

### DevExpress Licensing
The DevExpress package source URl utilizes an environment variable (%DevExpressKey%). Set your DevExpress license key as enviromental variable `DevExpressKey` or add into URI, see [`NuGet.Config`](./NuGet.config).