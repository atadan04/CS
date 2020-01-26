using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw;
            string fileName = "";
            while (true)
            {
                Console.WriteLine("Enter the path to the file(press Enter to end the program): ");
                try
                {
                    fileName = Console.ReadLine();
                    if (fileName.Length == 0)
                    {
                        break;
                    }
                    sw = GetFile(fileName);
                    WriteFileFromConsole(sw);
                    sw.Close();
                    sw = null;
                }
                catch (IOException ioError)
                {
                    string dir = Directory.GetCurrentDirectory();
                    string path = Path.Combine(dir, fileName);
                    Console.WriteLine($"An error occurred on the file path: { path}");
                    Console.WriteLine(ioError.Message);
                }
            }

        }

        private static void WriteFileFromConsole(StreamWriter sw)
        {
            Console.WriteLine("Enter text(Empty line to end the program) :");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.Length == 0)
                {
                    break;
                }
                sw.WriteLine(input);
            }
        }

        private static StreamWriter GetFile(string fileName)
        {
            StreamWriter sw;
            FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs, Encoding.UTF8);
            return sw;
        }
    }
    
}
