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
To ensure proper package resolution, set your XpfLicenseKey API key as an environment variable before restoring dependencies.

### DevExpress Licensing
The DevExpress package source URl utilizes an environment variable (%DevExpress%). Set your DevExpress license key as enviromental variable DevExpress or add into URI, see [`NuGet.Config`](./NuGet.Config).