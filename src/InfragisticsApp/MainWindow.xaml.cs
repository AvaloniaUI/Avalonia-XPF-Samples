using System.Windows;
using InfragisticsApp.Views;
using GridView = InfragisticsApp.Views.GridView;

namespace InfragisticsApp
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

        private void ShowCarousel(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CarouselView();
        }

        private void ShowSlider(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SliderView();
        }
        
        private void ShowGrid(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new GridView();
        }
        
        private void ShowCalendar(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CalendarView();
        }
    }
}
