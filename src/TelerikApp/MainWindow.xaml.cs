using System.Windows;
using TelerikApp.Views;

namespace TelerikApp
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

        private void ShowCalendar(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new CalendarView();
        }

        private void ShowRating(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new RatingView();
        }
        
        private void ShowGrid(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new GridDemoView();
        }
        
        private void ShowBook(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new BookView();
        }
    }
}