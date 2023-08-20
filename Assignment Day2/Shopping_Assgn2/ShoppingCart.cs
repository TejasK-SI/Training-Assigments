using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Assgn2
{
    internal class ShoppingCart
    {
        Item item;
        List<Item> items = new List<Item>();

        public int Total_Price
        {
            get
            {
                int sum = 0;
                foreach (Item item in items)
                {
                    sum += item.Price*item.Quantity;
                }
                    
                return sum;
            }
        }


        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void Display()
        {
            foreach (Item item in items)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
