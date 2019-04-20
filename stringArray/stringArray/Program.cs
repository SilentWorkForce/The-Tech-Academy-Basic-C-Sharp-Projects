using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = new string[] { "Christopher", "Caroline", "Troy", "Reece" };
            Console.WriteLine("Select an Item from the array using 0-3");
            // assign the user entry to a variable
            string userSelection = Console.ReadLine();
            // convert the string variable to an int so it will pass through the if statement
            int elementSelection = Convert.ToInt32(userSelection);
            // if statement reads the entry and passes back the list selection
            if (elementSelection > 0 && elementSelection <= 3)
            {
                // Select string value using input value
                string stringSelection = nameArray[elementSelection];
                Console.WriteLine("You've chosen the name " + stringSelection);
            }
            else {
                Console.WriteLine("You've chosen an invalid number. Try again.");
            }
            // end string array


            // int array


            int[] intArray = new int[] { 24, 15, 14, 11 };
            Console.WriteLine("Select an item from the array using 0-3");
            // assign the user entry to a variable
            string userSelection2 = Console.ReadLine();
            // convert the string variable to an int so it will pass through the if statement
            int elementSelection2 = Convert.ToInt32(userSelection2);
            // if statement reads the entry and passes back the list selection
            if (elementSelection2 >= 0 && elementSelection2 <= 3)
            {
                // Select string value using input value
                int stringSelection2 = intArray[elementSelection2];
                Console.WriteLine("You've chosen the number " + stringSelection2);
            }
            else
            {
                Console.WriteLine("You've chosen an invalid number. Try again");

            }

            // End int array


            // List/query


            List<string> stringList = new List<string>() { "nvidia", "amd", "intel", "ati", "apple" };

            Console.WriteLine("Select an item from the electronics dept using number 1-4");
            //assign the user entry to a variable
            string userSelection3 = Console.ReadLine();
            // convert the string variable to an int so it will pass through the if statement
            int elementSelection3 = Convert.ToInt32(userSelection3);
            // if statemenet reads the entry and passes back the list selection
            if (elementSelection3 > 0 && elementSelection3 <= 3)
            {
                // pass the int into the block pass back the list selection
                string stringSelection3 = stringList[elementSelection3];
                Console.WriteLine("Don't forget the " + stringSelection3 + "!");
            }
            else {
                Console.WriteLine("You've chosen an invalid number. Try again");

            }


            // End list query




        }
    }
}
