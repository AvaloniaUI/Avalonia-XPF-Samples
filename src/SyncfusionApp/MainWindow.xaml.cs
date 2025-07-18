using System.Windows;
using SyncfusionApp.Views;

namespace SyncfusionApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BtnBarCode.IsChecked = true;
            ShowBarCode(null, null); // Default view
        }

        private void ShowBarCode(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new BarCodeView();
        }

        private void ShowTimePicker(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TimePickerView();
        }

        private void ShowToggleSwitch(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ToggleSwitchView();
        }

        private void ShowCarousel(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CarouselView();
        }
        
        private void ShowGrid(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new GridDemoView();
        }
        
        private void ShowCalculator(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CalculatorView();
        }
    }
}
