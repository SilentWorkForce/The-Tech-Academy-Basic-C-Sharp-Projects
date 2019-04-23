using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
//The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.

namespace classMethod
{
    class MyMethod
    {
        static public int addTwo(int input)
        {
            return input + 2;
        }

        static public int subTwo(int input)
        {
            return input - 2;
        }

        static public int divTwo(int input)
        {
            return input / 2;
        }

    }
}
