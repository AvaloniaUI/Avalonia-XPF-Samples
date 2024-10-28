using Foundation;
using Avalonia;
using Avalonia.iOS;
using AvaloniaUI.Xpf;
using AvaloniaUI.Xpf.Helpers;
using UIKit;

namespace WpfCalculator.Platform;

[Register("AppDelegate")]
public partial class AppDelegate : AvaloniaAppDelegate<DefaultXpfAvaloniaApplication>
{
    // This is the main entry point of the application.
    internal static void Main(string[] args) => UIApplication.Main(args, null, typeof(AppDelegate));

    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithAvaloniaXpf()
            .AfterSetup(_ => App.Start());
    }
}