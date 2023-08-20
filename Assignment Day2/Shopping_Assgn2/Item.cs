using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Assgn2
{
    internal class Item
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public Item(string name, int price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Quantity: " + Quantity + " Price: " + Price;
        }


    }
}
