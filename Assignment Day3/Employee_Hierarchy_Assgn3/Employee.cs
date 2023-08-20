using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Hierarchy_Assgn3
{
    internal abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public abstract double Calculate_Bonus();

        public void Display()
        {
            Console.WriteLine("Id: " + Id + " Name: " + Name + " Salary: " + Salary + " Bonus: " + Calculate_Bonus());
        }
    }

    class Manager : Employee
    {
        public Manager(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
                
        public override double Calculate_Bonus()
        {
            return Salary * 0.25;
        }
    }

    class Developer : Employee
    {
        public Developer(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override double Calculate_Bonus()
        {
            return Salary * 0.20;
        }
    }

    class SalesPerson : Employee
    {
        public SalesPerson(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override double Calculate_Bonus()
        {
            return Salary * 0.10;
        }
    }
}
