using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_assgn2
{
    internal class School
    {
        Student student;

        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void Display()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(students.ToString());
            }
            
        }

        public void Calculate_Overall()
        {
            double overall_gpa = 0;           
            foreach (Student student in students)
            {
                overall_gpa += student.GPA;                
            }

            Console.WriteLine($"Overall GPA is " +overall_gpa/students.Count);
        }
    }
}
