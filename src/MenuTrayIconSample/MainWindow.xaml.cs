using System.Windows;
using Avalonia.Controls;
using AvaloniaUI.Xpf.WpfAbstractions;
using MenuTrayIconSample.Commands;
using MenuTrayIconSample.ViewModels;
using Window = System.Windows.Window;

namespace MenuTrayIconSample
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CalculatorViewModel();
            
            AppViewModel.Instance.SampleDialogCommand = new RelayCommand(OpenSampleDialog);
            AppViewModel.Instance.AppExitCommand = new RelayCommand(Close);

            Loaded += OnLoaded;
        }
        
        private NativeMenu _windowNativeMenu;

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            if (XpfWpfAbstraction.GetAvaloniaWindowForWindow(this) is { } avWin)
            { 
                _windowNativeMenu = new NativeMenu()
                {
                    Items =
                    {
                        new NativeMenuItem("File")
                        {
                            Menu = new NativeMenu()
                            {
                                Items =
                                {
                                    new NativeMenuItem("Sample Item 1"),
                                    new NativeMenuItemSeparator(),
                                    new NativeMenuItem("Sample Item 2"),
                                }
                            }
                        }, 
                        new NativeMenuItem("Options")
                        {
                            Menu = new NativeMenu()
                            {
                                Items =
                                {
                                    new NativeMenuItem("Sample Item 3"),
                                    new NativeMenuItemSeparator(),
                                    new NativeMenuItem("Sample Item 4"),
                                }
                            }
                        }, 
                    }
                };

                NativeMenu.SetMenu(avWin, _windowNativeMenu);
            }
        }

        private void OpenSampleDialog()
        {
            MessageBox.Show("Opened from the TrayIcon using ICommand!", "Just a sample dialog!");
        }
    }
}