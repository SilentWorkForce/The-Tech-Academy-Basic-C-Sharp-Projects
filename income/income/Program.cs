using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace income
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1, Enter your name.");
            string person1 = Console.ReadLine();

            Console.WriteLine("Enter your hourly rate here.");
            string hourlyRate1 = Console.ReadLine();
            int hrlyRate1 = Convert.ToInt32(hourlyRate1);

            Console.WriteLine("Enter your weekly hours worked.");
            string hoursPerWeek1 = Console.ReadLine();
            int hrsPerWeek1 = Convert.ToInt32(hoursPerWeek1);

            Console.WriteLine("Person 2, Enter your name.");
            string person2 = Console.ReadLine();

            Console.WriteLine("Enter your hourly rate here.");
            string hourlyRate2 = Console.ReadLine();
            int hrlyRate2 = Convert.ToInt32(hourlyRate2);
           
            Console.WriteLine("Enter your weekly hours worked.");
            string hoursPerWeek2 = Console.ReadLine();
            int hrsPerWeek2 = Convert.ToInt32(hoursPerWeek2);

            Console.WriteLine("Annual salary of person 1");
            int weeklySalary1 = hrlyRate1 * hrsPerWeek1;
            int annualSalary1 = weeklySalary1 * 52;
            Console.WriteLine(annualSalary1);

        
            Console.WriteLine("Annual salary of person 2");
            int weeklySalary2 = hrlyRate2 * hrsPerWeek2;
            int annualSalary2 = weeklySalary2 * 52;
            Console.WriteLine(annualSalary2);

            
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = annualSalary1 > annualSalary2;
            Console.WriteLine(trueOrFalse);




        }
    }
}
