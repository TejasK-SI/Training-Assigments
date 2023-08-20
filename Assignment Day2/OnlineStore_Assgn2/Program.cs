namespace OnlineStore_Assgn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
            Store store = new Store();

            do
            {
                Console.WriteLine("Enter a choice from below: ");
                Console.WriteLine("1. Add new product \n2. Display products in stock \n3. Calculate and display total cost of products \n4. Exit");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Enter Item Name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Price: ");
                        int price = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Enter Quantity of {name}: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Category: ");
                        string category = Console.ReadLine();

                        Product product = new Product(name, price, quantity, category);
                        store.AddItem(product);
                        break;

                    case 2:
                        store.Display();
                        break;

                    case 3:
                        Console.WriteLine("Total value of products in stock is " + store.Total_Price);
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Enter a valid choice!");
                        break;

                }
            } while (true);

        }
    }
}