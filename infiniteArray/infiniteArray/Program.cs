using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infiniteArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array and add a users input to the array

            string[] names = new string[5];
            names[0] = "Christopher";
            names[1] = "Reece";
            names[2] = "Caroline";
            names[3] = "Troy";

            Console.WriteLine("Please enter a name:");
            string userEntry = Console.ReadLine();
            names[4] = userEntry;


            //create a loop that cycles through the array with the added user entry

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Press any key to enter infinite loop!");
            Console.ReadLine();

            /*create an infinite loop*/

            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("infinite loop");
            }


            //loop operators

            for (int j = 0; j < 100; j++)
            {
                Console.WriteLine(j);
            }

            Console.ReadLine();

            //List loops

            List<string> parts = new List<string>()
            {"cpu","mobo","ram" };

            Console.WriteLine("Enter text to search in the list");
            string userEntry2 = Console.ReadLine();

            if (userEntry2 != "cpu" && userEntry2 != "mobo" && userEntry2 != "ram")
            {
                Console.WriteLine("Your selection was not found in the list");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {

                foreach (string part in parts)
                {
                    Console.WriteLine(part + " " + parts.IndexOf(part));
                    Console.WriteLine(" ");

                    if (userEntry2 == part)
                    {
                        Console.WriteLine("You've found the " + part + " " + "at index " + parts.IndexOf(part));
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }


            //identical strings list

            List<string> types = new List<string>()
                {"intel","amd","intel","asus" };

            Console.WriteLine("Enter text to search from list");
            string userEntry3 = Console.ReadLine();

            if (userEntry3 != "intel" && userEntry3 != "amd" && userEntry3 != "asus")
            {
                Console.WriteLine("Your selection was not found");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {

                foreach (string type in types)
                {
                    Console.WriteLine(type + " " + types.IndexOf(type));
                    if (userEntry3 == type)
                    {
                        Console.WriteLine("This entry already appears in the list");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
            Console.ReadLine();

            List<string> computers = new List<string>()
            {"msi","alienware","apple","asus","msi" };

            foreach (string computer in computers)
            {
                Console.WriteLine(computer.LastIndexOf("msi"));
                if (computer.IndexOf("msi") == computer.LastIndexOf(computer))
                {
                    Console.WriteLine("This entry already appeared in the list before");
                }
                else
                {
                    Console.WriteLine();

                }
            }
            Console.ReadLine();
        }
    }
}
