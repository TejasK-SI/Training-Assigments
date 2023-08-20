
namespace Employee_Hierarchy_Assgn3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1, "Tejas", 50000);
            manager.Display();

            Developer developer = new Developer(2, "Tej", 45000);
            developer.Display();

            SalesPerson salesPerson = new SalesPerson(3, "Tejust", 40000);
            salesPerson.Display();
        }
    }
}