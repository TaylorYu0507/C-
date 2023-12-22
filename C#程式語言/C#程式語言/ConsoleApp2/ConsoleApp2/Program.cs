using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //算數運算式
            Console.WriteLine("------整數與整數的算數運算關係------");

            int x = 9;
            int y = 4;
            int z = 0;

            z = x + y; //加
            z = x - y; //減
            z = x * y; //乘
            z = x / y; //除, 去小數
            z = x % y; //餘數
            z = -y + x; //負號變換
            z = x + y * y; //先乘除後加減
            z = (x - y) / y; //小括號優先

            Console.WriteLine($"x的值:{x} y的值:{y} z的值:{z}");

            Console.WriteLine("------整數與浮點數的關係------");
            int x2 = 5;
            double y2 = 1.23456;
            double z2;

            z2 = x2 + y2;
            z2 = x2 * y2;
            z2 = x2 / y2;

            Console.WriteLine($"x2的值:{x2} y2的值:{y2} z2的值:{z2}");

            Console.WriteLine("-------算術指定運算子-------");
            int c = 250;
            int d = 100;

            //c = c + 3;
            //c = c + d;
            //c += 3; // c = c + 3;
            //c -= d; // c = c - d;
            //c *= d; // c = c * d;
            //c /= d; // c = c / d;
            c %= d; // c = c % d;

            Console.WriteLine($"c 的值為:{c}");

            Console.WriteLine("-------遞增遞減運算子-------");
            int r = 8;

            r = r + 1;
            r += 1;
            r++;

            r = r - 1;
            r -= 1;
            r--;
            Console.WriteLine($"r 的值為:{r}");

            Console.WriteLine("-------關係運算式--------");
            int m = 85;
            int n = 45;
            bool compare; //關係運算結果

            compare = m == n; //false
            compare = m != n; //true
            compare = m > n; //true
            compare = m >= n; //true
            compare = m < n; //false
            compare = m <= n; //false

            Console.WriteLine($"compare結果是:{compare}");

            Console.WriteLine("-------複合關係運算式--------");
            int p = 57;
            int w = 92;
            bool logic;

            logic = (p < w) && (p >= 50); //AND, true
            logic = (p > 60) && (p != w); //false
            logic = (w <= 80) || (p <= w); //OR, true
            logic = (p > w) || (w < 20); //false
            logic = (p > 40) && (w < 120) && (p == w); //false
            logic = (p < 30) || (w > 100) || (p != w); //true
            logic = (p > 30) || (w < 50) && (p < w); //先AND後OR
            logic = (p > 20) || (w > 76) && (p >= w); //true
            logic = ((p > 20) || (w > 76)) && (p >= w); //小括號先行, false
            logic = !(p >= w); //!否定結果

            Console.WriteLine($"logic結果是:{logic}");


            Console.ReadKey();
        }
    }
}
