using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ActiproApp.Views;

namespace ActiproApp
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
            BtnShowMicroChart.IsChecked = false;
            BtnTimePicker.IsChecked = false;
            BtnToggleSwitch.IsChecked = false;
            BtnGridDemo.IsChecked = false;
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
        private void ShowGrid(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnGridDemo.IsChecked = true;
            MainContent.Content = new GridDemoView();
        }
        private void ShowMicroChart(object sender, RoutedEventArgs e)
        {
            ResetButtons();
            BtnShowMicroChart.IsChecked = true;
            MainContent.Content = new MicroChartView();
        }


    }
}
