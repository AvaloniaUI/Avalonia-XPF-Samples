using System.Windows;
using System.Windows.Controls;

namespace HybridXPF.Views;

public partial class WpfContent : UserControl
{
    public WpfContent()
    {
        InitializeComponent();
    }

    protected override Size MeasureOverride(Size constraint)
    {
        return base.MeasureOverride(constraint);
    }
}

