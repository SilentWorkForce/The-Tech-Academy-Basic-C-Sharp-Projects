using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//create a method that takes two integers as parameters.Make one of them optional.
//    Have the method do a math operation and return a integer result.


namespace Lab115
{
    class MyClass
    {
        public MyClass()
        {

        }

        public int myMethod(int x, int y = 4)
        {
            return x + y;
        }



    }
}
