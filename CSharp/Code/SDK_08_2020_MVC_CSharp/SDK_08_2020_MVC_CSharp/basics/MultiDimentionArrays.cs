using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET022019
{
    class MultiDimentionArrays
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //dataType[] NameOfArray = new dataType[size] {...}
            // dataType[,] NameOfArray = {{...},{...}} ;
            // dataType[,] NameOfArray = new dataType[][size of row] {{...},{...} ...};

            // { { "ali", "ahmad", "abod", "azzam", "bera" }, { "jon", "mic", "loo", "sami", "kail" } };

            // Console.WriteLine($"[{i},{j}] = [{Names[i, j]}]");
            string[,] Names = new string[2, 5];

            for (int i = 0; i < Names.GetLength(0); i++)
            {
                for (int j = 0; j < Names.GetLength(1); j++)
                {
                    Names[i, j] = rand.Next(0, 101).ToString();
                    Console.WriteLine($"[{i},{j}] = [{Names[i, j]}]");
                }
            }


            Console.WriteLine("***************************");





            // Multi dementiona array with N d array : The Nth dimention arrays is array of Nth-1 arrays 
            

            Console.WriteLine("=========1D================");
            int[] singleDArray = new int[10];
            int[] singleDArray1 = { 1, 2, 3, 4, 5 };
            for (int d0 = 0; d0 < singleDArray1.Length; d0++)
                Console.Write("{0,4},", singleDArray1[d0]);
            // {0:n4}

            Console.WriteLine();

            Console.WriteLine("=========2D================");
            //// Two dimention 
            int[,] TwoDArray = new int[3, 5];
            int[,] TwoDArray1 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };


            for (int d0 = 0; d0 < TwoDArray.GetLength(0); d0++)      // rows 
            {
                for (int d1 = 0; d1 < TwoDArray.GetLength(1); d1++)    // columns
                {
                    TwoDArray[d0, d1] = rand.Next(35, 101);
                    Console.Write("{0,4},", TwoDArray[d0, d1]);
                }
                Console.WriteLine();

            }

            Console.WriteLine("=========3D================");

          // 
            int[,,] ThreeDArray = new int[3, 5,4];
            int[,,] ThreeDArray1 = { { { 1,2,3}, {4,5,6 }, { 7,8,9} }, { {10,11,12}, {13,14,15 } , { 16,17,18} },{ {19,20,21 }, {22,23,24 }, { 25,26,27} } };

            for (int d0 = 0; d0 < ThreeDArray.GetLength(0); d0++)      // rows 
            {
                for (int d1 = 0; d1 < ThreeDArray.GetLength(1); d1++)    // columns
                {
                    for (int d2 = 0; d2 < ThreeDArray.GetLength(2); d2++)    // depth
                    {
                        ThreeDArray[d0, d1, d2] = rand.Next(35,101);
                        Console.WriteLine($"[{d0},{d1},{d2}] = [{ThreeDArray[d0, d1,d2]}]");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("=========================");


            }

            Console.ReadKey();
            int[,,,] FourDArray = new int[2, 3, 2,4];
            int[,,,,] FiveDArray = new int[3, 2, 2,1,3];

           //  int[,,,,,,,,] temp = new int[24,60,60,10,10,10,30,12,10];
        }
    }
}
