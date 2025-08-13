using System;
using Avalonia.Controls;
using DotNetBrowser.Browser;
using XpfDotNetBrowserApp.ViewModels;

namespace XpfDotNetBrowserApp.Views;

public partial class EmbeddedBrowserView : UserControl
{
    public EmbeddedBrowserView()
    {
        InitializeComponent();
    }
    
    private MainViewModel? MainWindowViewModel
        => DataContext as MainViewModel;

    protected override void OnDataContextChanged(EventArgs e)
    {
        base.OnDataContextChanged(e);
        if (MainWindowViewModel != null)
        {
            BrowserView.InitializeFrom(MainWindowViewModel.Browser);
        }
    }
}
