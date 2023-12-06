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
            reader.PrintAllProducts(products);
        }
        public void EditProduct()
        {
            string? NameOfProductToEdit = reader.ReadString("Enter the name of the product You want To Edit:");
            Product? ProductToFind = products.Find(x => x.Name == NameOfProductToEdit);

            if (ProductToFind == null)
            {
                Console.WriteLine("Product not found in inventory.");
                return;
            }
            Product ProductToEdit = reader.ReadProduct();
            ProductToFind.Name = ProductToEdit.Name;
            ProductToFind.Price = ProductToEdit.Price;
            ProductToFind.Quantity = ProductToEdit.Quantity;

                    Console.WriteLine($"Product updated successfully.");
                    Console.WriteLine($"The updated product:");
                    Console.WriteLine($"Name :{ProductToFind.Name}, Price: {ProductToFind.Price}, Quantity: {ProductToFind.Quantity}");

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

        public Product SearchProduct()
        {
            string? productName = reader.ReadString("Enter the name of the product you want to search for: ");

            Product? searchProduct = products.Find(p => p.Name == productName);

            return searchProduct;

        }
    }
    }

