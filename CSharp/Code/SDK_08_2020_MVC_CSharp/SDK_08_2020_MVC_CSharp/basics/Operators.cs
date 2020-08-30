using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP012019
{
    class Operators
    {
        static void Main(string[] args)
        {
            // ++ , --, (-), (+)
            // * , + , -, / ,% , 
            // > , < , == , != , <= , >=
            // = , += , *= , /+ , %= ,-= 
            // &&, || , !

            //  &, |, ^, ~ , << , >> , ? : 


            int a = 10, b ;

            Console.WriteLine(a++);     // 10

            Console.WriteLine(a);       // 11 
            Console.WriteLine(++a);     // 12
            Console.WriteLine(a--);     // 12
            Console.WriteLine(a);       // 11 
            Console.WriteLine(--a);     // 10


            a += 5; // a = a+ 5 ;

            Console.WriteLine(a);

            a = 10;
            a *= 5 + 2;     // ? 52 , 70     a = a * (5 + 2) ;

            Console.WriteLine(a);
            // Error Console.WriteLine(10  && 5);
            Console.WriteLine(10> 0 && 2< 5);
            Console.WriteLine(10 > 0 || 2 < 5);
            Console.WriteLine(! (2 < 5));

            a = 2;
            b = 3;
            int c = 3 * a + b * 2 * (a + b) / 3;
            // a = 2 , b = 3
            // c = 16;

            Console.WriteLine("First c:"+c);

            c = 3 * ++a + ++b * 2 * (++a + ++b) / 3;
            // a = 4 , b = 5
            // c = 33
            Console.WriteLine("Second c:" + c);


            // Bitwise Operators & , | , ^          (boolean/Integer)

            Console.WriteLine(10  & 7);     // 2
            //          1010
            //          0111
            //          0010   = 2    

            Console.WriteLine(10 | 7);     // 15
            //          1010
            //          0111
            //          1111   = 15   
            Console.WriteLine(10 ^ 7);     // 13
            //          1010
            //          0111
            //          1101   = 13   

            a = 10;
            Console.WriteLine(a < 5 && a++ > 2);        // false 
            Console.WriteLine("a :"+a );                // 11

            a = 10;
            Console.WriteLine(a < 5 & a++ > 2);         // false
            Console.WriteLine("a :" + a);               // 11

            decimal d = 125.3254M;
            int a1 =(int) d;
            decimal a2 = d - a1;        // 0.812445
            Console.WriteLine("D :" + d);
            Console.WriteLine("A1:"+ a1);
            Console.WriteLine("A2:" + a2);
            int a3 = Convert.ToInt32(a2.ToString().Substring(2));
            Console.WriteLine("A3:" + a3);



            //  &, |, ^, ~ , << , >> , ? : 

            a = 10;
            Console.WriteLine("Operator ~ ");
            Console.WriteLine(" a:{0,4}:{1} ",a,string.Format("{0,32}",Convert.ToString(a,2)).Replace(" ","0"));          // 10
            Console.WriteLine("~a:{0,4}:{1} ", a, string.Format("{0,32}", Convert.ToString(~a, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine("Operator << (shift left)");  
            // 00000101000

            // a << x == a * 2^x (2 power x)
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a << 0", a << 0, string.Format("{0,32}", Convert.ToString(a << 0, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a << 1", a << 1, string.Format("{0,32}", Convert.ToString(a << 1, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a << 2", a << 2, string.Format("{0,32}", Convert.ToString(a <<2, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a << 3", a << 3, string.Format("{0,32}", Convert.ToString(a << 3, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a << 5", a << 5, string.Format("{0,32}", Convert.ToString(a << 5, 2)).Replace(" ", "0"));          // 10

            Console.WriteLine("Operator >> (shift right)");
            // 00000101000

            // a >> x == a / 2^x (2 power x)
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 0", a >> 0, string.Format("{0,32}", Convert.ToString(a >> 0, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 1", a >> 1, string.Format("{0,32}", Convert.ToString(a >> 1, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 2", a >> 2, string.Format("{0,32}", Convert.ToString(a >> 2, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 3", a >> 3, string.Format("{0,32}", Convert.ToString(a >> 3, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 5", a >> 5, string.Format("{0,32}", Convert.ToString(a >> 5, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 30", a >> 30, string.Format("{0,32}", Convert.ToString(a >> 30, 2)).Replace(" ", "0"));          // 10

            // 00000101

            Console.WriteLine("For nigative values ");
            a = -10;

            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a << 0", a << 0, string.Format("{0,32}", Convert.ToString(a << 0, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a << 1", a << 1, string.Format("{0,32}", Convert.ToString(a << 1, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a << 2", a << 2, string.Format("{0,32}", Convert.ToString(a << 2, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a << 3", a << 3, string.Format("{0,32}", Convert.ToString(a << 3, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a << 5", a << 5, string.Format("{0,32}", Convert.ToString(a << 5, 2)).Replace(" ", "0"));          // 10

          
            // 00000101000

            // a >> x == a / 2^x (2 power x)
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 0", a >> 0, string.Format("{0,32}", Convert.ToString(a >> 0, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 1", a >> 1, string.Format("{0,32}", Convert.ToString(a >> 1, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 2", a >> 2, string.Format("{0,32}", Convert.ToString(a >> 2, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 3", a >> 3, string.Format("{0,32}", Convert.ToString(a >> 3, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 5", a >> 5, string.Format("{0,32}", Convert.ToString(a >> 5, 2)).Replace(" ", "0"));          // 10
            Console.WriteLine(" {0,10}:{1,4} -> = {2} ", "a >> 30", a >> 30, string.Format("{0,32}", Convert.ToString(a >> 30, 2)).Replace(" ", "0"));          // 10


            Console.ReadKey();
        }
    }
}
