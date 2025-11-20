using System;
using ProektNomer2.Controller;

namespace ProektNomer2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller.Controller controller = new Controller.Controller();
            controller.Run();
        }
    }
}
