using System;
using Avalonia;
using AvaloniaUI.Xpf;

namespace MenuTrayIconSample
{
    /// <summary>
    /// The XPF version of the App object in WPF.
    /// </summary>
    public class Program 
    {
        [STAThread]
        public static void Main()
        {
            AppBuilder.Configure<AvaloniaApp>()
                .UsePlatformDetect()
                .WithAvaloniaXpf()
                .With(new X11PlatformOptions
                {
                    UseDBusFilePicker = false,
                })
                .SetupWithoutStarting();

            App.Main();
        }
    }
}