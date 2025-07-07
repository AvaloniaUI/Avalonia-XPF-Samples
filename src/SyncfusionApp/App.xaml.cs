using System.Windows;
using Syncfusion.Licensing;

namespace SyncfusionApp;

public partial class App : Application
{
    public App()
    {
        AvaloniaUI.Xpf.WinApiShim.WinApiShimSetup.AutoEnable();
        
        // Add your Syncfusion license key
        SyncfusionLicenseProvider.RegisterLicense("%SyncfusionKey%");
    }
}