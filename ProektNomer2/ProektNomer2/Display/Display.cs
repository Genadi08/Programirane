using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektNomer2.Display
{
    public class Display
    {
        public int Print(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public void Show(string text)
        {
            Console.WriteLine(text);
        }
    }
}

