namespace SportzClubManagement_Assn4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sportz Club Management");

            do
            {
                Console.WriteLine("Enter an option to proceed: \n");

                Console.WriteLine("1. Athlete Management.\n2. Event Management. \n3. Exit");
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        AthleteManagement athletemgt = new AthleteManagement();
                        athletemgt.Menu();
                        break;
                    case 2:
                        EventManagement eventmgt = new EventManagement();
                        eventmgt.Menu();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Enter a valid option!");
                        break;
                }
            }while (true);
        }
    }
}