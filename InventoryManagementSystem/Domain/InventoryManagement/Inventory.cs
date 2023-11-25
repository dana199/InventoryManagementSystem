using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using InventoryManagementSystem.Domain.Reader;

namespace InventoryManagementSystem.Domain
{
    public class Inventory
    {
        public List<Product> products = new List<Product>();
        private readonly IReader reader;

        public Inventory(IReader reader)
        {
           this.reader = reader;
        }
        public void AddProduct()
        {
            Product product = reader.ReadProduct();
            products.Add(product);
        }
        public void ViewAllProducts()
        {
            Console.WriteLine("The Products:");
            foreach (var product in products)
            {                                  
                Console.WriteLine(product);
            }
        }
        public void EditProduct()
        {
            string? name = reader.ReadString("Enter the name of the product You want To Edit:");
            Product? EditedProduct = products.Find(x => x.Name == name);
            if (EditedProduct == null)
            {
                Console.WriteLine("Product not found in inventory.");
                return;
            }
            foreach (var product in products)
            {
            if (EditedProduct.Name == product.Name)
                {
                    string? newName = reader.ReadString("Enter the new Product Name:");
                    EditedProduct.Name = newName;

                    int newprice = reader.ReadInt("Enter the new Product Price:");
                    EditedProduct.Price = newprice;

                    int newQuantity = reader.ReadInt("Enter the quantity of the product");
                    EditedProduct.Quantity = newQuantity;

                    Console.WriteLine($"Product updated successfully.");
                    Console.WriteLine($"The updated product:");
                    Console.WriteLine($"Name :{EditedProduct.Name}, Price: {EditedProduct.Price}, Quantity: {EditedProduct.Quantity}");
                }
            }
        }
        public void DeleteProduct()
        {
            string? productName = reader.ReadString("Enter the name of the product You want To Delete:");
            Product? product = products.Find(p => p.Name == productName);

                if (product == null)
                {
                    Console.WriteLine("Product not found in inventory.");
                    return;
                }
                if (productName == product.Name)
                {
                    products.Remove(product);
                    Console.WriteLine($"Product {productName} deleted");
                }
        }

        public void SearchProduct()
        {
            string? productName = reader.ReadString("Enter the name of the product you want to search for: ");

            Product? searchProduct = products.Find(p => p.Name == productName);

            if (searchProduct != null)
            {
                Console.WriteLine($"Product Found - Name: {searchProduct.Name}, Price: {searchProduct.Price}, Quantity: {searchProduct.Quantity}");
            }
            else
            {
                Console.WriteLine("Product not found in inventory.");
            }
        }
    }
    }

