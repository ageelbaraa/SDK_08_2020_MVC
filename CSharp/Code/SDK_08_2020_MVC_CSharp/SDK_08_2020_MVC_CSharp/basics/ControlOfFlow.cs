using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET022019
{
    class ControlOfFlow
    {
        /// 1) if statement
        ///    Syntax: 
        ///            if(<boolean_expression>)
        ///                <statement;> | <{[statement]*}>
        ///                [else   <statement;> | <{[statement]*}> ]
        /// 2) switch
        ///     syntax:  
        ///             switch(<switch_expression>)
        ///             {
        ///               [case <unique_constant_value>:
        ///                 [<statement>]* 
        ///               ]*
        ///             
        ///               [default: [<statement>]* ]
        ///            }
        /// 3) conditional operator (ternary operator) if-else-then
        ///     syntax :    
        ///        <boolean_expression> ? <value_if_true> : <value_if_false>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int a;
            Console.Write("Please enter a value:");
            int.TryParse(Console.ReadLine(), out a);


            //if (a > 0)
            //{
            //    a--;
            //    Console.WriteLine(a + " is a postive value");

            //}
            //else
            //{
            //    a++;
            //    Console.WriteLine(a + " is a negative value");
            //}


            //int.TryParse(Console.ReadLine(), out a);
            //// 10


            //if (a % 2 == 0 )
            //    Console.WriteLine("Even");
            //else
            //    Console.WriteLine("Odd");


            //a = 19;
            //if (a % 4 == 0)

            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            //Console.WriteLine("Done");


            //
            const int c = 2;
            int m = 4;
            double d = 2;
            a = 5;
            switch (a)
            {
                default:
                    Console.WriteLine("Default");
                    break;
                case -9:
                // Error case m: // m is not a constant
                case c + 3:           // constant c + 3 is a constant
                case c * -2:       // constant c + 3 is a constant
                    Console.WriteLine("First");
                    break;
                case 3:
                    Console.WriteLine("Second");
                    break;
            }

            Console.Write("Enter your mark:");
            int mark;
            int.TryParse(Console.ReadLine(), out mark);

            if (mark < 35 || mark > 100)
                Console.WriteLine("Error");
            else
            {
                if (mark < 50)
                    Console.WriteLine("Failed");
                else
                {
                    if (mark < 68)
                        Console.WriteLine("Passed");
                    else
                    {
                        if (mark < 76)
                            Console.WriteLine("Good");
                        else
                        {
                            if (mark < 84)
                                Console.WriteLine("Very Good");
                            else
                                Console.WriteLine("Excellent");
                        }
                    }
                }
            }

            Console.WriteLine(mark < 35 || mark > 100 ? "Error" : mark < 50 ? "Failed" : mark < 68 ? "Passed" : mark < .6 ? "Good" : mark < 84 ? "Very Good" : "Excellent");

            Console.Write("Please enter a value:");
            int.TryParse(Console.ReadLine(), out a);
            int abs;
            if (a < 0)
                abs = -a;
            else
                abs = a;

            Console.WriteLine("The |a|:" + abs);

            // Error a < 0 ? -a : a;
            abs = a < 0 ? -a : a;
            Console.WriteLine("The |a|:" + abs);

            // Error : a < 0 ? Console.WriteLine(-a) : Console.WriteLine(a);

            Console.WriteLine("The |a|:" + (a < 0 ? -a : a));

            Console.ReadKey();

        }
    }
}
