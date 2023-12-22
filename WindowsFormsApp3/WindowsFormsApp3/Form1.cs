using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            顯示歡迎訊息();
        }

        void 顯示歡迎訊息()
        {
            MessageBox.Show("歡迎使用本程式 !!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            顯示歡迎訊息();
        }

        void 有參數的方法(string product, double price, int amount, string user, bool isPay)
        {
            MessageBox.Show($"Dear {user}, \n 您買了 {product}, {amount}個\n 單價:{price}元 總價:{price * amount}元\n 是否已付款:{isPay} \n謝謝光臨");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            有參數的方法("iPhone 15 Pro", 36000.0, 2, "David Wang", true);
            有參數的方法("Samsung S23", 32000.0, 3, "Mary Lee", false);
        }

        int 總和(int a, int b, int c, int d, int e)
        {
            int sum = 0;

            sum = a + b + c + d + e;

            return sum;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mySum = 總和(1, 2, 3, 4, 5);
            MessageBox.Show($"總和:{mySum}");
            double myAvg = 平均(1, 2, 3, 4, 6);
            MessageBox.Show($"平均:{myAvg}");
        }

        double 平均(int a, int b, int c, int d, int e)
        {
            double avg = Convert.ToDouble(a + b + c + d + e) / 5;
            return avg;
        }

        void 列出數字階層(long num)
        { //5! = 5 x 4 x 3 x 2 x 1 ==> 120 , 使用for迴圈法
            long result = 1;

            for (long i = num; i >= 1; i -= 1)
            {
                result *= i;
            }

            MessageBox.Show($"{num}! = {result}");
        }

        long 遞迴(long num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * 遞迴(num - 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            列出數字階層(20);
            int inputNum = 20;
            MessageBox.Show($"遞迴:{inputNum}! = {遞迴(inputNum)}");
        }

        //練習:
        //EXE: double 平均(int a, int b, int c, int d, int e)

        //AI: int 回傳最大值(int a, int b, int c)
        //AI: bool 這個數是否為質數(long number)
        //ADV AI: 找到C#最大的質數
    }

}