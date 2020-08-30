using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP012019.exceptions
{
    class Person : IDisposable
    {
        public string Name;
        private int Age;


        /// <summary>
        /// This method do d
        /// </summary>
        /// <param name="a"> the age value</param>
        /// <param name="B"> the age value</param>
        /// <exception cref="ArgumentOutOfRangeException" > If age value is out of range [1,150]</exception>
        public void SetAge(int a)
        {
            if (a > 0 && a < 150)
                Age = a;
            else
              throw new ArgumentOutOfRangeException("Invalid age value, age must be between 1 and 150.");
        }

        /// <summary>
        /// Return the age integer  value.
        /// </summary>
        /// <returns></returns>
        public int GetAge() { return Age; }
        public override string ToString()
        {
            return string.Format("Person [Name:{0}, Age:{1}]",Name, Age);
        }

        /// <summary>
        /// What to do 
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    class ExceptionsDemo3
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Ahmed";
            p.SetAge(10);

            //p.Age = -36;
           // p.SetAge(-36);
            try
            {
                p.SetAge(-36);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
          
            //p.Age = -36;

            Console.WriteLine("Person age:"+p.GetAge());

            Console.WriteLine(p);

            Console.ReadKey();

        }
    }
}
