// See https://aka.ms/new-console-template for more information
using InventoryManagementSystem.Domain;

Inventory inventory = new Inventory();
Console.WriteLine("Welcome to the Product Inventory Management System");
while (true)
{
    Console.WriteLine("1. Add a product");
    Console.WriteLine("2. View All Products");
    Console.WriteLine("3. Edit a product");
    Console.WriteLine("4. Delete a product");
    Console.WriteLine("5. Search For a product");
    Console.WriteLine("6. Exit the application");
    Console.Write("Please enter your choice: ");
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
            inventory.ExitProgram();
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}