using ProektNomer2.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DisplayType = ProektNomer2.Display.Display;

namespace ProektNomer2.Controller
{
    public class Controller
    {
        private DisplayType display;

        public Controller()
        {
            display = new DisplayType();
        }

        public int ExamHour { get; set; }
        public int ExamMinute { get; set; }
        public int ArrivalHour { get; set; }
        public int ArrivalMinute { get; set; }

        public void Run()
        {
            ExamHour = display.Print("Vuvedi chas na izpita ");
            ExamMinute = display.Print("Vuvedi minuti na izpita ");
            ArrivalHour = display.Print("Vuvedi chas na pristigane ");
            ArrivalMinute = display.Print("Vuvedi minuti na pristigane ");

            var (result, diff) = Cal();

            display.Show(result);
            if (diff != "")
            {
                display.Show(diff);
            }
        }

        private (string status, string difference) Cal()
        {
            int examTotal = ExamHour * 60 + ExamMinute;
            int arrivalTotal = ArrivalHour * 60 + ArrivalMinute;
            int cal = arrivalTotal - examTotal; 

            string status;
            if (cal > 0)
            {
                status = "Late";
            }
            else if (cal >= -30) 
            {
                status = "On time";
            }
            else
            {
                status = "Early";
            }

            string difference;
            if (cal == 0)
            {
                difference = string.Empty;
            }
            else
            {
                int minutes = Math.Abs(cal);
                string direction = null;
                if (cal >0)
                {
                    direction = "after";
                }
                else
                {
                    direction = "before";
                }

                if (minutes <60)
                {
                    difference = $"{minutes} minutes {direction} the start";
                }
                else
                {
                    int hours = minutes / 60;
                    int mins = minutes % 60;
                    difference = $"{hours}:{mins:00} hours {direction} the start";
                }
            }

            return (status, difference);
        }
    }
}

