using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assign
{
    internal class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }

        public int Quantity { get; set; }

        public Book(string title, string author, string genre, int quantity)
        {
            this.Title = title;
            this.Author = author;
            this.Genre = genre;
            this.Quantity = quantity;
        }

    }
}
