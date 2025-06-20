using System.Windows.Controls;
using System.Windows;

namespace SyncfusionApp.Views {
    public partial class ToggleSwitchView : UserControl {
        public ToggleSwitchView() {
            InitializeComponent();
        }

        private void ButtonAdv_Click(object sender, RoutedEventArgs e)
        {
            if (toggleButton.IsChecked == true)
            {
                // Checked
                toggleButton.Label = "Turned On";
            }
            else
            {
                // Unchecked
                toggleButton.Label = "Turned Off";
            }
        }
    }
}