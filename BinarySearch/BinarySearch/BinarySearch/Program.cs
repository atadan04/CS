using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"I'll try to guess your number in fewer attempts");
            NumberSearch number = new NumberSearch();

            Console.WriteLine($"Enter the range of the desired number (for example: 1000)");
            
            while(true)
            {
                try
                {

                    number.Length = int.Parse(Console.ReadLine());
                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format.Enter a valid type number: ");

                }
            } 

            
            number.Verif();

            number.Search();
            Console.Write("Press any button to end the programm...");
            Console.Read();
        }
    }
}
