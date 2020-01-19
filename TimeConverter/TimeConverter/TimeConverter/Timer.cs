using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConverter
{
    class Timer
    {
        private int hou;
        private int min;
        private int sec;
        public int Hou
        {
            get { return hou; }
            set { hou = value; }
        }
        public int Sec
        {
            get { return sec; }
            set { sec = value; }
        }
        public int Min
        {
            get { return min; }
            set { min = value; }
        }
    }
}
