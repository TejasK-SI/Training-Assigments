using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzClubManagement_Assn4
{
    internal class PerformanceTracking
    {
        static List<PerformanceData> performanceDatas = new List<PerformanceData> { };


        Athlete athlete;

        List<Athlete> athletes = AthleteManagement.athletes;

        Event event1;
       
        List<Event> events = EventManagement.events;
        

        public void Menu()
        {
            do
            {
                Console.WriteLine("Enter an option to proceed: \n");

                Console.WriteLine("1. Record Athlete Performance. \n2. View Athlete Performance. \n3. Get Athlete Performance In All Events. \n4. Exit \n");
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        RecordAthletePerformance();
                        break;
                    case 2:
                        ViewAthletePerformance();
                        break;
                    case 3:
                        GetAthletePerformanceInAllEvents();
                        break;
                    case 4:                        
                        return;
                    default:
                        Console.WriteLine("Enter a valid option! \n");
                        break;
                }

            } while (true);
        }

        public void RecordAthletePerformance()
        {
            if (athletes.Count != 0 && events.Count != 0)
            {
                Console.WriteLine("Enter the Athlete ID to enter performance data: ");
                int athlete_id = int.Parse(Console.ReadLine());

                foreach (Athlete athlete in athletes)
                {

                    if (athlete_id == athlete.AtheleteId)
                    {
                        Console.WriteLine("Enter the Event ID to enter performance data: ");
                        int event_id = int.Parse(Console.ReadLine());

                        foreach(Event event1 in events)
                        {
                            if(event_id == event1.EventId)
                            {
                                Console.WriteLine("Enter Score of the athlete: ");
                                double score = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter Time of the athlete in mins: ");
                                double time = double.Parse(Console.ReadLine());

                                Console.WriteLine("Enter result status of the athlete (W for Won & L for Lost)");
                                char result = char.Parse(Console.ReadLine());

                                PerformanceData performanceData = new PerformanceData(athlete_id, athlete.FirstName + athlete.LastName, event_id, event1.EventName, score, time, result);
                                performanceDatas.Add(performanceData);

                                Console.WriteLine("Performance Recorded Successfully.\n");

                            }
                            else
                            {
                                Console.WriteLine("Event Not Found.");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Athlete Not Found.");
                        break;
                    }
                }
        }
            else
            {
                Console.WriteLine("No records for athlete or events.\nPlease enter athlete and event details first.\n");
            }

}

        public void ViewAthletePerformance()
        {
            if (performanceDatas.Count != 0)
            {
                Console.WriteLine("Enter the Athlete ID to enter performance data: ");
                int athlete_id = int.Parse(Console.ReadLine());

                foreach (Athlete athlete in athletes)
                {

                    if (athlete_id == athlete.AtheleteId)
                    {
                        Console.WriteLine("Enter the Event ID to enter performance data: ");
                        int event_id = int.Parse(Console.ReadLine());

                        foreach (Event event1 in events)
                        {
                            if (event_id == event1.EventId)
                            {
                                foreach(PerformanceData performanceData in performanceDatas)
                                {
                                    if(athlete_id == performanceData.AthleteID_PD && event_id == performanceData.EventID_PD)
                                    {
                                        Console.WriteLine(performanceData.ToString());
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Event Not Found.");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Athlete Not Found.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No Performance Data Found.");
            }

        }

        public void GetAthletePerformanceInAllEvents()
        {
            if (performanceDatas.Count != 0)
            {
                Console.WriteLine("Enter the Athlete ID to enter performance data: ");
                int athlete_id = int.Parse(Console.ReadLine());

                foreach (Athlete athlete in athletes)
                {

                    if (athlete_id == athlete.AtheleteId)
                    {
                        foreach (PerformanceData performanceData in performanceDatas)
                        {
                            if (athlete_id == performanceData.AthleteID_PD)
                            {
                                Console.WriteLine(performanceData.ToString());
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Athlete Not Found.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No Performance Data Found.");
            }

        }

    }
}
