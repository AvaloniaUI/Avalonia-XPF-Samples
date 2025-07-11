using System.Windows;
using DevExpressApp.Views;

namespace DevExpressApp
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

        private void ShowTrackBar(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new TrackBarView();
        }

        private void ShowGrid(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new GridDemoView();
        }

        private void ShowButton(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ButtonView();
        }
    }
}