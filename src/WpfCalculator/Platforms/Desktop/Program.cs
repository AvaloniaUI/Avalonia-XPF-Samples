using System;
using Avalonia;
using AvaloniaUI.Xpf;
using AvaloniaUI.Xpf.Helpers;

namespace WpfCalculator.Platform;

internal class Program
{
    [STAThread]
    public static int Main(string[] args)
    {
        AppBuilder.Configure<DefaultXpfAvaloniaApplication>()
            .UsePlatformDetect()
            .WithAvaloniaXpf()
            .SetupWithClassicDesktopLifetime(
                Environment.GetCommandLineArgs(),
                lifetime => lifetime.ShutdownMode = Avalonia.Controls.ShutdownMode.OnExplicitShutdown);

        return App.Start();
    }
}