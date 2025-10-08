using System;
using System.IO;
using System.Windows;
using Avalonia.Xpf.Controls;
using AvaloniaUI.Xpf.WpfAbstractions.Printing;
using PdfPreviewSample.ViewModels;

namespace PdfPreviewSample
{
    public partial class MainWindow : Window
    {
        private ShoppingListViewModel _shoppingList = new ShoppingListViewModel();
        private readonly string _pdfFilePath = "generated_preview.pdf";

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _shoppingList;
        }
        
        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameInput.Text)) return;
            if (!int.TryParse(QtyInput.Text, out int qty)) qty = 1;
            if (!double.TryParse(PriceInput.Text, out double price)) price = 0;

            _shoppingList.AddProduct(NameInput.Text, qty, price);

            NameInput.Text = "";
            QtyInput.Text = "1";
            PriceInput.Text = "0.00";
        }
        
        private void GenerateAndPreviewPdfButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using var stream = File.Create(_pdfFilePath);
                using var writer = PrintableDocumentWriter.Create(stream);
                writer.AddPage(PrintableArea);
                
                var fullPath = Path.GetFullPath(_pdfFilePath);
                var fileUri = new Uri(fullPath);
                var dialog = new NativeWebDialog
                {
                    Title = "PDF Preview",
                    CanUserResize = true,
                    Source = fileUri
                };

                dialog.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating or previewing PDF:\n" + ex.Message, "Error");
            }
        }
    }
}