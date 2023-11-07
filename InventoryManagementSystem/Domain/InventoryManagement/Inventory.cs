using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementSystem.Domain.InventoryManagement;

namespace InventoryManagementSystem.Domain
{
    public class Inventory
    {
        public List<Product> products = new List<Product>();
        public void AddProduct()
        {
            Console.WriteLine("Enter the name of the product:");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the quantity of the product");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Product product = new Product(name, price, quantity);
            products.Add(product);
        }
        public void ViewAllProducts()
        {
            Console.WriteLine("The Products:");
            foreach (var product in products)
            {
                if (product != null)
                {
                    Console.WriteLine($"[ Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}]");
                }
                else
                {
                    Console.WriteLine($"There is No product Added");
                }
            }
        }
        public void EditProduct()
        {
            Console.WriteLine("Enter the name of the product You want To Edit:");
            string? name = Console.ReadLine();
            Product? EditedProduct = products.Find(x => x.Name == name);
            foreach (var product in products)
            {
                if (EditedProduct == null)
                {
                    Console.WriteLine("Product not found in inventory.");
                    return;
                }
                else if (EditedProduct.Name == product.Name)
                {
                    Console.WriteLine("Enter the new Product Name:");
                    string? newName = Console.ReadLine();
                    EditedProduct.Name = newName;

                    Console.WriteLine("Enter the new Product Price:");
                    int newprice = Convert.ToInt32(Console.ReadLine());
                    EditedProduct.Price = newprice;

                    Console.WriteLine("Enter the quantity of the product");
                    int newQuantity = Convert.ToInt32(Console.ReadLine());
                    EditedProduct.Quantity = newQuantity;

                    Console.WriteLine($"Product updated successfully.");
                    Console.WriteLine($"The updated product:");
                    Console.WriteLine($"Name :{EditedProduct.Name}, Price: {EditedProduct.Price}, Quantity: {EditedProduct.Quantity}");
                }
            }
        }
    }
}
