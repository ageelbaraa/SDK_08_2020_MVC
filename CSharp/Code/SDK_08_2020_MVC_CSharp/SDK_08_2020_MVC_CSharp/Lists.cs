using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace ASP_10_2019
{
    class Program
    {
        static void Print(List<string> List)
        {
            Console.WriteLine("The cout of your List is : {0}", List.Count);
            foreach (var item in List)
            {
                Console.WriteLine(" >> " + item);
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<string> List1 = new List<string>();

            List1.Add("-- first element --");
            List1.Add("One");
            List1.Add("two");
            List1.Add("three");
            List1.Add("four");

            List1.Insert(3, "two.one");
            List1.Remove("two.one");

            Console.WriteLine("Tis is List 1");

            //List1.ForEach(index => Console.WriteLine(index));
            Print(List1);
            Console.WriteLine("\n");
            //Console.WriteLine(vs.IndexOf("-- first element --"));
            List<string> List2 = new List<string>();
            List2.AddRange(List1);
            List2.Add("5");
            Console.WriteLine("Tis is List 2");

            for (int i = 0; i < List2.Count; i++)
            {
                Console.WriteLine(" >> " + List2[i]);
            }
            Console.WriteLine("\n");
            List<int> List3 = new List<int>() { 2 , 4 , 6 , 8};
            bool[] bb = new bool[List3.Count];
            for (int i = 0; i < List3.Count; i++)
            {
                bb[i] = List3.TrueForAll(e => e % 2 == 0);
                Console.WriteLine("  > " +bb[i]);
            }



            Console.WriteLine("Tis is List 3");
            List3.ForEach(e => Console.WriteLine(e));
            Console.WriteLine("\n");

            List<int> List4 = new List<int>();
            int count = 15;

            for (int i = 0; i < count; i++)
            {
                List4.Add(rand.Next(1, 11));
            }

            List4.ForEach(e => Console.WriteLine("  >>  " + e));

            List<int> List5 = new List<int>();
            int count2 = 5;
            for (int i = 0; i < count2; i++)
            {
                List5.Add(rand.Next(1,51));
            }

            List5.ForEach(e => Console.WriteLine("  > " + e));
            List5.Sort();
            Console.WriteLine("************************************************");
            List5.ForEach(e => Console.WriteLine("  > " + e));

            Console.ReadKey();





        }
    }
}
