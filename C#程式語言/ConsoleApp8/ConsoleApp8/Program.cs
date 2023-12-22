using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* 二維陣列 Two Dimension Array *********");
            int[,] array2Dim_One = new int[4, 2];

            array2Dim_One[0, 0] = 1;
            array2Dim_One[0, 1] = 2;
            array2Dim_One[1, 0] = 3;
            array2Dim_One[1, 1] = 4;
            array2Dim_One[2, 0] = 5;
            array2Dim_One[2, 1] = 6;
            array2Dim_One[3, 0] = 7;
            array2Dim_One[3, 1] = 8;

            for (int i = 0; i <= array2Dim_One.GetUpperBound(0); i += 1)
            {
                for (int j = 0; j <= array2Dim_One.GetUpperBound(1); j += 1)
                {
                    Console.WriteLine($"array2Dim_One[{i},{j}] = {array2Dim_One[i,j]}");
                }
            }

            Console.WriteLine("----------------------------------------------");

            int[,] array2Dim_Two = { { 401, 402} , { 301, 302 }, { 201, 202 }, { 101, 102 } };

            //Exe: 輸出 4 rows x 2 columns 排列

            Console.WriteLine("\nC# Hotel");

            Console.WriteLine("\n=============");

            for (int i = 0; i <= array2Dim_Two.GetUpperBound(0); i += 1)
            {
                Console.Write("|");
                for (int j = 0; j <= array2Dim_Two.GetUpperBound(1); j += 1)
                {
                    Console.Write($" {array2Dim_Two[i, j]} |");
                }
                Console.WriteLine("\n-------------");
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(array2Dim_Two[1,1]); //302
            Console.WriteLine(array2Dim_Two[0,1]); //402
            Console.WriteLine(array2Dim_Two[3,1]); //102
            Console.WriteLine(array2Dim_Two[2,0]); //201
            Console.WriteLine(array2Dim_Two[2,1]); //202

            //Exe: 6 Rows x 4 columns
            int[,] array2Dim_Three = new int[6, 4];

            Console.WriteLine("********* 三維陣列 Three Dimension Array *********");
            int[,,] array3D_One = new int[2, 3, 4] {
                {
                    { 1,2,3,4},
                    { 5,6,7,8},
                    { 9,10,11,12}
                },
                {
                    { 13,14,15,16},
                    { 17,18,19,20},
                    { 21,22,23,24}
                }
            };

            //exe: 輸出 array3D_One 陣列內容
            for (int i = 0; i <= array3D_One.GetUpperBound(0); i += 1)
            {
                for (int j = 0; j <= array3D_One.GetUpperBound(1); j += 1)
                {
                    for (int k = 0; k <= array3D_One.GetUpperBound(2); k += 1)
                    {
                        Console.WriteLine($"array3D_One[{i},{j},{k}] = {array3D_One[i, j, k]}");
                    }
                }
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"{array3D_One[1, 0, 2]}");
            Console.WriteLine($"{array3D_One[0, 1, 2]}");
            Console.WriteLine($"{array3D_One[1, 2, 2]}");
            Console.WriteLine($"{array3D_One[0, 2, 3]}");

            Console.ReadKey();







        }
    }
}
