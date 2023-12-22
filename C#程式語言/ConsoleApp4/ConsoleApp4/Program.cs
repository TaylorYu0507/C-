using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch
            string ss = ""; //空字串

            //輸入Console.ReadLine()
            Console.WriteLine("***** 甜點選擇 *****");
            Console.WriteLine("a: 布丁 , b:冰淇淋 , c:奶酪 , d: 雞蛋糕, all: 全包了");
            Console.WriteLine("請輸入甜點代碼, 輸入完成請按Enter");
            ss = Console.ReadLine();

            switch(ss)
            {
                case "a":
                    Console.WriteLine("您選了布丁, 請投入20元");
                    break;
                case "b":
                    Console.WriteLine("您選了冰淇淋, 請投入30元");
                    break;
                case "c":
                    Console.WriteLine("您選了奶酪, 請投入35元");
                    break;
                case "d":
                    Console.WriteLine("您選了雞蛋糕, 請投入40元");
                    break;
                case "all":
                    Console.WriteLine("您選了全包了,有折扣, 請投入120元");
                    break;
                default:
                    Console.WriteLine("無此商品");
                    break;
            }

            Console.ReadKey();
        }
    }
}
