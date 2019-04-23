using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab115
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            //Ask the user to input two numbers, one at a time.
            //Let them know they need not enter anything for the second number.

            Console.WriteLine("input at least one whole number to be used, The second input used may be blank.");
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            //Call the method in MyClass, passing in the one or two numbers entered.

            int outcome;
            if (String.IsNullOrWhiteSpace(second))
                outcome = myClass.myMethod(Convert.ToInt32(first));
            else
                outcome = myClass.myMethod(Convert.ToInt32(first), Convert.ToInt32(second));

            Console.WriteLine("the value returned from the method W/ optional parameter: " + outcome);
            Console.Read();




        }
    }
}
