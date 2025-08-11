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

            AppViewModel.Instance.SampleDialogCommand = new RelayCommand(OpenSampleDialog);
            AppViewModel.Instance.AppExitCommand = new RelayCommand(Close);
        }

        private void OpenSampleDialog()
        {
            MessageBox.Show("Opened from the TrayIcon using ICommand!", "Just a sample dialog!");
        }

        private MainViewModel MainViewModel { get; }

        private void MainWindow_OnClosed(object sender, EventArgs e)
        {
            MainViewModel.DisposeBrowser();
        }
    }
}