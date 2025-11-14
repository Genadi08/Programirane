using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt2luboigenadi.Model
{
    public class Time
    {
        private int examHour;
        private int examMinute;
        private int arrivalHour;
        private int arrivalMinute;

        public int ExamHour { get; set; }
        public int ExamMinute { get; set; }
        public int ArrivalMinute { get; set; }
        public int AirrivalHour { get; set; }

        public int TimeInMinutes(int hour, int minute)
        {
            return hour * 60 + minute;
        }

        public string Status()
        {
            int examTime = TimeInMinutes(examHour, examMinute);
            int arrivalTime = TimeInMinutes(arrivalHour, arrivalMinute);
            int timeDifference = arrivalTime - examTime;
            string difference;

            if (timeDifference > 0)
            {
                difference = TimeDifference(timeDifference);
                return "Late";
            }        
             else if  (timeDifference < -30)
            {
                difference = TimeDifference(-timeDifference);
                return "Early";
            }
            else
            {
                difference = TimeDifference(-timeDifference);
                return "On time";
            }

        }
        public string TimeDifference(int timeDifference)
        {
            int hours = timeDifference / 60;
            int minutes = timeDifference % 60;
            if (hours > 0)
            {
                return $"{hours}:{minutes:D2} hours";
            }
            else
            {
                return $"{minutes} minutes";
            }
        }
    }
}

