using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    class Person
    {

        string FirstName;
        string LastName;

        public Person() : this("Christopher", "Stam") { }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }


        public void SayName()
        {
            Console.WriteLine("Name: " + "[" + FirstName + " " + LastName + "]");

        }



    }
}
