using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    
    public class NumberSearch
    {
        public int[] array;
        private int length;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        
        
        public void Search()
        {
            
            array = new int[Length];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                array[i] = i + 1;
            }


            

            int Down = array[0];
            int Up = array[array.Length - 1];
            int count = Up / 2;


            for (int i = 0; i < array.Length; i++)
            {


                Console.WriteLine($"{count}? Yes/More/Smaller");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    Console.WriteLine("I guessed your number!");
                    break;
                }
                else if (answer == "More")
                {

                    Down = count;

                    count = (Up + Down) / 2;
                    continue;

                }
                else if (answer == "Smaller")
                {

                    Up = count;

                    count = (Down + Up) / 2;
                    continue;
                }
            }
        }
        public void Verif()//Verification of the correctness of the entered data
        {
            for (; ; )
            {
                Console.WriteLine($"We are looking for a number from 1 to {Length}? (Yes/No)");
                string ver = Console.ReadLine();
                if (ver == "Yes")
                {
                    Console.WriteLine("Ok, let's get started!");
                    break;
                }
                else if (ver=="No")
                {
                    Console.WriteLine("Please, enter a number");
                    Length = int.Parse(Console.ReadLine());
                    break;
                }
                else
                {
                    Console.WriteLine("Please, select the correct option(Yes/No)");
                }
            }
        }

    }
}
