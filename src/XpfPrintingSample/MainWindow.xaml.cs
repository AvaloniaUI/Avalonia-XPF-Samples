using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PDFtoPrinter;
using AvaloniaUI.Xpf.WpfAbstractions.Printing;


namespace XpfPrintingSample
{
    public partial class MainWindow : Window
    {
        private string _generatedPdfPath = "print_demo_output.pdf";

        public MainWindow()
        {
            InitializeComponent();
            _ = LoadPrintersAsync();
        }

        private async Task LoadPrintersAsync()
        {
            try
            {
                var printers = await PrintersQuery.RunAsync();

                if (printers.Any())
                {
                    this.Printer.Text = printers[0].Name;
                }
                else
                {
                    this.Printer.Text = "No printers found";
                }
            }
            catch (Exception ex)
            {
                this.Printer.Text = $"Error: {ex.Message}";
            }
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintToPdf();
        }

        private void PrintToPdf()
        {
            using var stream = File.Create(_generatedPdfPath);
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

            MessageBox.Show("PDF exported to: " + _generatedPdfPath, "Success");
        }

        private async void PrintNowButton_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(_generatedPdfPath))
            {
                MessageBox.Show("No PDF found to print. Please generate it first.");
                return;
            }

            if (!int.TryParse(this.PrintingCount.Text, out int count) || count < 1)
            {
                MessageBox.Show("Invalid print count.");
                return;
            }

            string printerName = this.Printer.Text;
            var wrapper = new PDFtoPrinterPrinter(count);

            try
            {
                var tasks = Enumerable
                    .Range(0, count)
                    .Select(_ => wrapper.Print(new PrintingOptions(printerName, _generatedPdfPath)));

                await Task.WhenAll(tasks);

                MessageBox.Show("Print job completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Print error: {ex.Message}\n");
            }
        }
    }
}
