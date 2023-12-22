using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if ... else ... 條件判斷式
            int x = 120;
            int y = 120;

            if (x > y) 
            { //true
                Console.WriteLine("x 大於 y");
            }
            else
            { //false
                Console.WriteLine("x 小於等於 y");
            }

            Console.WriteLine("-----------------------------------");

            if (x > y)
            {
                Console.WriteLine("x 大於 y");
            }
            else
            {
                if (x == y)
                {
                    Console.WriteLine("x 等於 y");
                }
                else 
                {
                    Console.WriteLine("x 小於 y");
                }
            }

            Console.WriteLine("-----------------------------------");
            //else if

            if (x > y)
            {
                Console.WriteLine("x 大於 y");
            } 
            else if (x < y)
            {
                Console.WriteLine("x 小於 y");
            }
            else if (x == y)
            {
                Console.WriteLine("x 等於 y");
            }
            else
            {
                //不會執行
            }
            Console.WriteLine("-----------------------------------");
            //條件判斷式 - 簡式

            int w = 8;
            int s;

            if (w < 0)
            {
                s = -1;
            }
            else
            {
                s = w * 2;
            }

            Console.WriteLine($"s值為:{s}");

            s = (w < 0) ? -1 : (w * 2);

            Console.WriteLine($"簡式 s值為:{s}");

            Console.ReadKey();

            //自我練習:
            //用條件判斷式, 寫出任意三數比大小的結果
            int a = 100;
            int b = 1;
            int c = 12;
            // 結果輸出, 從小到大排列, 1 , 12 ,100

        }
    }
}
