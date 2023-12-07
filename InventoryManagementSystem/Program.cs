// See https://aka.ms/new-console-template for more information
using InventoryManagementSystem.Domain;
using InventoryManagementSystem.Domain.Reader;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;

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
            Product productToAdd = cr.ReadProduct();
            inventory.AddProduct(productToAdd);
            break;
        case "2":
            var Allproducts = inventory.GetAllProducts();
            cr.PrintAllProducts(Allproducts);
            break;
        case "3":
            string? ProductNameToEdit = cr.ReadString("Enter the name of the product You want To Edit:");
            inventory.EditProduct(ProductNameToEdit);
            break;
        case "4":
            string? ProductNameToDelete = cr.ReadString("Enter the name of the product You want To Delete:");
            inventory.DeleteProduct(ProductNameToDelete);
            break;
        case "5":
            string? ProductNameToSearch = cr.ReadString("Enter the name of the product you want to search for: ");
            Product? ProductToSearch = inventory.SearchProduct(ProductNameToSearch);
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