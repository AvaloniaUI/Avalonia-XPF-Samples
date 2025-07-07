using System;
using System.Windows;

namespace TelerikApp;

public partial class App : Application
{
    public App()
    {
        AvaloniaUI.Xpf.WinApiShim.WinApiShimSetup.AutoEnable();
    }
}