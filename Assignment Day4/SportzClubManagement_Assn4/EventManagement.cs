using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportzClubManagement_Assn4
{
    internal class EventManagement
    {
        public static List<Event> events = new List<Event> { };

        public void Menu()
        {
            do
            {
                Console.WriteLine("Enter an option to proceed: \n");

                Console.WriteLine("1. Create Event. \n2. View Event Details. \n3. Update Event Details. \n4. Remove Event. \n5. Get Events By Type. \n6. Get Upcoming Events. \n7. Exit \n");
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        CreateEvent();
                        break;
                    case 2:
                        ViewEventDetails();
                        break;
                    case 3:
                        UpdateEventDetails();
                        break;
                    case 4:
                        RemoveEvent();
                        break;
                    case 5:
                        GetEventsByType();                                                
                        break;
                    case 6:
                        GetUpcomingEvents();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Enter a valid option! \n");
                        break;
                }

            } while (true);
        }


        public void CreateEvent()
        {
            Console.WriteLine("Enter Event Name: ");
            string eventname = Console.ReadLine();

            Console.WriteLine("Enter Event Type: ");
            string eventtype = Console.ReadLine();

            Console.WriteLine("Enter Event Date (e.g. dd/mm/yyyy): ");
            DateTime eventdate = DateTime.Parse(Console.ReadLine());

            Event event1 = new Event(eventname, eventtype, eventdate);
            events.Add(event1);
            Console.WriteLine("Event Added successfully. \n");
        }

        public void ViewEventDetails()
        {
            if (events.Count != 0)
            {
                Console.WriteLine("Enter Event ID: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Event event1 in events)
                {
                    if (event1.EventId != id)
                    {
                        Console.WriteLine("Event not found. \n");
                    }
                    else
                    {
                        Console.WriteLine(event1.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine("No Records Found! \n");
            }
        }

        public void UpdateEventDetails()
        {
            if (events.Count != 0)
            {
                Console.WriteLine("Enter Event ID: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Event event1 in events)
                {
                    if (event1.EventId == id)
                    {
                        Console.WriteLine("Enter the detail to be edited: \n1. Event Name. \n2. Event Type. \n3. Event Date. \n4. Exit");
                        int opt = int.Parse(Console.ReadLine());

                        switch (opt)
                        {
                            case 1:
                                Console.WriteLine("Enter Event Name: ");
                                string eventname = Console.ReadLine();
                                event1.EventName = eventname;
                                break;

                            case 2:
                                Console.WriteLine("Enter Event Type: ");
                                string eventtype = Console.ReadLine();
                                event1.EventType = eventtype;
                                break;

                            case 3:
                                Console.WriteLine("Enter Event Date (in dd/mm/yyyy): ");
                                DateTime eventdate = DateTime.Parse(Console.ReadLine());
                                event1.EventDate = eventdate;
                                break;

                            case 4:                                
                                return;

                            default:
                                Console.WriteLine("Enter a correct choice. \n");
                                break;

                        }
                        Console.WriteLine("Update successful. \n");
                    }
                    else
                    {
                        Console.WriteLine("Event not found. \n");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Records Found. \n");
            }
        }

        public void RemoveEvent()
        {
            if (events.Count != 0)
            {
                Console.WriteLine("Enter Event ID: ");
                int id = int.Parse(Console.ReadLine());

                foreach (Event event1 in events)
                {
                    if (event1.EventId == id)
                    {
                        events.Remove(event1);
                        Console.WriteLine("Event removed successfully. \n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Event not found. \n");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Records Found. \n");
            }
        }

        // LINQ queries

        public void GetEventsByType()
        {
                Console.WriteLine("Enter Event type: ");
                string eventType = Console.ReadLine();     

                var allEvents = events.Where(e => e.EventType == eventType).ToList();


                int count = 0;
                foreach(var eventWithType in allEvents)
                {
                    Console.WriteLine(eventWithType);
                    count++;
                }
                if(count == 0)
                {
                    Console.WriteLine("No events with such type.\n");
                }
        }

        public void GetUpcomingEvents()
        {
            DateTime currentDate = DateTime.Now.Date;
            var upcomingEvents = events.Where(e => e.EventDate > currentDate).OrderBy(e => e.EventDate).ToList();

            int count = 0;
            foreach (var eventWithType in upcomingEvents)
            {
                Console.WriteLine(eventWithType);
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine("No upcoming events.\n");
            }

        }

    }
}
