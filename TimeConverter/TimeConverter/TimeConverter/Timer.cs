using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConverter
{
    class Timer
    {
        private string[] Time;
        public int Hour { get; set; }
        public int Min { get; set; }
        public int Sec { get; set; }
        public static bool flag = true;
        public void ConvertingToTime(string[] vs)
        {
            try
            {
                int sec = Convert.ToInt32(vs[0]);
                if (sec >= 0)
                {
                    Hour = sec / 3600;
                    Min = (sec - (Hour * 3600)) / 60;
                    Sec = sec - ((Min * 60) + (Hour * 3600));
                }
                else
                {

                    flag = false;
                    Console.WriteLine("Incorrect input!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter numbers (do not forget that hours, minutes and seconds are separated \":\")!");
                flag = false;

            }



        }
        public void DisplayTime()
        {
            Console.WriteLine($"{Hour}:{Min}:{Sec}");
        }
        public void ConvertingToSec(string[] vs)

        {
            try
            {
                Hour = Convert.ToInt32(vs[0]);
                Min = Convert.ToInt32(vs[1]);
                Sec = Convert.ToInt32(vs[2]);
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid input! Please enter numbers (do not forget that hours, minutes and seconds are separated \":\")!");
                flag = false;
            }


            if (Hour >= 0 && Min >= 0 && Sec >= 0)
            {
                Sec = (Hour * 3600) + (Min * 60) + Sec;
                Hour = 0;
                Min = 0;
            }
            else
            {
                flag = false;
                Console.WriteLine("Incorrect input!");
            }






        }
        public void DisplaySec()
        {
            Console.WriteLine(Sec);
        }
        public string[] Input(string str)
        {
            if (str.Contains(":"))
            {
                return Time = str.Split(':');

            }
            else
            {

                return Time = new string[] { str };
            }
        }
    }
}
