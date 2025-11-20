using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektNomer2.Model
{
    public class Model
    {
        public int ExamHour { get; set; }
        public int ExamMinute { get; set; }
        public int ArrivalHour { get; set; }
        public int ArrivalMinute { get; set; }
        public string CalculateStatus()
        {
            int examTime = ExamHour * 60 + ExamMinute;
            int arrivalTime = ArrivalHour * 60 + ArrivalMinute;

            int diff = arrivalTime - examTime;

            if (diff > 0)
            {
                return "Late";
            }
            else if (diff >= -30)
            {
                return "On time";
            }
            else
            {
                return "Early";
            }
        }
        public string Cal()
        {
            int examTime = ExamHour * 60 + ExamMinute;
            int arrivalTime = ArrivalHour * 60 + ArrivalMinute;

            int late = arrivalTime - examTime;

            if (late == 0) return "";

            int early = Math.Abs(late);
            int hours = early / 60;
            int minutes = early % 60;

            if (late < 0) 
            {
                if (early < 60)
                {
                    return $"{early} minutes before the start";
                }
                else
                {
                    return $"{hours}:{minutes} hours before the start";
                }
            }
            else
            {
                if (early < 60)
                {
                    return $"{early} minutes after the start";
                }
                else
                {
                    return $"{hours}:{minutes} hours after the start";
                }
            }
        }
    }
}
