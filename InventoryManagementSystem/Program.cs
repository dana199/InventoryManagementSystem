// See https://aka.ms/new-console-template for more information
using InventoryManagementSystem.Domain;

Inventory inventory = new Inventory();
Console.WriteLine("Welcome to the Product Inventory Management System");
while (true)
{
    var options =
        @"
         1. Add a product
         2. View All Products
         3. Edit a product 
         4. Delete a product
         5. Search For a product
         6. Exit the application
         7. Please enter your choice:";
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
            inventory.SearchProduct();
            break;
        case "6":
            System.Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}