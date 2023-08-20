using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportzClubManagement_Assn4
{
    internal class Athlete
    {
        private static int atheleteId = 1;
        public int AtheleteId
        {
            get;                                     
        }

        public string FirstName { get; set;  }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Sport { get; set;  }

        public DateTime RegistrationDate { get; }

        public Athlete(string firstName, string lastName, int age, string sport, DateTime registrationDate)
        {
            AtheleteId = atheleteId++;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sport = sport;
            RegistrationDate = registrationDate;
        }

        public override string ToString()
        {
            return "Athlete ID: " + AtheleteId + " Name: " + FirstName + " " + LastName + " Age: " + Age + " Sport: " + Sport + " Registration Date: " + RegistrationDate;
        }
    }
}
