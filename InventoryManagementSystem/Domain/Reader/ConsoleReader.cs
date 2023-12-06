using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManagementSystem.Domain.Reader
{
    class ConsoleReader : IReader
    {
        public string ReadString(string message)
        {
            Console.WriteLine(message);
            string? name = Console.ReadLine();
            return name ?? "";
        }

        public int ReadInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public Product ReadProduct()
        {
            string? name = ReadString("Enter the name of the product:");
            int price = ReadInt("Enter the price of the product:");
            int quantity = ReadInt("Enter the quantity of the product");
            return new Product(name, price, quantity);
        }

        public void PrintAllProducts(List<Product> products)
        {
            Console.WriteLine("The Products:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
