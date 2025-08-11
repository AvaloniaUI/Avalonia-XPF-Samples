using System;
using System.Windows;
using Avalonia;
using XpfDotNetBrowserApp.Commands;
using XpfDotNetBrowserApp.ViewModels;

namespace XpfDotNetBrowserApp
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel = new MainViewModel();
            
            DataContext = MainViewModel;
            if (BrowserHost.Content is StyledElement content)
                content.DataContext = MainViewModel;
        }
 
        private MainViewModel MainViewModel { get; }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            MainViewModel.DisposeBrowser();
        }
    }
}