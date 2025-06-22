using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_2
{

    public class Product
    {
        public int ProductId {
            get;
            set;
        }
        public string ProductName { 
            get;
            set; 
        }
        public string Category { 
            get; 
            set;
        }

        public Product(int productId, string productName, string category)
        {
            ProductId = productId;
            ProductName = productName;
            Category = category;
        }

        public override string ToString()
        {
            return $"ID: {ProductId}, Name: {ProductName}, Category: {Category}";
        }
    }
    internal class Program
    {
        static Product LinearSearch(List<Product> products, string productName)
        {
            foreach (var product in products)
            {
                if (product.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        static Product BinarySearch(List<Product> sortedProducts, string productName)
        {
            int left = 0;
            int right = sortedProducts.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int compare = string.Compare(sortedProducts[mid].ProductName, productName, StringComparison.OrdinalIgnoreCase);

                if (compare == 0)
                    return sortedProducts[mid];
                else if (compare < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product(101, "Laptop", "Electronics"),
                new Product(102, "Shampoo", "Personal Care"),
                new Product(103, "Desk", "Furniture"),
                new Product(104, "Keyboard", "Electronics"),
                new Product(105, "Chair", "Furniture"),
                new Product(106, "Mouse", "Electronics"),
                new Product(107, "LED", "Electronics"),
                new Product(108, "Sofa", "Furniture"),
                new Product(109, "Phone", "Electronics"),
                new Product(110, "Fragnence", "Personal Care"),
            };

            Console.WriteLine("Enter the product name to search in list by linear search --> ");
            String prod1 = Console.ReadLine();

            Console.WriteLine("\n*****Linear Search*****\n");
            var result1 = LinearSearch(products, prod1);

            if(result1 != null)
            {
                Console.WriteLine(result1);
            }
            else
            {
                Console.WriteLine("Product not found !!!");
            }

            Console.WriteLine("\n*****Binary Search*****\n");
            Console.WriteLine("Enter the product name to search in list by binary search --> ");
            String prod2 = Console.ReadLine();

            var sortedProducts = products.OrderBy(p => p.ProductName).ToList();
            var result2 = BinarySearch(sortedProducts, prod2);

            if (result2 != null)
            {
                Console.WriteLine(result2);
            }
            else { 
                Console.WriteLine("Product not found !!!");
            }
        }
    }
}
