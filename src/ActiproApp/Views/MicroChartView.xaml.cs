using System.Collections.Generic;
using System.Windows.Controls;

namespace ActiproApp.Views {
    public partial class MicroChartView : UserControl {
        public List<int> ChartData { get; }

        public MicroChartView() {
            InitializeComponent();
            
            ChartData = new List<int> { 2, 4, 8, 16, 32, 64, 128, 254, 508, 1016 };
            DataContext = this;
        }
    }
}