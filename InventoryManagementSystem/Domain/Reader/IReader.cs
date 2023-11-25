using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Domain.Reader
{
    public interface IReader
    {
        string ReadString(string message);
        int ReadInt(string message);
        Product ReadProduct();
    }
}
