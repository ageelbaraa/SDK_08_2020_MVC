using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP012019
{
    class Loops
    {
        static void Main(string[] args)
        {

            //short a = 0;
            ////while (a < 10) 
            ////{
            ////    Console.WriteLine("Loopping..." + a);
            ////    a--;
            ////}

            ////Console.WriteLine("Finally a:"+a);
            //int d = 2, m = 3;

            //for(Console.WriteLine("A"), Console.WriteLine("A1")  , a = 10; ; Console.WriteLine("C"),d++, m +=3)
            //{
            //     Console.WriteLine("for");
            //}

            //Console.WriteLine("A");
            //Console.WriteLine("A1");
            //a = 11;
            //while(a % 2 != 0)
            //{
            //    a += 2;
            //    Console.WriteLine("for");

            //    Console.WriteLine("C"); d++; m += 3;
            //}

            //d = 10;
            //while(d > 10)
            //{
            //    Console.WriteLine("Done");
            //    d--;
            //}



            //for (;;)
            //    Console.WriteLine();

            int i = 0, j = 0;
            for (; i < 10; i++)
            {
                j = i;

                while (j > 0)
                    Console.WriteLine("I:{0}, J:{1}", i, j--);
            }
           
               

            Console.ReadKey();
        }
    }
}
