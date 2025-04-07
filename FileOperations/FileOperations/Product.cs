using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    internal class Product
    {
        public string name;
        public double amount;
        public double unitPrice;

        public double totalPrice()
        {
            return amount * unitPrice;
        }

    }
}
