using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to package express. Please follow the instructions below.");
            Console.WriteLine("Enter your package's weight:");
            string packageWeight = Console.ReadLine();
            int packWeight = Convert.ToInt32(packageWeight);

            if (packWeight > 50) {
                Console.WriteLine("Package too heavy to be shipped. Have a good day.");
            }

            Console.WriteLine("Enter your package's width:");
            string packageWidth = Console.ReadLine();
            int packWidth = Convert.ToInt32(packageWidth);

            Console.WriteLine("Enter your package's Height:");
            string packageHeight = Console.ReadLine();
            int packHeight = Convert.ToInt32(packageHeight);

            Console.WriteLine("Enter your package's Length:");
            string packageLength = Console.ReadLine();
            int packLength = Convert.ToInt32(packageLength);

            int dimensions = packLength * packHeight * packWidth / 100;

            if (packLength * packHeight * packWidth / 100 > 50)
            {
                Console.WriteLine("package is too big to be shipped.");
            }
            else if (packLength * packHeight * packWidth / 100 <= 50) {
                Console.WriteLine("your estimated total for shipping is: " + "$" + dimensions + " Thank you." );
            }



        }
    }
}
