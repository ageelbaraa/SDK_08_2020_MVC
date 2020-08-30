using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP012019
{
    class Convertion
    {
        /* Implicit type conversion // بالرضا
         *  − These conversions are performed by C# in a type-safe manner. For example, are conversions from smaller to larger integral types and conversions from derived classes to base classes.

            Explicit type conversion  // بالاكراه
            − These conversions are done explicitly by users using the pre-defined functions.Explicit conversions require a cast operator.
         */
        static void Main(string[] args)
        {
            int i = 1545058;
            short s = 50;
            //i = s;      // if the variable from the same type and the right side is equal or smaller the the left
            Console.WriteLine("I :" + i);
            s = (short)i;     // casting 
            Console.WriteLine("S :"+ s );
            //s = Convert.ToInt16(i);
            Console.WriteLine("S :" + s);

            float f = 10;

            Console.ReadKey();

        }
    }
}
