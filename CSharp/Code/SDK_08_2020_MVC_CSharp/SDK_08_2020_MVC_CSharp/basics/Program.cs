using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP012019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello world");       // cout<<"Hello"<<endl;
            Console.WriteLine(", Welcome to C# class");
            Console.WriteLine(10+ 15+ 3);       // 28
            Console.WriteLine("10" + 15 + 3);   // 10153
            Console.WriteLine("10" + (15 + 3)); // 1018
            Console.WriteLine(10 + "15" + 3);   // 10153
            Console.WriteLine(10 + 15 + "3");   // 253
            Console.WriteLine(15.325);


            Console.ReadKey();
        }
    }
}
