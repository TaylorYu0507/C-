using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn公分轉英吋_Click(object sender, EventArgs e)
        {
            if (txt公分.Text != "")
            {
                try
                {
                    string strInput = txt公分.Text;
                    float myCM = 0.0f;
                    float myInch = 0.0f;

                    myCM = System.Convert.ToSingle(strInput);
                    myInch = myCM * 0.3937f;

                    txt英吋.Text = Convert.ToString(myInch);
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    txt英吋.Clear();
                }

                finally
                {
                    Console.WriteLine("Finally !!");
                }
            } else
            {
                MessageBox.Show("請輸入公分數值");
                txt英吋.Clear();
            }
        }

        private void btn英吋轉公分_Click(object sender, EventArgs e)
        {
            //自行練習
        }

        private void btn坪轉平方公尺_Click(object sender, EventArgs e)
        {
            if (txt坪.Text != "")
            {
                double my坪數, my平方公尺 = 0.0;
                // 3.3058
                my坪數 = Convert.ToDouble(txt坪.Text);
                my平方公尺 = my坪數 * 3.3058;
                //txt平方公尺.Text = Convert.ToString(my平方公尺);
                //txt平方公尺.Text = $"{my平方公尺}";
                //txt平方公尺.Text = my平方公尺.ToString();
                txt平方公尺.Text = string.Format("{0:F2}", my平方公尺);
            } 
            else
            {
                MessageBox.Show("請輸入正確坪數");
            }
        }

        private void btn平方公尺轉坪_Click(object sender, EventArgs e)
        {
            //自行練習
        }

        private void btn公斤轉磅_Click(object sender, EventArgs e)
        {
            if (txt公斤.Text.Length > 0)
            {
                double myKG, myPound = 0.0;
                bool is轉換成功 = false;

                is轉換成功 = Double.TryParse(txt公斤.Text, out myKG);

                if (is轉換成功 == true)
                {
                    myPound = myKG * 2.2;
                    txt磅.Text = string.Format("{0:F2}", myPound);
                }
                else
                { //false
                    MessageBox.Show("輸入公斤數值有誤,請重新輸入");
                    txt磅.Clear();
                }
            }
            else
            {
                MessageBox.Show("請輸入公斤數值");
                txt磅.Clear();
            }
        }

        private void btn磅轉公斤_Click(object sender, EventArgs e)
        {
            //自行完成
        }
    }
}
