using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("-------- Console 輸出窗 output --------");
            Console.WriteLine("****** 格式化輸出 ******");
            Console.WriteLine("小數點位數的控制, pi = {0:F4}", 3.141592);
            Console.WriteLine("百分比記號 {0:P}", 0.2387);
            Console.WriteLine("金融符號 {0:C}", 10000000);
            Console.WriteLine("科學記號 {0:E}", 1234566789);
            Console.WriteLine("整數補零 {0:D8}", 1234);

            Console.WriteLine(DateTime.Now);
            Console.WriteLine("{0:d}", DateTime.Now);
            Console.WriteLine("{0:D}", DateTime.Now);
            Console.WriteLine("{0:F}", DateTime.Now);
            Console.WriteLine("{0:T}", DateTime.Now);
            Console.WriteLine("{0:t}", DateTime.Now);
            Console.WriteLine("{0:M}", DateTime.Now);

            lbl回應訊息.Text = "歡迎光臨 !! \n請選擇您要購買的飲料";
        }

        private void btn紅茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "您選了紅茶\n價格20元, 請付款\n如果有載具,請先按掃描載具";
        }

        private void btn綠茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "您選了綠茶\n價格25元, 請付款\n如果有載具,請先按掃描載具";
        }

        private void btn奶茶_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "您選了奶茶\n價格30元, 請付款\n如果有載具,請先按掃描載具";
        }

        private void btn掃描載具_Click(object sender, EventArgs e)
        {

        }

        private void btnQRCODE付款_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("請掃描QRcode付款");
            //MessageBox.Show("請掃描QRcode付款", "付款", MessageBoxButtons.YesNo);
            MessageBox.Show("請掃描QRcode付款", "掃描付款", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void btnCoke_Click(object sender, EventArgs e)
        {
            lbl回應訊息.Text = "您選了Coke\n價格15元, 請付款\n如果有載具,請先按掃描載具";
        }
    }
}
