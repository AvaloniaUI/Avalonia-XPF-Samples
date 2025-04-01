using System.IO;
using System.Windows;
using AvaloniaUI.Xpf.WpfAbstractions.Printing;

namespace XpfPrintingSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintToPdf();
        }

        private void PrintToPdf()
        {
            string filePath = "print_demo_output.pdf";

            using var stream = File.Create(filePath);
            using var writer = PrintableDocumentWriter.Create(stream);

            void Print(FrameworkElement el)
            {
                if (!double.IsNaN(el.Width) && !double.IsNaN(el.Height))
                {
                    el.Measure(new Size(el.Width, el.Height));
                    el.Arrange(new Rect(new Point(0, 0), el.DesiredSize));
                }

                writer.AddPage(el);
            }
            
            Print(PrintableArea);

            MessageBox.Show("PDF exported to: " + filePath, "Success");
        }



    }
}
