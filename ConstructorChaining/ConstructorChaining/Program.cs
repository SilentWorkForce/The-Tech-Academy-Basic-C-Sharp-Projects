using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Program
    {
        static void Main(string[] args)
        {

            const string constString = "Constant.";
            Console.WriteLine(constString);
            var num = 5m;
            Console.WriteLine("var num is of type: " + num.GetType());
            var str = "String.";
            Console.WriteLine("var str is of type: " + str.GetType());

            Person person = new Person();
            person.SayName();
            Console.ReadLine();



        }
    }
}
