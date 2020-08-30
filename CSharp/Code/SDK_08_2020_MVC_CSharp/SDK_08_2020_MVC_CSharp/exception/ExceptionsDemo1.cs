using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ASP012019.exceptions
{
    class ExceptionsDemo1
    {
        public static int Divide(int a, int b)
        {
            int result;
            result = a / b;

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="FormatException"></exception>
        /// <exception cref="OverflowException"></exception>
        /// <exception cref="IOException"></exception>
        /// <exception cref="OutOfMemoryException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static int Test()
        {
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int d = Test();
            //try
            //{
            //    Console.WriteLine("{0}/{1} = {2}", 10, 2 , Divide(10, 2));
            //    Console.WriteLine("{0}/{1} = {2}", 0 , 10, Divide(0, 10));
            //    Console.WriteLine("{0}/{1} = {2}", 10, 0 , Divide(10, 0));
            //    Console.WriteLine("All cases done");

            //}

            ////catch (DivideByZeroException ex)
            ////{

            ////}
            ////catch (IndexOutOfRangeException ex)
            ////{

            ////}
            //catch (Exception e)
            //{
            //    if (e is DivideByZeroException || e is IndexOutOfRangeException)
            //        Console.WriteLine("Divide By Zero");
            //    else if (e is ArithmeticException)
            //        Console.WriteLine("ArithmeticException");
            //    else
            //        Console.WriteLine("Other Exception :" + e.StackTrace);

            //    Console.WriteLine(e.StackTrace);

            //}

            int x = 0, y = 0;
            bool con = false;
            bool filled = false;
            do
            {
                try
                {
                    if (!filled)
                    {
                        Console.Write("\rX:");                              // 1
                        x = int.Parse(Console.ReadLine());                  // 6
                        filled = true;
                    }
                    Console.Write("Y:");                                    // 1
                    y = int.Parse(Console.ReadLine());                      // 6
                    filled = false;
                    Console.WriteLine("{0}/{1} = {2}", x, y, Divide(x, y));  // 1 
                }
                catch (DivideByZeroException dx)
                {
                    Console.WriteLine(dx.Message);
                    Console.WriteLine("{0}/{1} = \u221E", x, y);
                }
                catch (FormatException ex)
                {
                    //Console.WriteLine(ex.Message);
                    Console.WriteLine("Invalid {0} value, please try again:", (filled ? "Y" : "X"));
                    continue;
                }
                catch (Exception e)
                {
                    if (e is ArgumentNullException || e is OverflowException)
                        Console.WriteLine("ArgumentNullException or  OverflowException " + e.Message);
                    else
                        Console.WriteLine("Some error " + e.Message);
                }


                Console.WriteLine("Press any key to continue or  Esc to exit");
                con = Console.ReadKey().Key.Equals(ConsoleKey.Escape);
            } while (!con);


            Console.WriteLine("\rThanks");
            Console.ReadKey();

        }
    }
}
