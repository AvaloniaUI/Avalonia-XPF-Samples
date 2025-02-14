using System;
using System.Windows;

namespace DevExpressApp;

public partial class App : Application
{
    public App()
    {
        AvaloniaUI.Xpf.WinApiShim.WinApiShimSetup.AutoEnable();
    }
}