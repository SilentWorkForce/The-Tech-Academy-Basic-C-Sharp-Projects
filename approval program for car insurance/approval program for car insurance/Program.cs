using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace approval_program_for_car_insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string ageAnswer = Console.ReadLine();
            int ageAnswer1 = Convert.ToInt32(ageAnswer);

            Console.WriteLine("Have you ever had a DUI?");
            string trueOrfalse = Console.ReadLine();
            bool hadDui = Convert.ToBoolean(trueOrfalse);

            Console.WriteLine("How many speeding tickets do you have?");
            string numOftickets = Console.ReadLine();
            int numOftickets1 = Convert.ToInt32(numOftickets);

            Console.WriteLine("Qualified?");
            Console.WriteLine(ageAnswer1 > 15 && hadDui == false && numOftickets1 <= 3);

        }
    }
}
