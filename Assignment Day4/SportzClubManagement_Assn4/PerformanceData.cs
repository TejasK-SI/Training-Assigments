using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzClubManagement_Assn4 
{    
    internal class PerformanceData
    {
        public int AthleteID_PD { get; set; }

        public string AthleteName_PD { get; set; }

        public int EventID_PD { get; set; }

        public string EventName_PD { get; set; }
        public double Score { get; set; }

        public double Time { get; set; }

        public char Result { get; set; }

        public PerformanceData(int athleteid, string athletename, int eventid, string eventname, double score, double time, char result)
        {
            AthleteID_PD = athleteid;
            AthleteName_PD = athletename;
            EventID_PD = eventid;
            EventName_PD = eventname;
            Score = score;
            Time = time;
            Result = result;
        }

        public override string ToString()
        {
            return "Athlete ID: " + AthleteID_PD + " Athlete Name: " + AthleteName_PD + " Event ID: " + EventID_PD + " Event Name: " + EventName_PD + " Score: " + Score + " Time: " + Time + " Result: " + Result;
        }
    }
}
