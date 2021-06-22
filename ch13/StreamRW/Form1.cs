using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StreamRW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRW_Click(object sender, EventArgs e)
        {
            FileInfo finTest = new FileInfo("test.txt");//建立檔案資料流物件
            StreamWriter sw = finTest.CreateText();//建立資料流寫入器物件sw
            sw.WriteLine("123");    //寫入一行字串
            sw.Write("45");     //寫入字串
            sw.Write("6");      //串接字串
            sw.Flush(); //清空緩衝區
            sw.Close(); //關閉佔用資源
            StreamReader sr = new StreamReader("test.txt");//建立資料流讀取器物件sr
            string msg = ""; string str = "";
            while ((str = sr.ReadLine()) != null)   //逐行讀取檔案資料
            {
                MessageBox.Show(str, "讀取的字串為：");
                msg += $"{str}\r\n";
            }
            MessageBox.Show(msg, "檔案內容為：");
            sr.Close();	//關閉佔用資源
        }
    }
}
