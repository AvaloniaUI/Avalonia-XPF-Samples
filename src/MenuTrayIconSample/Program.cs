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
                .SetupWithoutStarting();

            App.Main();
        }
    }
}