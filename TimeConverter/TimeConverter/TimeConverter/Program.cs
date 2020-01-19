using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Second second = new Second();
            second.Sec = 120;
            Timer timer = (Timer)second;
            Console.WriteLine($"{timer.Hou} : {timer.Min} : {timer.Sec}");
            Second second1 = (Second)timer;
            Console.WriteLine(second1.Sec);
            Console.ReadLine();


        }
    }
    

}

