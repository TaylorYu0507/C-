using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
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

        void callByValue(int y)
        {
            //傳值呼叫
            y += 1;
            lblCBV2.Text = $"參數傳進方法內部的值:{y}";
        }

        private void btnCBV_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblCBV1.Text = $"x變數傳遞之前的值:{x}";
            callByValue(x);
            lblCBV3.Text = $"x變數傳遞之後的值:{x}";
        }

        void callByReference(ref int y)
        {
            //傳址呼叫
            y += 1;
            lblCBR2.Text = $"參數傳進方法內部的值:{y}";
        }

        private void btnCBR_Click(object sender, EventArgs e)
        {
            int x = 5;
            lblCBR1.Text = $"x變數傳遞之前的值:{x}";
            callByReference(ref x);
            lblCBR3.Text = $"x變數傳遞之後的值:{x}";
        }
    }
}
