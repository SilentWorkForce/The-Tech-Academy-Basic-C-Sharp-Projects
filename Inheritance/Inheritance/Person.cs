using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Person
    {
        //Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName.

        string FirstName;
        string LastName;

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }

        //Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: "Name: [full name]".

        public void SayName()
        {

            Console.WriteLine("Name: " + "[" + FirstName + " " + LastName + "]");


        }

   



    }

}
