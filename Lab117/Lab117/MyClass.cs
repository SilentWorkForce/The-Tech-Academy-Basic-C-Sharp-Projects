using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab117
{
    class MyClass
    {
        public MyClass()
        {
         
        }

        //create a void method that outputs an integer, Have the method divide the data passed to it by 2.

        public void outInt(out int x, int y)
        {
            x = y / 2;
        }

        //Create a method with output parameters.

        public void assignValues(out int x, out int y, int addition = 0)
        {
            x = Convert.ToInt32(Console.ReadLine()) + addition;
            y = Convert.ToInt32(Console.ReadLine()) + addition;
        }

        public void assignValues(out double x, out double y, int addition = 0)
        {
            x = Convert.ToDouble(Console.ReadLine()) + addition;
            y = Convert.ToDouble(Console.ReadLine()) + addition;
        }


    }
}
