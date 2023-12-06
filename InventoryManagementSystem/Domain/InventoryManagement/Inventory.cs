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
        public void AddProduct(Product ProductToAdd)
        {
            products.Add(ProductToAdd);
        }
        public List<Product> GetAllProducts()
        {
            return products;
        }
        public void EditProduct(string ProductName)
        {
            Product? ProductToFind = products.Find(x => x.Name == ProductName);

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
        public void DeleteProduct(string ProductName)
        {         
            Product? product = products.Find(p => p.Name == ProductName);

            if (product == null)
            {
                Console.WriteLine("Product not found in inventory.");
                return;
            }
            if (ProductName == product.Name)
            {
                products.Remove(product);
                Console.WriteLine($"Product {ProductName} deleted");
            }
        }

        public Product SearchProduct(string productName)
        {
            Product? searchProduct = products.Find(p => p.Name == productName);
            return searchProduct;

        }
    }
}

