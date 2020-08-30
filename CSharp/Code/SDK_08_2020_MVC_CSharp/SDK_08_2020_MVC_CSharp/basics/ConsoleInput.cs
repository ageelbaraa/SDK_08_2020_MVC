using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET022019
{
    class ConsoleInput
    {
        static void Main(string[] args)
        {
            int age;
            Console.Write("What is your age:");
            //age = Console.Read();
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is :"+age);

            Console.Write("What is your age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is :" + age);

            Console.Write("What is your age:");
            int.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Your age is :" + age);


            Console.ReadKey();
        }
    }
}
