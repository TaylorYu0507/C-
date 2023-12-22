using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comment 單行註解
            /*
            多行註解 
            1234567890
            abcdefghijk
             */
            //整數 integer
            int a = 10; //int 32位元bit整數
            short amount; //short 16位元bit整數
            amount = 30000;
            long count = 300000000000; //long 64位元bit整數

            uint aa = 100;
            ushort bb = 60000;
            ulong cc = 100000000000;
            //浮點數 float
            float ee = 123.456f;
            double ff = 123456.78901; //預設
            //布林值 boolean
            bool g = true;
            bool gg = false;
            //字元 Character
            char h = 'x';
            char hh = '#';
            char hhh = '微';
            //字串 String
            string i = "Hello World";
            string ii = "C#";
            string iii = "物件導向程式設計";

            Console.WriteLine("Hi, 這是第一個主控台程式");
            Console.WriteLine(i);
            Console.WriteLine(ii);
            Console.WriteLine(iii);
            Console.WriteLine(count);
            Console.Write("變數的內容:");
            Console.Write(ff);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("期中個人專題 - Windows Form App");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("第二次期中專題 - Web UI App");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("結業專題 - Web 網際網路應用程式");
            Console.ResetColor();

            Console.WriteLine("\"雙引號\"");
            Console.WriteLine("\\反斜線\\");
            Console.WriteLine("'軟'");
            Console.WriteLine("\n換行符號\n\n\n再換行\n又換行\n\n一直換行");
            Console.WriteLine("\t縮排\t\t再縮排");

            //合併輸出
            // 1. + 加號
            Console.WriteLine("輸出 aa:" + aa + ", 輸出 bb:" + bb);
            Console.WriteLine("輸出 h:" + h + "\n輸出 hh:" + hh + "\n輸出 hhh:" + hhh);
            // 2. 變數插入字串
            Console.WriteLine($"float:{ee} double:{ff}");
            // 3. 字串插值
            Console.WriteLine("浮點:{0} 整數:{1} 字元:{3} 布林:{2} 字串:{4}", ee, aa, gg, hh, iii);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine("按任意鍵結束程式");
            Console.ReadKey();
        }
    }
}
