namespace Library_Assign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
            Library library = new Library();

            do
            {
                Console.WriteLine("Enter a choice from below: ");
                Console.WriteLine("1. Add New Book \n2. Display Books List \n3. Search Book by Title \n4. Search Book by Author \n5. Exit");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Enter Book Title: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Author: ");
                        string author = Console.ReadLine();

                        Console.WriteLine("Enter Genre: ");
                        string genre = Console.ReadLine();

                        Console.WriteLine("Enter Quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        Book book = new Book(name, author, genre, quantity);
                        library.AddBook(book);
                        break;

                    case 2:
                        library.Display();
                        break;

                    case 3:
                        Console.WriteLine("Enter Title: ");
                        string srch_title = Console.ReadLine();
                        library.Search_Book(srch_title);
                        break;

                    case 4:
                        Console.WriteLine("Enter Author name: ");
                        string srch_author = Console.ReadLine();
                        library.Search_Book(srch_author);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Enter a valid choice!");
                        break;

                }
            } while (true);
        }
    }
}