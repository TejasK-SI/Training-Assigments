using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem_Assgn3
{
    internal class Student
    {
        public string Name { get; set; }

        public int[] Grades { get; set; }

        public Student(string name, int[] grades)
        {
            Name = name;
            Grades = grades;
        }

        public void Display()
        {
            int sum = 0;
            Console.WriteLine($"Student: {Name}");

            Console.Write("Grades: ");

            foreach (int i in Grades)
            {
                Console.Write(i + " ");
            }

            foreach (int i in Grades)
            {
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Average Grade: {sum / Grades.Length}");

        }

    }
}
