using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportzClubManagement_Assn4
{
    internal class Event
    {
        private static int eventid = 1;

        public int EventId { get; }

        public string EventName { get; set; }

        public string EventType { get; set; }

        public DateTime EventDate { get; set; }

        public Event(string eventname, string eventtype, DateTime eventdate)
        {
            EventId = eventid++;
            EventName = eventname;
            EventType = eventtype;
            EventDate = eventdate;
        }

        public override string ToString()
        {
            return "Event ID: " + EventId + " Event Name: " + EventName + " Event Type: " + EventType + " Event Date: " + EventDate;
        }
    }
}
