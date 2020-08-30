using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET022019
{
    class MinMax
    {
       public int min = int.MaxValue;
        public int max = int.MinValue;
    }
    class Arrays
    {
        static void Main(string[] args)
        {
            // Arrays : set consecutive of memeory locations 

            //int a1, a2 , a3, a4, ...... ,a10, . . . . an;
            // Console.WriteLine(a1);
            int[] arr0;     // this only a variable 
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] arr1 = new int[40];          // create a variable of type array arr1
                                               // points to an array of 100 integer of zero

            // I added this line , can you get it ?
            // Console.WriteLine(arr);          // System.int32[]

            // Console.WriteLine("{"+arr[0]+ ", "+ arr[1] + ", "+ arr[2] + arr[3] + ", " + arr[4] + ", " + arr[5] + "+"}");

            PrintArray(arr);

            //Console.Write("{");
            //for (int index = 0; index < arr.Length; index++)
            //    // Console.Write(arr[index]+(index != arr.Length-1 ?", ":""));
            //    Console.Write(arr[index] + ", ");

            //Console.Write("\b\b} \n");

            int MAX = int.MinValue, MIN = int.MaxValue, SUM = 0, FAILEDCOUNTER = 0;
            Random rand = new Random();
            Console.Write("{");
            for (int index = 0; index < arr1.Length; index++)
            {
                arr1[index] = rand.Next(35, 101);


                SUM += arr1[index];

                if (arr1[index] > MAX)
                    MAX = arr1[index];

                if (arr1[index] < MIN)
                    MIN = arr1[index];

                //  FAILEDCOUNTER += arr1[index] < 50 ? 1 : 0;

                if (arr1[index] < 50)
                    FAILEDCOUNTER++;


                Console.Write(arr1[index] + ", ");
            }

            Console.Write("\b\b} \n");

            Console.WriteLine("The min value:{0}, average: {1} and  max value: {2} ", MIN, (double)SUM / arr1.Length, MAX);
            Console.WriteLine("Failed :{0}/{1} ({3}%) , Passed:{2}/{1} ({4}%)",
                FAILEDCOUNTER,
                arr1.Length,
                arr1.Length - FAILEDCOUNTER,
                100 * (double)FAILEDCOUNTER / arr1.Length,
                100 * (double)(arr1.Length - FAILEDCOUNTER) / arr1.Length);


            int[] result = GetMinMax(arr1);
            Console.WriteLine("The min value:{0}, and  max value: {1} ", result[0], result[1]);
            MinMax res = GetMinMax1(arr1);
            Console.WriteLine("The min value:{0}, and  max value: {1} ", res.min, res.max);

            int m1, m2;

            GetMinMax2(arr1, out m1, out m2);
            Console.WriteLine("The min value:{0}, and  max value: {1} ", m1, m2);

            Console.ReadKey();



        }


         static void PrintArray(int[] arr)
        {
            Console.Write("{");
            for (int index = 0; index < arr.Length; index++)
                // Console.Write(arr[index]+(index != arr.Length-1 ?", ":""));
                Console.Write(arr[index] + ", ");

            Console.Write("\b\b} \n");
        }

        static int GetMax(int[] arr)
        {
            int max = int.MinValue;
           
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            return max;
        }

        static int GetMin(int[] arr)
        {
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            return min;
        }

        static int[] GetMinMax(int[] arr)
        {
            int[] mm = { int.MaxValue, int.MinValue };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < mm[0])
                    mm[0] = arr[i];
                if (arr[i] > mm[1])
                    mm[1] = arr[i];
            }

            return mm;
        }

        
        static MinMax GetMinMax1(int[] arr)
        {
            MinMax mm = new MinMax();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < mm.min)
                    mm.min = arr[i];
                if (arr[i] > mm.max)
                    mm.max = arr[i];
            }

            return mm;
        }

        static void GetMinMax2(int[] arr,out int min, out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
      
        }
    }
}
