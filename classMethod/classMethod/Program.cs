using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user what number they want to do the math operations on.
            Console.WriteLine("What number would you like to perfrom calculations on?");
            int input = Convert.ToInt32(Console.ReadLine());

            //Display the returned integer to the screen.
            Console.WriteLine(MyMethod.addTwo(input));
            Console.WriteLine(MyMethod.subTwo(input));
            Console.WriteLine(MyMethod.divTwo(input));

            Console.Read();


        }
    }
}
