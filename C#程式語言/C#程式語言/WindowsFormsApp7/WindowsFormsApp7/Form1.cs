using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        //類別變數
        List<Label> listLabels = new List<Label>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listLabels.Add(lblOne);
            listLabels.Add(lblTwo);
            listLabels.Add(lblThree);
        }

        private void btn產生號碼_Click(object sender, EventArgs e)
        {
            Random myRnd = new Random(); //隨機數, 亂數, random number
            //Console.WriteLine(myRnd.Next());
            //Console.WriteLine(myRnd.NextDouble());
            //Console.WriteLine(myRnd.Next(100));
            //Console.WriteLine(myRnd.Next(1, 39)); //1...38
            Console.WriteLine(myRnd.Next(0, 10));

            for (int i =0; i < listLabels.Count; i += 1)
            {
                listLabels[i].Text = string.Format("{0}", myRnd.Next(0,10));
            }
        }

        private void btn加入選號_Click(object sender, EventArgs e)
        {
            string str選號 = "";

            for (int i = 0; i < listLabels.Count; i += 1)
            {
                str選號 += listLabels[i].Text + "  ";
            }

            lbox選號紀錄.Items.Add(str選號);
            顯示筆數();
        }

        private void btn刪除所選號碼_Click(object sender, EventArgs e)
        {
            if (lbox選號紀錄.SelectedIndex >= 0)
            {
                lbox選號紀錄.Items.RemoveAt(lbox選號紀錄.SelectedIndex);
                顯示筆數();
            }
            else
            {
                MessageBox.Show("請選擇一組號碼");
            }
        }

        private void btn刪除所有號碼_Click(object sender, EventArgs e)
        {
            lbox選號紀錄.Items.Clear();
            顯示筆數();
        }

        void 顯示筆數()
        {
            lbl筆數.Text = string.Format("共{0}筆", lbox選號紀錄.Items.Count);
        }
    }
}
