using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {

            //ask user for number

            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();

            //Log the text

            using (StreamWriter file = new StreamWriter(@"C:\Users\Sample.txt"))
            {
                file.Write(input);
            }

            //print the text back

            using (StreamReader file = new StreamReader("Sample.txt"))
            {
                Console.WriteLine("File contents: ");
                Console.WriteLine(file.ReadToEnd());
            }

            Console.Read();

        }
    }
}
