using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    class Person1
    {
        public int id;
        public string Name;
        public int Age; 
    }
    class DataAbstraction
    {
        static void Main(string[] args)
        {
            int x;
            Person1 p = new Person1() ;
            p.Age = 10;
            p.id = 1;
            p.Name = "Ali";

            Console.WriteLine("Person [ID:{0}, Name:{1}, Age:{2}]",p.id,p.Name,p.Age);
            Console.ReadKey();

        }
    }
}
