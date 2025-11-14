using Proekt2luboigenadi.Model;
using Proekt2luboigenadi.Dislplay;
using Proekt2luboigenadi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt2luboigenadi.Controller
{
    public class Controller
    {
        private Time model;
        private Display display;

        public void Run()
        {
            model = new Time();
            display = new Display();
            display.GetInput(out int examHour, out int examMinute, out int arrivalHour, out int arrivalMinute);
            model.ExamHour = examHour;
            model.ExamMinute = examMinute;
            model.AirrivalHour = arrivalHour;
            model.ArrivalMinute = arrivalMinute;
            string status = model.Status();
            display.PrintResult(status,model.TimeDifference(model.AirrivalHour - model.ExamHour));
        }
    }
}
