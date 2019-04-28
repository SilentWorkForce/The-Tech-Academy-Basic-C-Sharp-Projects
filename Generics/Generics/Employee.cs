using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Employee<G> : Person
    {
        public int Id = 0;
        public List<G> Things = new List<G>();

        public Employee()
        {

        }
        public void Quit()
        {
            Console.WriteLine("Press enter to exit...");
            Console.Read();
            Environment.Exit(0);

        }

        public override void SayName()
        {
            Console.WriteLine("Name: " + "[" + base.FirstName + " " + base.LastName + "]");
        }
    }
}
