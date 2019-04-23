using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab117
{
    class Program
    {
        static void Main(string[] args)
        {

            //user enter a number. Call the method on that number. 
            //Display the output to the screen. It should be the entered number, divided by two.

            Console.WriteLine("Input number to be divided by 2, then passed out via the parameter: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int one, two, output;

            MyClass myClass = new MyClass();
            myClass.outInt(out output, input);
            Console.WriteLine("number after divide: " + output);
            Console.WriteLine("enter two int values on the two lines: ");
            myClass.assignValues(out one, out two);
            Console.WriteLine("assigned values plus addition: " + one + ", " + two);

            Console.WriteLine(MyStaticClass.check());
            Console.Read();
            
       
        

        


        }
    }
}
