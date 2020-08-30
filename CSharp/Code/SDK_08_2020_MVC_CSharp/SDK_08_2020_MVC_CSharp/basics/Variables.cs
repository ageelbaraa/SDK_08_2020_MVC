using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP012019
{
    class Variables
    {
       
        static void Main(string[] args)
        {
            bool b = true;
            byte by = 255;     // 0 -255        // 1
            sbyte sby = -128;       // -128 to 127

            short sho = -32768;     // -32,768 to 32,767
            ushort usho = 65535;    // 0 - 65,535

            int i = -2147483648; // -2,147,483,648 to 2,147,483,647
            uint ui = 4294967295;   // 0 to 4294967295

            long lng = -9223372036854775808; // -9,223,372,036,854,775,808  to 9,223,372,036,854,775,807 
            ulong ulng = 18446744073709551615; // 0 - 18,446,744,073,709,551,615


            float f = 1.23456789f;
            double d = 1.23456789;
            decimal dec = 1.23456789M;

            Console.WriteLine("F :"+ f);
            Console.WriteLine("D :" + d);
            Console.WriteLine("Dec :" + dec);
            char ch = '5';
            Console.WriteLine( "Ch :"+ch);
            Console.WriteLine("New");

            lng = 10;
            Console.WriteLine("i :"+ lng);       // 10
            lng = 0X10FDL;       // 0X is the start of Hexaedecial
            Console.WriteLine("i :" + lng);       // ??
            lng = '0';
            Console.WriteLine("i :" + lng);       // 48
            lng = 010;
            Console.WriteLine("i :" + lng);

            
            Console.ReadKey();
        }
    }
}
