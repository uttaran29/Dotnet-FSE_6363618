using InventoryApp.Data;
using InventoryApp.Repository;
using InventoryApp.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EfInventoryDb;Trusted_Connection=True;TrustServerCertificate=True;"));

services.AddScoped<IProductRepository, ProductRepository>();
services.AddScoped<ProductService>();

var provider = services.BuildServiceProvider();
var productService = provider.GetRequiredService<ProductService>();

while (true)
{
    Console.WriteLine("\n***** Product Management *****");
    Console.WriteLine("1. Add Product.");
    Console.WriteLine("2. Show All Products.");
    Console.WriteLine("3. Delete a product by name.");
    Console.WriteLine("4. Find a product by ID.");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");
    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            await productService.AddProductFromUserInputAsync();
            break;

        case "2":
            await productService.ShowAllAsync();
            break;
        case "3":
            Console.WriteLine("Enter product name: ");
            var temp = Console.ReadLine();
            await productService.DeleteProductAsync(temp);
            break;
        case "4":
            Console.Write("Enter product ID: ");
            var idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int productId))
                await productService.FindByIdAsync(productId);
            else
                Console.WriteLine("Invalid ID format. Please enter a number.");
            break;
        case "5":
            return;

        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
}

