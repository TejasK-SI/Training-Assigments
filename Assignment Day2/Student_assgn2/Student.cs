using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_assgn2
{
    internal class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public char Gender { get; set; }

        public double GPA { get
            {
                int sum = 0;
                foreach (char item in Courses_Enrolled)
                {
                    if (item == 'A')
                    {
                        sum+=4;
                    }
                    else if(item == 'B') 
                    {
                        sum += 3;
                    }
                    else if (item == 'C')
                    {
                        sum += 2;
                    }
                    else if (item == 'D')
                    {
                        sum += 1;
                    }
                }
                return sum/Courses_Enrolled.Count;
            } 
        }

        public List<char> Courses_Enrolled
        {
            get;
            set;
        }

        public Student(int id, string name, int age, char gender, List<char> courses)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Courses_Enrolled = courses;
        }

        public override string ToString()
        {
            return "ID: "+ Id + " Name: " + Name + " Age: " + Age + " Gender: " + Gender + "GPA: " + GPA;
        }
    }
}
