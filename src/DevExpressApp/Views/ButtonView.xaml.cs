using DevExpress.Mvvm;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace DevExpressApp.Views
{
    public partial class ButtonView : UserControl
    {
        public ButtonView()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}