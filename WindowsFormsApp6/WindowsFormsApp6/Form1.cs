using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        //類別變數
        List<ArrayList> 員工資料集合 = new List<ArrayList>();
        List<Hashtable> 員工資料集合2 = new List<Hashtable>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            //List
            Console.WriteLine("********** List Demo **********");

            List<int> myIntList = new List<int>();
            myIntList.Add(1);
            myIntList.Add(2);
            myIntList.Add(3);
            myIntList.Add(4);
            myIntList.Add(5);
            myIntList.Add(6);

            foreach (int item in myIntList)
            {
                Console.WriteLine(item);
            }

            List<int> myIntList2 = new List<int>() { 6,5,4,3,2,1 };

            Console.WriteLine("--------------------------------");

            List<string> myStringList = new List<string>();
            myStringList.Add("red");
            myStringList.Add("yellow");
            myStringList.Add("blue");
            myStringList.Add("purple");
            myStringList.Add("green");

            Console.WriteLine("======== 列出所有元素 ========");
            for (int i = 0; i < myStringList.Count; i += 1)
            {
                Console.WriteLine($"{myStringList[i]}");
            }
            Console.WriteLine("======== 修改List元素 ========");
            myStringList[1] = "lightyellow";
            myStringList[2] = "darkblue";
            for (int i = 0; i < myStringList.Count; i += 1)
            {
                Console.WriteLine($"{myStringList[i]}");
            }
            //myStringList[5] = "black"; //錯誤!!index超出範圍

            Console.WriteLine("======== AddRange ===========");
            List<string> myNewStringList = new List<string>() { "gray", "brown", "pink"};
            myStringList.AddRange(myNewStringList);
            顯示所有的List元素(myStringList);

            Console.WriteLine("======== Insert ===========");
            myStringList.Insert(2, "skyblue");
            顯示所有的List元素(myStringList);

            Console.WriteLine("======== InsertRange ===========");
            myStringList.InsertRange(3, myNewStringList);
            顯示所有的List元素(myStringList);

            Console.WriteLine("======== 移除元素 ===========");
            myStringList.Remove("gray"); //移除第一個符合的元素
            myStringList.RemoveAt(3); //索引值
            myStringList.RemoveRange(4, 3); //移除索引值4 ,5, 6 的元素
            顯示所有的List元素(myStringList);

            Console.WriteLine("======== Sort ==========");
            myStringList.Sort(); //符號, 0-9, a-z, 中文由筆畫少到多
            顯示所有的List元素(myStringList);

            Console.WriteLine("======== Reverse ==========");
            myStringList.Reverse(); //排列順序反轉
            顯示所有的List元素(myStringList);

            Console.WriteLine("======== IndexOf ==========");
            int index = myStringList.IndexOf("pink");
            Console.WriteLine($"第一個得到的pink索引值:{index}");

            Console.WriteLine("======== List 轉 Array ==========");
            string[] myTempArray = myStringList.ToArray();
            foreach (string ss in myTempArray)
            {
                Console.WriteLine($"{ss}");
            }

            Console.WriteLine("======== Array 轉 List ==========");
            List<string> myTermpList = new List<string>(myTempArray);
            顯示所有的List元素(myTermpList);

            Console.WriteLine("======== clear ==========");
            myStringList.Clear();

            Console.WriteLine($"myStringList count:{myStringList.Count}");

        }

        void 顯示所有的List元素(List<string> myList)
        {
            for (int i =0; i < myList.Count; i += 1)
            {
                Console.WriteLine(myList[i]);
            }
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            Console.WriteLine("========= ArrayList 示範 =========");
            System.Collections.ArrayList myPersonInfo = new System.Collections.ArrayList();
            myPersonInfo.Add("王小明");
            myPersonInfo.Add(32000);
            myPersonInfo.Add(DateTime.Now);
            myPersonInfo.Add("0912-345-678");
            myPersonInfo.Add("高雄市前金區中正路8888號");
            myPersonInfo.Add(170.0f);
            myPersonInfo.Add(26);
            myPersonInfo.Add(false);

            ArrayList myPersonInfo2 = new ArrayList();
            myPersonInfo2.Add("張大書");
            myPersonInfo2.Add(50000);
            myPersonInfo2.Add(new DateTime(2000,1,2,14,23,12));
            myPersonInfo2.Add("0988-333-666");
            myPersonInfo2.Add("台南市東區中華路666號");
            myPersonInfo2.Add(174.0f);
            myPersonInfo2.Add(45);
            myPersonInfo2.Add(true);

            員工資料集合.Add(myPersonInfo);
            員工資料集合.Add(myPersonInfo2);

            foreach (ArrayList item in 員工資料集合)
            {
                string 姓名 = item[0].ToString();
                int 薪水 = Convert.ToInt32(item[1]);
                DateTime 到職日 = Convert.ToDateTime(item[2]);
                string 電話 = Convert.ToString(item[3]);
                string 地址 = Convert.ToString(item[4]);
                float 身高 = Convert.ToSingle(item[5]);
                int 年齡 = Convert.ToInt32(item[6]);
                bool 婚姻狀態 = Convert.ToBoolean(item[7]);

                string strMsg = $"{姓名} {薪水} {到職日} {電話} {地址} {身高} {年齡} {婚姻狀態}";
                Console.WriteLine(strMsg);
                Console.WriteLine("------------------------------------");
            }
            Console.WriteLine("=======================================");
        }

        private void btnString進階_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=========== String的進階操作 ============");
            string strA = "這是\n第一個字串";
            string strB = @"c:\windwos\notes\test.txt"; //不處理特殊符號

            Console.WriteLine(strA);
            Console.WriteLine(strB);
            Console.WriteLine("----------------------------------------");

            string strOne = "Hello World !! C# String World";
            Console.Write(strOne);
            Console.WriteLine($"字串長度:{strOne.Length}個字元");

            int index = strOne.IndexOf("World");
            Console.WriteLine($"第一個World字串的第一個字元索引值:{index}");

            string strTwo = strOne.Insert(6, "Hi ");
            Console.WriteLine(strOne);
            Console.WriteLine(strTwo);

            string strThree = strOne.Remove(6);
            Console.WriteLine(strThree);

            string strFour = strOne.Remove(12, 3); //index: 12, 13, 14
            Console.WriteLine(strFour);

            string strFive = strOne.Replace("World", "Earth");
            Console.WriteLine(strFive);

            string strSix = strOne.Substring(15 ,2);
            Console.WriteLine(strSix);

            string strSeven = strOne.ToLower();
            string strEight = strOne.ToUpper();
            Console.WriteLine(strSeven);
            Console.WriteLine(strEight);

            string strNine = " Visual Studio ";
            string strTen = strNine.Trim(); //去前後空白
            Console.WriteLine(strNine.Length);
            Console.WriteLine(strTen.Length);

            bool is包含某個字串 = strOne.Contains("C#");
            Console.WriteLine($"是否含有C#字串: {is包含某個字串}");

            char charOne = strOne[2];
            Console.WriteLine($"第三個字元:{charOne}");

            string str合併 = strOne + " Forever" + " !!" + 9 + 10.2 + 11.56f + false + 'x';
            Console.WriteLine(str合併);

            string strCollection = "珍珠|波霸|QQ|椰果|芋園";
            string[] array配料 = strCollection.Split('|');

            foreach (string 配料 in array配料 )
            {
                Console.WriteLine(配料);
            }
            Console.WriteLine("----------------------------------------");



        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Console.WriteLine("============ Dictionary 示範 ============");
            Dictionary<string, int> dictNameScore = new Dictionary<string, int>();
            dictNameScore.Add("王小明", 84);
            dictNameScore.Add("陳大貓", 72);
            dictNameScore.Add("林小玉", 93);
            dictNameScore.Add("張大書", 72);
            dictNameScore.Add("黃忠孝", 69);
            Console.WriteLine($"陳大貓的成績: {dictNameScore["陳大貓"]}");
            dictNameScore["黃忠孝"] = 96;
            Console.WriteLine($"黃忠孝的成績: {dictNameScore["黃忠孝"]}");

            for (int i = 0; i < dictNameScore.Count; i += 1)
            {
                Console.WriteLine($"key: {dictNameScore.ElementAt(i).Key}, value: {dictNameScore.ElementAt(i).Value}");
            }

            foreach (KeyValuePair<string, int> myKeyValue in dictNameScore)
            {
                Console.WriteLine($"key: {myKeyValue.Key} value: {myKeyValue.Value}");
            }

            Console.WriteLine("-------------------------------------------");

            string strSearch = "王小明";
            bool is是否有這個key = dictNameScore.ContainsKey(strSearch);

            if (is是否有這個key)
            {
                Console.WriteLine($"{strSearch} 成績:{dictNameScore[strSearch]}");
            }
            else
            {
                Console.WriteLine("查無此人");
            }

            Console.WriteLine("-------------------------------------------");

            dictNameScore.Remove("黃忠孝");

            foreach (KeyValuePair<string, int> myKeyValue in dictNameScore)
            {
                Console.WriteLine($"key: {myKeyValue.Key} value: {myKeyValue.Value}");
            }

            Console.WriteLine("-------------------------------------------");

            dictNameScore.Clear();
            Console.WriteLine($"count: {dictNameScore.Count}");

            List<string> myNameList = dictNameScore.Keys.ToList<string>();
            string[] myNameArray = dictNameScore.Keys.ToArray<string>();

            List<int> myScoreList = dictNameScore.Values.ToList<int>();
            int[] myScoreArray = dictNameScore.Values.ToArray<int>();
        }

        private void btnHashTable_Click(object sender, EventArgs e)
        {
            Hashtable memberInfo = new Hashtable();
            memberInfo.Add("姓名", "王大衛");
            memberInfo.Add("年齡", 30);
            memberInfo.Add("身高", 170.0);
            memberInfo.Add("電話", "0912-345-678");
            memberInfo.Add("婚姻狀態", false);

            Hashtable memberInfo2 = new Hashtable();
            memberInfo2.Add("姓名", "李瑪莉");
            memberInfo2.Add("年齡", 36);
            memberInfo2.Add("身高", 160.0);
            memberInfo2.Add("電話", "0933-777-999");
            memberInfo2.Add("婚姻狀態", true);

            員工資料集合2.Add(memberInfo);
            員工資料集合2.Add(memberInfo2);

            foreach (DictionaryEntry member in memberInfo)
            {
                Console.WriteLine($"key: {member.Key} value:{member.Value}");
            }

            Console.WriteLine("-------------------------------------------------");

            string 姓名 = Convert.ToString(memberInfo["姓名"]);
            int 年齡 = Convert.ToInt32(memberInfo["年齡"]);
            memberInfo["電話"] = "07-999-8888";

            foreach (DictionaryEntry member in memberInfo)
            {
                Console.WriteLine($"key: {member.Key} value:{member.Value}");
            }

            Console.WriteLine("-------------------------------------------------");

            if (memberInfo.Contains("姓名") == true)
            {
                Console.WriteLine($"姓名:{memberInfo["姓名"]}");
            }
            else
            {
                Console.WriteLine("查無欄位");
            }

            Console.WriteLine("-------------------------------------------------");

            foreach (Hashtable myMemberInfo in 員工資料集合2)
            {
                foreach (DictionaryEntry member in myMemberInfo)
                {
                    Console.WriteLine($"key: {member.Key} value:{member.Value}");
                }
                Console.WriteLine(".....................................");
            }

            Console.WriteLine("-------------------------------------------------");
            memberInfo.Remove("年齡");

            foreach (DictionaryEntry member in memberInfo)
            {
                Console.WriteLine($"key: {member.Key} value:{member.Value}");
            }
            Console.WriteLine("-------------------------------------------------");

            //memberInfo.Clear();
            //memberInfo2.Clear();
            foreach (Hashtable myMemberInfo in 員工資料集合2)
            {
                myMemberInfo.Clear();
            }

            Console.WriteLine($"count: {memberInfo.Count}, {memberInfo2.Count}");

        }
    }
}
