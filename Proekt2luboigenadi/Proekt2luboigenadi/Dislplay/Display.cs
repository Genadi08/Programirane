using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proekt2luboigenadi.Dislplay
{
    public class Display
    {
        public void PrintResult(string status, string difference)
        {
            Console.WriteLine(status);
            if (status == "On time")
            {
                Console.WriteLine(difference + (status == "Late" ? " after the start" : " before the start"));
            }
            else
            {
                Console.WriteLine(status);
                if (status == "Late")
                {
                    Console.WriteLine(difference + (status == "Late" ? " after the start" : " before the start"));
                }
            }
            Console.WriteLine(status);
            if (status == "Early")
            {
                Console.WriteLine(difference + (status == "Late" ? " after the start" : " before the start"));
            }



        }

        public void GetInput(out int examHour, out int examMinute, out int arrivalHour, out int arrivalMinute)
        {
            examHour = int.Parse(Console.ReadLine());
            examMinute = int.Parse(Console.ReadLine());
            arrivalHour = int.Parse(Console.ReadLine());
            arrivalMinute = int.Parse(Console.ReadLine());
        }
    }
}
