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
        private void ShowGrid(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new GridDemoView();
        }
        private void ShowMicroChart(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new MicroChartView();
        }


    }
}
