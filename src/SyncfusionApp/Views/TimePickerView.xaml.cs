using System.Windows;
using System.Windows.Controls;

namespace SyncfusionApp.Views
{
    public partial class TimePickerView : UserControl
    {
        public TimePickerView()
        {
            InitializeComponent();
        }
        private void TimeValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (OldTimeTextBlock != null && NewTimeTextBlock != null)
            {
                OldTimeTextBlock.Text = "The Old selected time: " + e.OldValue?.ToString();
                NewTimeTextBlock.Text = "The Newly selected time: " + e.NewValue?.ToString();
            }
        }
    }
}