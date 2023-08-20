using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore_Assgn2
{
    internal class Store
    {
        Product product;
        List<Product> products = new List<Product>();

        public int Total_Price
        {
            get
            {
                int sum = 0;
                foreach (Product product in products)
                {
                    sum += product.Price * product.Quantity;
                }

                return sum;
            }
        }


        public void AddItem(Product product)
        {
            products.Add(product);
        }

        public void Display()
        {
            foreach (Product product in products)
            {
                Console.WriteLine("Name: " + product.Name + " Price: " + product.Price + " Quantity: " + product.Quantity + " Category: " + product.category);
            }

        }
    }
}
