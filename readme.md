![banner](/assets/banner.png)

## About
Avalonia XPF is the commercial solution that enables WPF applications to run natively on macOS, Linux, iOS, Android and the Web with minimal code changes. This repository contains sample applications demonstrating how to use Avalonia XPF to extend your WPF applications to additional platforms.

Key features demonstrated in these samples include:

* Running WPF applications on macOS and Linux with little to no code modification
* Platform-specific considerations and best practices
* Integration patterns for common WPF frameworks and libraries
* Migration strategies and compatibility solutions

Avalonia XPF is a commercial product licensed per-app. For more information about licensing and to get started with Avalonia XPF, visit the [Avalonia XPF web page](https://avaloniaui.net/xpf).

## Setting up your environment 

* The samples all use a [centralized management](https://docs.avaloniaui.net/xpf/advanced/centralized-management) of the license key, meaning you can set your license key just once! 
* You will need to have an active trial of Avalonia XPF for these samples to work. 

## Hybrid XPF 
Mix-and-match WPF and Avalonia in a single project. 

This sample demonstrates how you can add WPF controls to your existing Avalonia application. Read the [docs](https://docs.avaloniaui.net/xpf/embedding/xpf-in-avalonia). 

![Screenshot](/assets/hybridxpf.png)

### Important notes

* The Avalonia version must match! As of `1.4.0-cibuild001849` you should use `11.2.999-cibuild0052170-alpha`. 


## Mobile & WebAssembly 
We have iOS, Android and WebAssembly support in preview with select customers. To enable these platforms, we recommend creating a Single Project, which contains Desktop, Mobile and Web versions of your WPF applications. 
The sample app demonstrates this apporach. 

![WASM Screenshot](/assets/wasm-calc.png)


## XPF with 3rd Party Libraries
This repository contains example applications demonstrating how to use XPF with the following third-party UI libraries:
- Actipro , see [`Here`](./src/ActiproApp)
- DevExpress, see [`Here`](./src/DevExpressApp)
- Syncfusion, see [`Here`](./src/SyncfusionApp)

 
## XPF App Menu and Tray Icon example
This example demonstrates how to utilize tray icons with menus and the global application menu bar within XPF.

![Screenshot](/assets/trayicondemo.png)

## 🖨️ PDF Printing Example
This example demonstrates how to generate **print-ready PDF documents** from the selected Window content using Avalonia XPF.


### NuGet Package Configuration
This project includes the DevExpress NuGet feed, which is configured in NuGet.Config. The DevExpress package source URL utilizes an environment variable (%DevExpressKey%) for authentication.
To ensure proper package resolution, set your DevExpress API key as an environment variable before restoring dependencies.