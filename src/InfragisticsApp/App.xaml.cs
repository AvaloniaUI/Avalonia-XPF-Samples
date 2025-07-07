using System;
using System.Windows;

namespace InfragisticsApp;

public partial class App : Application
{
    public App()
    {
        AvaloniaUI.Xpf.WinApiShim.WinApiShimSetup.AutoEnable();
    }
}