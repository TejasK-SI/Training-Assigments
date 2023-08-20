using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Assign
{
    internal class Library
    {
        Book book;

        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void Display()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("Title: " + book.Title + " Author: " + book.Author + " Genre: " + book.Genre + " Quantity: " + book.Quantity);
            }

        }

        public void Search_Book(string search)
        {
            foreach (Book book in books)
            {
                if (search == book.Author || search == book.Title)
                {
                    Console.WriteLine("Title: " + book.Title + " Author: " + book.Author + " Genre: " + book.Genre + " Quantity: " + book.Quantity);
                }
            }

        }
    }
}
