using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1;

            //Console.Write("input first number to mulitply:");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //int result = num1 * 50;
            //Console.WriteLine(result);

            //Console.WriteLine("Enter First Number");
            //int firstnumber = int.Parse(Console.ReadLine());
            //int product = firstnumber * 50;
            //Console.WriteLine("Product of {} * {} is {}", firstnumber, product);
            //Console.ReadLine();

            Console.WriteLine("Enter first number: ");
            int x = Int32.Parse(Console.ReadLine());
            int y = 50;
            Console.Write("Result: " + x * y);
            Console.ReadLine();
            
            Console.WriteLine("Enter second number: ");
            int m = Int32.Parse(Console.ReadLine());
            int n = 25;
            Console.Write("Result: " + m + n);
            Console.ReadLine();

            Console.WriteLine("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());
            double d = 12.5;
            Console.Write("Result: " + c / d);
            Console.ReadLine();

            Console.WriteLine();
            bool trueOrFalse = 0 > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            int remainder = 10 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();


        }
    }
}
