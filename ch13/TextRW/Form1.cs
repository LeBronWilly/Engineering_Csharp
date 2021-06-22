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

namespace TextRW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "純文字(*.txt)|*.txt";    //檔案篩選字串
            openFileDialog1.InitialDirectory = Application.StartupPath;//預設目錄為執行檔目錄
            saveFileDialog1.Filter = "純文字(*.txt)|*.txt";
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.DefaultExt = ".txt";    //設定存檔時的預設副檔名為txt
            FileInfo finUser = new FileInfo("user.dat"); //宣告FileInfo類別物件finUser
            if (finUser.Exists == false) //若檔案不存在
            {
                FileStream fs = finUser.Create();   //新增檔案
                lblMsg.Text = "第一次使用！";
                fs.Close(); //關閉FileStream物件
            }
            else    //若檔案已經存在
            {
                using (StreamReader sr = new StreamReader("user.dat"))
                {
                    lblMsg.Text = $"上次使用日期：{sr.ReadLine()}";
                }
                using (StreamWriter sw = File.CreateText("user.dat"))
                {
                    sw.Write(DateTime.Now.ToString());  //覆寫目前時間
                }
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fName = saveFileDialog1.FileName;
                FileInfo finCreate = new FileInfo(fName);
                StreamWriter sw = finCreate.AppendText();//以附加方式寫入
                sw.WriteLine(txtInput.Text);
                sw.Flush();
                sw.Close();
                lblMsg.Text = $"{Path.GetFileName(fName)} 資料加入完成。";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fName = saveFileDialog1.FileName;
                FileInfo finCreate = new FileInfo(fName);
                using (StreamWriter sw = finCreate.CreateText())//以覆寫方式寫入
                {
                    sw.WriteLine(txtInput.Text);
                    sw.Flush();
                }
                lblMsg.Text = $"{Path.GetFileName(fName)} 資料新增完成。";
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog1.FileName;
                if (File.Exists(fName) == true) //若檔案存在
                {
                    txtInput.Text = File.ReadAllText(fName);
                    lblMsg.Text = $"{Path.GetFileName(fName)} 檔案開啟完成。";
                }
            }
        }
    }
}
