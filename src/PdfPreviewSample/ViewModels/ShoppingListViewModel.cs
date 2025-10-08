using System.Collections.ObjectModel;
using PdfPreviewSample.Models;

namespace PdfPreviewSample.ViewModels;

public class ShoppingListViewModel
{
    public ObservableCollection<Product> Products { get; } = new();

    public ShoppingListViewModel()
    {
        Products.Add(new Product { Name = "Apples", Quantity = 3, Price = 1.50 });
        Products.Add(new Product { Name = "Bread", Quantity = 1, Price = 2.20 });
        Products.Add(new Product { Name = "Green Tea", Quantity = 2, Price = 9.00 });
    }

    public void AddProduct(string name, int qty, double price)
    {
        Products.Add(new Product { Name = name, Quantity = qty, Price = price });
    }
}