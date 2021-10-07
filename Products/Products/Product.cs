using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products
{
    class Product
    {
        public string name;
        public double price;
        public int quantity;


        public double TotalValueInStock()
        {
            return price * quantity;
        }

        public int AddProducts(int value)
        {
            return quantity += +value;
        }

        public int RemoveProducts(int value)
        {
            return quantity -= +value;
        }



    }
}
