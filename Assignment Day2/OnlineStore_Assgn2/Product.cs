using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_Assgn2
{
    internal class Product
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public string category { get; set; }

        public Product(string name, int price, int quantity, string category)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.category = category;
        }
    }
}
