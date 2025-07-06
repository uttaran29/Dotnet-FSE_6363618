using InventoryApp.Model;
using InventoryApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Service;

public class ProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }
    public async Task ShowAllAsync()
    {
        var products = await _repository.GetAllAsync();
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - {p.Price} - Category: {p.Category.Name}");
        }
    }

    public async Task FindByIdAsync(int id)
    {
        var product = await _repository.GetByIdAsync(id);
        Console.WriteLine(product != null ? $"Found: {product.Name}" : "Product not found.");
    }

    public async Task DeleteProductAsync(string productName)
    {
        var product = await _repository.GetByNameAsync(productName);
        if (product != null)
        {
            await _repository.DeleteAsync(product);
            Console.WriteLine($"Deleted product: {product.Name}");
        }
        else Console.WriteLine("Product not found.");
    }

    public async Task AddProductFromUserInputAsync()
    {
        Console.Write("Enter product name: ");
        var name = Console.ReadLine();

        Console.Write("Enter product price: ");
        if (!decimal.TryParse(Console.ReadLine(), out var price))
        {
            Console.WriteLine("Invalid price.");
            return;
        }

        Console.Write("Enter category name: ");
        var categoryName = Console.ReadLine();

        var category = new Category { Name = categoryName };
        var product = new Product { Name = name, Price = price, Category = category };

        await _repository.AddAsync(product);
        Console.WriteLine("Product added successfully!");
    }
}
