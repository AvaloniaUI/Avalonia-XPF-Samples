using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using SyncfusionApp.Views;

namespace SyncfusionApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowBarCode(null, null); // Default view
        }

        private void ResetButtons()
        {
            BtnBarCode.IsChecked = false;
            BtnTimePicker.IsChecked = false;
            BtnToggleSwitch.IsChecked = false;
            BtnCarousel.IsChecked = false;
            BtnGridDemo.IsChecked = false;
            BtnCalculator.IsChecked = false;
        }

        private void ShowBarCode(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnBarCode.IsChecked = true;
            MainContent.Content = new BarCodeView();
        }

        private void ShowTimePicker(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnTimePicker.IsChecked = true;
            MainContent.Content = new TimePickerView();
        }

        private void ShowToggleSwitch(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnToggleSwitch.IsChecked = true;
            MainContent.Content = new ToggleSwitchView();
        }

        private void ShowCarousel(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnCarousel.IsChecked = true;
            MainContent.Content = new CarouselView();
        }
        private void ShowGrid(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnGridDemo.IsChecked = true;
            MainContent.Content = new GridDemoView();
        }
        private void ShowCalculator(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnCalculator.IsChecked = true;
            MainContent.Content = new CalculatorView();
        }


    }
}
