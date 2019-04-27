using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Employee : Person
    {

        int Id = 0;



        public Employee(string FirstName, string LastName) : base(FirstName, LastName)
        {

        }


        public override void SayName()
        {
            Console.WriteLine("Name: " + "[" + base.FirstName + " " + base.LastName + "]");
        }

       


    }
}
