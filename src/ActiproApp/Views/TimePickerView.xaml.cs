using System.Windows.Controls;
using ActiproApp.ViewModels;

namespace ActiproApp.Views
{
    public partial class TimePickerView : UserControl
    {
        public TimePickerView()
        {
            InitializeComponent();
            this.DataContext = new TimePickerViewModel();
        }
    }
}