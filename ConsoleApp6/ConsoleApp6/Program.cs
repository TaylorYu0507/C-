using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //迴圈進階 Loop
            //雙迴圈
            Console.WriteLine("******* 九九乘法表 ********");
            for (int i = 1; i <= 9; i += 1)
            {
                for (int j = 1; j <= 9; j += 1)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
            }
            Console.WriteLine("----------------------------");
            for (int i = 1; i <= 10; i += 1) //Row
            {
                for (int j = 1; j <= 20; j += 1) //Column
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
            for (int i = 1; i <= 20; i += 1)
            {
                for (int j = 1; j <= i; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
            for (int i = 20; i >= 1; i -= 1)
            {
                for (int j = 1; j <= i; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("----------------------------");
            //自行練習:
            //利用雙迴圈輸出以下圖形(菱形), 大小可以用變數來變換高度
            //  *
            // ***
            //*****
            // ***
            //  *
            //------------------------------
            // C#作業加分題(optional):
            // 迴圈畫出星星聖誕樹, [任意輸入高度], 彩色的, 上面鈴鐺(@)等裝飾品,隨機出現
            //   *
            //  *$*
            // **@**
            //*@***@*
            //  ***
            // **@*$
            //*@***@*
            // **@**
            //*@***@*
            //  ***
            //  ***
            //  ***
            Console.ReadKey();
        }
    }
}
