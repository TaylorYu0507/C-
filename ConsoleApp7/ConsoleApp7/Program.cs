using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Array 陣列 ---------");

            int[] arrayOne = new int[6]; //有六個整數的元素(elements)
            arrayOne[0] = 1; //index索引 : 0
            arrayOne[1] = 2; //index索引 : 1
            arrayOne[2] = 3;
            arrayOne[3] = 4;
            arrayOne[4] = 5;
            arrayOne[5] = 6; //索引上限: 元素數量 - 1

            int numOne = arrayOne[3]; //取出第4個元素
            Console.WriteLine($"取出索引為3的元素內容:{numOne}");
            arrayOne[4] = 88;
            Console.WriteLine($"替換索引為4的元素內容:{arrayOne[4]}");

            for (int i = 0; i < 6; i += 1) {
                Console.WriteLine($"arrayOne[{i}] = {arrayOne[i]}");
            }

            Console.WriteLine("---------------------------------");

            int[] arrayTwo = new int[] { 1,2,3,4,5,6,7,8 };
            int[] arrayThree = { 10,20,30,40,50,60,70,80,90,100 };

            Console.WriteLine("---------------------------------");

            string[] array課目名稱 = { "國文", "英文", "數學", "自然", "社會", "電腦", "美術" };

            //exe: 列出所有科目
            for (int i = 0; i < array課目名稱.Length; i += 1)
            {
                Console.WriteLine(array課目名稱[i]);
            }

            Console.WriteLine("---------------------------------");

            foreach (string subject in array課目名稱)
            {
                Console.WriteLine(subject);
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("請輸入搜尋科目名稱(輸入完成請按enter)");

            string str搜尋科目名稱 = Console.ReadLine();
            bool is有這個科目 = false;

            for (int i = 0; i < array課目名稱.Length; i += 1)
            {
                if (array課目名稱[i] == str搜尋科目名稱)
                {
                    //有
                    Console.WriteLine($"有開這個科目:{array課目名稱[i]}, 索引:{i}");
                    is有這個科目 = true;
                    break;
                }
                else
                {   //沒有
                    is有這個科目 = false;
                }
            }

            if (is有這個科目 == false)
            {
                Console.WriteLine("無此科目");
            }


            Console.ReadKey();
        }
    }
}
