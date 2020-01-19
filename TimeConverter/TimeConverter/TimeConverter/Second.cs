using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConverter
{
    class Second
    {
        private int sec;
        public int Sec
        {
            get { return sec; }
            set { sec = value; }
        }
        public static explicit operator Timer(Second second)
        {
            int h = second.Sec / 3600;
            int m = (second.Sec - h * 3600) / 60;
            int s = second.Sec - h * 3600 - m * 60;
            return new Timer { Hou = h, Min = m, Sec = s };
        }
        public static explicit operator Second(Timer timer)
        {

            int h = timer.Hou * 3600;
            int m = timer.Min * 60;
            int s = timer.Sec + h + m;
            return new Second { Sec = s };
        }

    }
}
