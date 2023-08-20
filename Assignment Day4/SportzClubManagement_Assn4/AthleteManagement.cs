using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzClubManagement_Assn4
{
    internal class AthleteManagement 
    {
        public static List<Athlete> athletes = new List<Athlete>{};

        public void Menu()
        {
            do
            {
                Console.WriteLine("Enter an option to proceed: \n");

                Console.WriteLine("1. Register Athlete.\n2. View Athlete Details. \n3. Update Athlete Details. \n4. Remove Athlete. \n5. View Performance Menu. \n6. Get Athletes By Sport. \n7. Exit \n");
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        RegisterAthlete();
                        break;
                    case 2:
                        ViewAthleteDetails();
                        break;
                    case 3:
                        UpdateAthleteDetails();
                        break;
                    case 4:
                        RemoveAthlete();
                        break;
                    case 5:
                        PerformanceTracking performance = new PerformanceTracking();
                        performance.Menu();
                        break;
                    case 6:
                        GetAthletesBySport();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Enter a valid option! \n");
                        break;
                }
            }while (true);
        }

        public void RegisterAthlete()
        {

            Console.WriteLine("Enter First Name: ");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Sport: ");
            string sport = Console.ReadLine();

            Console.WriteLine("Enter Registration Date (e.g. dd/mm/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Athlete athlete = new Athlete(fname, lname, age, sport, date);
            athletes.Add(athlete);


        }

        public void ViewAthleteDetails()
        {
            if (athletes.Count != 0)
            {                
                Console.WriteLine("Enter Athlete ID: ");
                int id = int.Parse(Console.ReadLine());

                foreach(Athlete athlete in athletes)
                {
                    if(athlete.AtheleteId == id)
                    {
                        Console.WriteLine(athlete.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Athlete not found. \n");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Records Found! \n");
            }
            
        }

        public void UpdateAthleteDetails()
        {
            if (athletes.Count != 0)
            {
                Console.WriteLine("Enter Athlete ID to Update the details: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Athlete athlete in athletes)
                {
                    if (athlete.AtheleteId == id)
                    {
                        //Console.WriteLine(athlete.ToString());

                        Console.WriteLine("Enter the detail to be edited: \n1. First Name. \n2. Last Name. \n3. Age. \n4. Sport. \n5. Exit");
                        int opt = int.Parse(Console.ReadLine());

                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine("Enter First Name: ");
                                string fname = Console.ReadLine();
                                athlete.FirstName = fname;
                                break;

                            case 2:
                                Console.WriteLine("Enter Last Name: ");
                                string lname = Console.ReadLine();
                                athlete.LastName = lname;
                                break;

                            case 3:
                                Console.WriteLine("Enter Age: ");
                                int age = int.Parse(Console.ReadLine());
                                athlete.Age = age;
                                break;

                            case 4:
                                Console.WriteLine("Enter Sport: ");
                                string sport = Console.ReadLine();
                                athlete.Sport = sport;
                                break;

                            case 5:
                                return;

                            default:
                                Console.WriteLine("Enter a correct choice. \n");
                                break;

                        }


                        Console.WriteLine("Update successful.\n");
                    }
                    else
                    {
                        Console.WriteLine("Athlete not found.\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Records Found!\n");
            }

        }

        public void RemoveAthlete()
        {
            if (athletes.Count != 0)
            {
                Console.WriteLine("Enter Athlete ID: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Athlete athlete in athletes)
                {
                    if (athlete.AtheleteId == id)
                    {
                        athletes.Remove(athlete);
                        Console.WriteLine("Athlete removed successfully. \n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Athlete not found. \n");
                    }
                }

                
            }
            else
            {
                Console.WriteLine("No Records Found!\n");
            }

        }

        // LINQ queries
        public void GetAthletesBySport()
        {
            Console.WriteLine("Enter Sport name: ");
            string sport = Console.ReadLine();

            var athleteBySport = athletes.Where(a => a.Sport == sport).ToList();

            if (athleteBySport.Count != 0)
            {
                foreach(var aths in athleteBySport)
                {
                    Console.WriteLine(aths);
                }
            }
            else
            {
                Console.WriteLine("No Athletes for entered sports. ");
            }
        }


    }
}
