using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------- For 迴圈(loop) -------");

            for (int i = 1; i <= 20; i += 1)
            {
                //i = 1...20
                Console.WriteLine($"i的值是 {i}");
            }
            Console.WriteLine("------------------------------");
            //exe: 輸出 2...30 的雙數
            for (int j = 2 ; j < 31; j += 2)
            {
                Console.WriteLine($"j的值是 {j}");
            }
            Console.WriteLine("------------------------------");
            //exe: 輸出 10,9,8,7,6,5,4,3,2,1
            for (int k = 10; k >= 1; k--)
            {
                Console.WriteLine($"k的值是 {k}");
            }
            Console.WriteLine("------------------------------");
            for (int i = 1; i <= 20; i++)
            {
                //1...12, 中斷迴圈
                if (i > 12)
                {
                    break;
                }
                Console.WriteLine($"i的值是 {i}");
            }
            Console.WriteLine("------------------------------");
            for (int i = 1; i <= 20; i++)
            {
                // 跳過 3 , 4 , 11
                if ((i == 3) || (i == 4) || (i == 11))
                {
                    continue;
                }
                Console.WriteLine($"i的值是 {i}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("******* while 迴圈(loop) *******");

            int m = 0;
            while (m < 20)
            {
                m += 1;
                Console.WriteLine($"m的值是 {m}");
            }

            Console.WriteLine("------------------------------");

            int n = 0;
            while (true)
            {
                n += 1;
                Console.WriteLine($"n的值是 {n}");
                if (n >= 100)
                {
                    break;
                }
            }

            Console.WriteLine("------------------------------");

            int gamer_hp = 100;
            bool isLoop = true;

            while (isLoop)
            {
                gamer_hp -= 1;
                Console.WriteLine($"gamer_hp的值是 {gamer_hp}");
                if (gamer_hp <= 0)
                {
                    isLoop = false;
                }
            }

            Console.WriteLine("------------------------------");
            do
            {
                Console.WriteLine("Do...While Loop");
            } while (false);


            Console.ReadKey();
        }
    }
}
