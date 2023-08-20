using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Store
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public virtual void DisplayProduct()
        {            
            Console.WriteLine("Product ID: " + Id + "\nName: " + Name + "\nPrice: " + Price + "\nQuantity: " + Quantity);
        }
    }

    class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics(int id, string name, int price, int quantity, string brand)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Brand = brand;
        }

        public override void DisplayProduct()
        {
            base.DisplayProduct();
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine();
        }
    }

    class Clothing : Product
    {
        public string Size { get; set; }

        public Clothing(int id, string name, int price, int quantity, string size)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Size = size;
        }

        public override void DisplayProduct()
        {
            base.DisplayProduct();
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine();
        }
    }

    class Books : Product
    {
        public string Author { get; set; }

        public Books(int id, string name, int price, int quantity, string author)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Author = author;
        }

        public override void DisplayProduct()
        {
            base.DisplayProduct();
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine();
        }
    }
}

