using System.Windows;
using ActiproSoftware.Products;

namespace ActiproApp;

public partial class App : Application
{
    public App()
    {
        AvaloniaUI.Xpf.WinApiShim.WinApiShimSetup.AutoEnable();
        
        // Add your Actipro license keys
        string license = "%ActiproLicense%";
        string licenseKey = "%ActiproLicenseKey%";
        ActiproLicenseManager.RegisterLicense(license, licenseKey);
    }
}