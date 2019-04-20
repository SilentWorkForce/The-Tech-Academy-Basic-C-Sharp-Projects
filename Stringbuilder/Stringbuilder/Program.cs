using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Christopher";
            string phrase = "Hello and Welcome";
            int age = 32;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("My name is Christopher");

            Console.WriteLine("What is your name?");
            Console.WriteLine(sb);
            Console.WriteLine(phrase + name);
            name = name.ToUpper();
            Console.WriteLine(" May I ask " + name + " How old are you?");
            Console.WriteLine(" I am " + age + " Years old.");

            Console.ReadLine();








        }
    }
}
