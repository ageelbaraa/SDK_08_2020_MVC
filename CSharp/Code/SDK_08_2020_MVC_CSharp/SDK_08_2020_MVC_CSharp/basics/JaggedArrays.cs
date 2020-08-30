using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET022019
{
    class JaggedArrays
    {
        static void Main(string[] args)
        {

            // Multi d array : The D dimention arrays is array of D-1 arrays 


            // JAGGED ARRAY 
            // 1
            // 2 , 3
            // 4 ,
            // 7 , 8 , 9 , 10 ,15 , 18

            // 2D array 
            // 1 , 2 , 3
            // 4 , 5 , 6
            // 7 , 8 , 9


            int[,] D2 = new int[3,5];


            // FOR JAGGED

          
          
            Random rand = new Random();
            int[][] D2Jagged = new int[rand.Next(1, 11)][];

            for(int i=0;i<D2Jagged.Length;i++)
                D2Jagged[i] = new int[rand.Next(1, 11)];

            //D2Jagged[0] = new int[1];
            //D2Jagged[1] = new int[2];
            //D2Jagged[2] = new int[3];

            

            Console.WriteLine(D2Jagged.Length);
            Console.WriteLine(D2Jagged.GetLength(0));

            Console.WriteLine();

            Console.WriteLine("++++++++2D JAGGED+++++++++");
            int c = 0;
            for(int d0=0;d0<D2Jagged.Length; d0++)
            {
                for(int d1 = 0;d1< D2Jagged[d0].Length;d1++)
                {
                    D2Jagged[d0][d1] = c++;
                    Console.Write("{0,5},",D2Jagged[d0][d1] );
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n++++++++3D JAGGED+++++++++");
            c = 1;
            int[][][] TDJ = new int[3][][];
            //  int[,,] a = new int[5,4,2];
            int[] index = new int[] { 1, 2, 3, 5, 4 };
            for(int i=0;i<TDJ.Length;i++)
            {
                TDJ[i] = new int[index[i]][];
                for(int j=0;j < TDJ[i].Length;j++)
                {
                    TDJ[i][j] = new int[rand.Next(1, 11)];
                    for(int k=0;k<TDJ[i][j].Length;k++)
                    {
                        TDJ[i][j][k] = c++;
                        Console.Write("{0,5},", TDJ[i][j][k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine( "-----------------------");
            }

            Console.WriteLine("*****************************************");

            // e.g ::
            int cout = 0;
            int[][][] jugdArr = new int[4][][];
            for (int i = 0; i < jugdArr.Length; i++)
            {
                jugdArr[i] = new int[rand.Next(1, 11)][];
                for (int j = 0; j < jugdArr[i].Length; j++)
                {
                    jugdArr[i][j] = new int[rand.Next(1, 11)];
                    for (int k = 0; k < jugdArr[i][j].Length; k++)
                    {
                        jugdArr[i][j][k] = c++;
                        Console.WriteLine($"[{i},{j},{k}] = [{jugdArr[i][j][k]}]");
                    }

                }
            }


            Console.ReadKey();

        }
    }
}
