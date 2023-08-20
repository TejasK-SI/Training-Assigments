namespace Shopping_Assgn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
            ShoppingCart cart = new ShoppingCart();

            do
            {
                Console.WriteLine("Enter a choice from below: ");
                Console.WriteLine("1. Add new item to cart \n2. Display items in cart \n3. Calculate and display total cost of items in cart \n4. Exit");
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

                        Item item = new Item(name, price, quantity);
                        cart.AddItem(item);
                        break;

                    case 2:
                        cart.Display();
                        break;

                    case 3:
                        Console.WriteLine(cart.Total_Price);
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