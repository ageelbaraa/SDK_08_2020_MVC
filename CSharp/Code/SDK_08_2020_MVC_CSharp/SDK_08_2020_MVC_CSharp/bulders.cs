using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_10_2019
{
    class bulders
    {
        static void Main(string[] args)
        {
            StringBuilder name = new StringBuilder("musa");
            Console.WriteLine("  >> " + name);
            name.Append(" demir");
            Console.WriteLine("  >> " + name);

            Console.ReadKey();
        }

    }
}
