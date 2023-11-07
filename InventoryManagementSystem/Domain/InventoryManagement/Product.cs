using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Domain.InventoryManagement
{
    public class Product
    {
        public string? Name { set; get; }
        public int Price { set; get; }
        public int Quantity { set; get; }

        public Product(string? name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

    }
}
