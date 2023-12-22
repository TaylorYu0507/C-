using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        //Class類別變數
        string[] arrayStudentName; //學生姓名陣列
        int[] arrayStudentScore; //學生成績陣列
        string[] arrayTempStudentName; //學生姓名暫存陣列
        int[] arrayTempStudentScore; //學生成績暫存陣列

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arrayStudentName = new string[5]; //index索引對應關係, key-value對應, key 鍵
            arrayStudentName[0] = "王小明";
            arrayStudentName[1] = "陳大貓";
            arrayStudentName[2] = "林阿玉";
            arrayStudentName[3] = "張文書";
            arrayStudentName[4] = "黃忠孝";

            arrayStudentScore = new int[5]; //index索引對應關係, value 值
            arrayStudentScore[0] = 76;
            arrayStudentScore[1] = 68;
            arrayStudentScore[2] = 54;
            arrayStudentScore[3] = 92;
            arrayStudentScore[4] = 86;

            arrayTempStudentName = new string[5];
            arrayTempStudentScore = new int[5];

            lbl成績總和.Text = string.Format("{0}", 計算總分(arrayStudentScore));
            lbl成績平均.Text = string.Format("{0}", 計算平均(arrayStudentScore));
        }

        int 計算總分(int[] myArrayScore)
        {
            int sum = 0;
            
            foreach (int score in myArrayScore)
            {
                sum += score;
            }

            return sum;
        }

        double 計算平均(int[] myArrayScore)
        {
            double avg = 0.0;

            avg = Convert.ToDouble(計算總分(myArrayScore)) / myArrayScore.Length;

            return avg;
        }

        private void btn姓名排序_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
            姓名排序(arrayTempStudentName);
        }

        void 姓名排序(string[] myArrayName)
        {
            System.Array.Sort(myArrayName); //符號, 0-9, a-z, 中文由筆畫少到多

            string strMsg = "";

            for (int index = 0; index < myArrayName.Length; index += 1)
            {
                strMsg += string.Format("姓名:{0}\n", myArrayName[index]);
            }

            lbl查詢結果.Text = strMsg;
        }

        void 成績排序(string[] myArrayName, int[] myArrayScore)
        {
            Array.Sort(myArrayScore, myArrayName);//鍵值對應排序

            //EXE: 輸出成績和姓名, 成績由高分到低分輸出
            string strMsg = "";

            for (int index = myArrayName.GetUpperBound(0); index >= 0 ; index -= 1)
            {
                strMsg += string.Format("姓名:{0} 成績:{1}\n", myArrayName[index], myArrayScore[index]);
            }

            lbl查詢結果.Text = strMsg;
        } 


        private void btn成績排序_Click(object sender, EventArgs e)
        {
            Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
            Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);
            成績排序(arrayTempStudentName, arrayTempStudentScore);
        }

        void 列出學生全部資料()
        {
            string strMsg = "";

            int i = 0;
            foreach (string s in arrayStudentName)
            {
                strMsg += $"索引值:{i} 姓名:{s} 成績:{arrayStudentScore[i]}\n";
                i += 1;
            }

            lbl查詢結果.Text = strMsg;
        }

        private void btn列出所有學生資料_Click(object sender, EventArgs e)
        {
            列出學生全部資料();
        }

        private void btn姓名搜尋_Click(object sender, EventArgs e)
        {
            if (txt搜尋關鍵字.Text.Length > 0)
            {
                int index, 名次 = 0;
                string strMsg = "搜尋結果\n------------------------\n";
                string strSearchKey = txt搜尋關鍵字.Text;

                Array.Copy(arrayStudentName, arrayTempStudentName, arrayStudentName.Length);
                Array.Copy(arrayStudentScore, arrayTempStudentScore, arrayStudentScore.Length);

                成績排序(arrayTempStudentName, arrayTempStudentScore);

                index = Array.IndexOf(arrayTempStudentName, strSearchKey);

                if (index <= -1)
                {
                    //找不到
                    strMsg += "查無此人";
                }
                else
                {   //找到了, 決定名次
                    名次 = arrayTempStudentName.Length - index; //EXE: 名次???????????
                    strMsg += $"姓名:{arrayTempStudentName[index]} 成績:{arrayTempStudentScore[index]}分 第{名次}名";
                }

                lbl查詢結果.Text = strMsg;
            }
            else
            {
                MessageBox.Show("請輸入搜尋關鍵字");
            }
        }
    }
}
