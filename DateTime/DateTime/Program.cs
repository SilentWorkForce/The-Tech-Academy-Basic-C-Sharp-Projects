using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeLab156
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print current date and time
            //Ask the user for a number

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            DateTime now = DateTime.Now;
            DateTime later = now.AddHours(input);
            Console.WriteLine("Time in {0} hours: {1}", input, later.TimeOfDay);
            Console.Read();


        }
    }
}
