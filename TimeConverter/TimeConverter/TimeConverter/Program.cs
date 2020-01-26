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
            Console.WriteLine("To convert seconds to Hou: Min: Sec format, enter the number of seconds");
            Console.WriteLine("To convert from the format Hou: Min: Sec to seconds, enter  the time in the format Hou: Min: Sec ");
            Timer timer = new Timer();
            string output = Console.ReadLine();
            string[] time = timer.Input(output);
            if (output.Contains(":"))
            {
                timer.ConvertingToSec(time);
                if (Timer.flag)
                {
                    timer.DisplaySec();
                }

            }
            else
            {

                timer.ConvertingToTime(time);
                if (Timer.flag)
                {
                    timer.DisplayTime();
                }


            }






            Console.Read();


        }
    }
    

}

