using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOPs
{
    class Exceptions
    {
        static int divide(int a, int b)
        {
            int temp = 0;
            try
            {
                temp = a / b;
                return temp;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            using (StreamWriter write = new StreamWriter(@"records.txt", true))
            {
                do
                {
                    try
                    {
                        Console.Write("X:");
                        x = int.Parse(Console.ReadLine());
                        Console.Write("Y:");
                        y = int.Parse(Console.ReadLine());
                        Console.WriteLine("{0}/{1} = {2}", x, y, divide(x, y));
                        write.WriteLine("{3}:{0,5}/{1,5} = {2,5}", x, y, divide(x, y), DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                        write.Flush();      // force the writer to write directly to the file
                    }
                    catch (Exception e)
                    {
                        //Log(e);
                        if (e is DivideByZeroException)
                        {
                            Console.WriteLine("Error:" + e.Message);
                            Console.WriteLine("{0}/{1} = \u221E", x, y);
                            write.WriteLine("{2}:{0}/{1} = \u221E", x, y, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                            write.Flush();
                        }
                        else if (e is ArithmeticException || e is ArgumentOutOfRangeException || e is System.IO.IOException || e is OutOfMemoryException)
                        {
                            Console.WriteLine("First exception:" + e.Message);
                            write.WriteLine("{0}:First exception{1} ", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), e.Message);
                            write.Flush();
                            //throw new ArgumentException();
                        }

                        else if (e is ArgumentNullException || e is FormatException || e is OverflowException)
                        {
                            Console.WriteLine("Second exception:" + e.Message);
                            write.WriteLine("{0}:Second exception{1} ", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), e.Message);
                            write.Flush();
                        }
                        else
                        {
                            Console.WriteLine("Other exception:" + e.Message);
                            write.WriteLine("{0}:Other exception{1} ", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), e.Message);
                            write.Flush();
                        }
                           
                    }

                    Console.WriteLine("Press any key to continue or ESC to exit.");
                } while (!Console.ReadKey().Key.Equals(ConsoleKey.Escape));

            }
            Console.WriteLine("Thank you!");
            Console.ReadKey();

        }
        private static void Log(Exception e)
        {
            // TODO: save tje error in log file

            using (StreamWriter writer = new StreamWriter("log.log", true))
            {
                writer.WriteLine("Error:{0} - @{1}", e.Message, DateTime.Now.ToString());
                writer.WriteLine(e.StackTrace);
            }

        }
    }
}
