// See https://aka.ms/new-console-template for more information
using InventoryManagementSystem.Domain;
using InventoryManagementSystem.Domain.Reader;
using System.Reflection;
using System.Reflection.Emit;

IReader cr = new ConsoleReader();
Inventory inventory = new Inventory(cr);

Console.WriteLine("Welcome to the Product Inventory Management System");
var options =
    @"
         1. Add a product
         2. View All Products
         3. Edit a product 
         4. Delete a product
         5. Search For a product
         6. Exit the application
        Please enter your choice:";
while (true)
{
   Console.WriteLine(options);
   string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            inventory.AddProduct();
            break;
        case "2":
            inventory.ViewAllProducts();
            break;
        case "3":
            inventory.EditProduct();
            break;
        case "4":
            inventory.DeleteProduct();
            break;
        case "5":
            Product ? ProductToSearch = inventory.SearchProduct();
            if (ProductToSearch != null)
            {
                Console.WriteLine($"Product Found - Name: {ProductToSearch.Name}, Price: {ProductToSearch.Price}, Quantity: {ProductToSearch.Quantity}");
            }
            else
            {
                Console.WriteLine("Product not found in inventory.");
            }
            break;
        case "6":
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}