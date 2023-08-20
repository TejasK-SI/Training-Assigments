namespace StudentGradingSystem_Assgn3
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int i = 0;
            //List<int> grades = new List<int> { } ;

            Console.WriteLine("Student Grading System\n----------------------");
            Console.WriteLine("Enter Name of student: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the number of grades to be entered: ");
            int n = int.Parse(Console.ReadLine());

            int[] grades = new int[n];

            while (i < n)
            {
                    
                Console.WriteLine($"Enter grade {i + 1}:");

                try
                {
                    int m = Convert.ToInt32(Console.ReadLine());
                    if (m <= 0 || m >= 100)
                    {
                        throw new Exception("Invalid input! Grade must be between 0 and 100.");
                    }
                    else
                    {
                        grades[i] = m;
                        i++;
                    }
                }

                catch(FormatException)
                {

                    Console.WriteLine("Invalid input! Please enter a numeric value.");
                    continue;
                }

                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                } 
            }

            Student student = new Student(name, grades);
            student.Display();
        }
    }
}