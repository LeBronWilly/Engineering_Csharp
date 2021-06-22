using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;   //匯入 System.IO 命名空間

namespace CreateDir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string msg = "";    //顯示的訊息
            string path;        //目錄路徑
            for (int i = 1; i <= 3; i++)
            {
                path = $"c:\\net\\test\\t{i.ToString()}";
                if (Directory.Exists(path)) //若目錄已經存在
                    msg += $"{Environment.NewLine}{path} 目錄已經存在！";
                else
                {
                    Directory.CreateDirectory(path);
                    msg += $"{Environment.NewLine}{path} 目錄建立成功！";
                }
            }
            string[] dirs = Directory.GetDirectories(@"c:\net\test");
            msg += $"{Environment.NewLine}c:\\net\\test目錄下的子目錄：";
            foreach (string d in dirs)
                msg += $"{Environment.NewLine} {d}";
            MessageBox.Show(msg);
            Directory.Delete(@"c:\net\test", true);
            MessageBox.Show("c:\\net\\test目錄已經刪除！");
        }
    }
}
