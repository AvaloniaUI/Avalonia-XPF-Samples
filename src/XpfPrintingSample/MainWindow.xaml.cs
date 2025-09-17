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
        private string savedPdfPath = "print_demo_output.pdf";

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
            using var stream = File.Create(savedPdfPath);
            using var writer = PrintableDocumentWriter.Create(stream);
            writer.AddPage(PrintableArea);
            MessageBox.Show("PDF exported to: " + savedPdfPath, "Success");
        }
        

        private async void PrintNowButton_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(savedPdfPath))
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
                    .Select(_ => wrapper.Print(new PrintingOptions(printerName, savedPdfPath)));

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