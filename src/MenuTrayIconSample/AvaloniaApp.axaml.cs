using Avalonia.Markup.Xaml;
using Avalonia.Styling;
using MenuTrayIconSample.ViewModels;
using Application = Avalonia.Application;

namespace MenuTrayIconSample;

public class AvaloniaApp : Application
{
    /// <remarks>
    /// The Avalonia version of the <see cref="System.Windows.Application"/> object in WPF.
    /// We need to have two app classes as described in https://xpf-docs.avaloniaui.net/docs/advanced/customizing-init/
    /// Since we also need to access the Avalonia version of the App object to set the TrayIcon and
    /// in the future, themes.
    /// </remarks>
    public AvaloniaApp()
    {
        // Important to set the DataContext before all the XAML stuff in
        // application is loaded so that the TrayIcon sees it.
        DataContext = AppViewModel.Instance;

        RequestedThemeVariant = ThemeVariant.Light;
        AvaloniaXamlLoader.Load(this);
    }
}