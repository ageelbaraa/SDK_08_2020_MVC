using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP012019
{
    class StringFormating
    {
        static void Main(string[] args)
        {
            int value1 = 15, value2 = 125, value3 = 54875;
            Console.WriteLine("Price 1:"+ value1+ " JD");
            Console.WriteLine("Price 2:" + value2 + " JD");
            Console.WriteLine("Price 3:" + value3 + " JD");

            Console.WriteLine("------------------");
            Console.WriteLine("Price 1:{0} JD",value1);
            Console.WriteLine("Price 2:{0} JD", value2);
            Console.WriteLine("Price 3:{0} JD", value3);

            Console.WriteLine("------------------");
            Console.WriteLine("Price 1:{0,6} {1}.", value1,"JOD");
            Console.WriteLine("Price 2:{0,6} {1}.", value2,"$");
            Console.WriteLine("Price 3:{0,6} {1}.", value3,"#");

            Console.WriteLine("------------------");
            Console.WriteLine("Price 1:{0,6} {1,3}.", value1, "JOD");
            Console.WriteLine("Price 2:{0,6} {1,3}.", value2, "$");
            Console.WriteLine("Price 3:{0,6} {1,3}.", value3, "#");

            Console.WriteLine("------------------");
            Console.WriteLine("Price 1:{0,-6} {1,3}.", value1, "JOD");
            Console.WriteLine("Price 2:{0,-6} {1,3}.", value2, "$");
            Console.WriteLine("Price 3:{0,-6} {1,3}.", value3, "#");


            double price1 = 125.325, price2 = 254.6554, price3 = 1542.65455;

            Console.WriteLine("------------------");
            Console.WriteLine("Price 1:{0:00000.00} {1,3}.", price1, "JOD");
            Console.WriteLine("Price 2:{0:00000.00} {1,3}.", price2, "$");
            Console.WriteLine("Price 3:{0:00000.00} {1,3}.", price3, "#");


            Console.WriteLine("In this {0,10} the first {1,10} was {2,10}.","year","day","Sunday");
            //Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 0", a >> 0, string.Format("{0,32}", Convert.ToString(a >> 0, 2)).Replace(" ", "0"));
            Console.WriteLine("{0,10} -> {1}" ,value1, string.Format("{0,32}", Convert.ToString(value1, 2)).Replace(" ", "0"));
            Console.WriteLine("{0,10} -> {1}", value2, string.Format("{0,32}", Convert.ToString(value2, 2)).Replace(" ", "0"));
            Console.WriteLine("{0,10} -> {1}", value3, string.Format("{0,32}", Convert.ToString(value3, 2)).Replace(" ", "0"));

        
           

            Console.ReadKey();
        }
    }
}
