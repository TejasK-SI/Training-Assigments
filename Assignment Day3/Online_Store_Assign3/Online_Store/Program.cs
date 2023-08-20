namespace Online_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product; 

            product = new Electronics(1, "TV", 50000, 2, "Samsung");
            product.DisplayProduct();
            
            product = new Clothing(2, "T-Shirt", 200, 5, "Samsung");
            product.DisplayProduct();

            product = new Books(3, "SAONGAF", 200, 1, "J.K. Rowling");
            product.DisplayProduct();



        }
    }
}