namespace Student_assgn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opt;
            School school = new School();

            do
            {
                Console.WriteLine("Enter a choice from below: ");
                Console.WriteLine("1. Add new student \n2. Display Student List \n3. Calculate and display overall GPA \n4. Exit");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.WriteLine("Enter Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Gender: ");
                        char gender = Convert.ToChar(Console.ReadLine());

                        Console.WriteLine("Enter number of courses: ");
                        int num_of_course = Convert.ToInt32(Console.ReadLine());

                        List<char> courses = new List<char>();

                        Console.WriteLine("Enter grades for subjects: ");

                        while (num_of_course!=0)
                        {
                            char grade = Convert.ToChar(Console.ReadLine());

                            if (grade.Equals('A') || grade.Equals('B') || grade.Equals('C') || grade.Equals('D'))
                            {
                                courses.Add(grade);
                                num_of_course--;
                            }
                            else
                            {
                                Console.WriteLine("Enter a valid grade from A to D");
                            }
                        }

                        Student s1 = new Student(id, name, age, gender, courses);
                        school.AddStudent(s1);
                        break;

                    case 2:
                        school.Display();
                        break;

                    case 3:
                        school.Calculate_Overall();
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