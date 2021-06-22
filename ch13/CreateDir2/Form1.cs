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

namespace CreateDir2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string msg;     //顯示的訊息
            DirectoryInfo dirT1 = new DirectoryInfo(@"c:\net\test\t1");
            if (dirT1.Exists)   //若目錄已經存在
                msg = "目錄已經存在！";
            else
            {
                dirT1.Create();
                msg = "目錄建立成功！";
                DirectoryInfo dirNet = new DirectoryInfo("c:\\net");
                if (dirNet.Exists)  //若c:\net目錄已經存在
                {
                    DirectoryInfo dirNet2 = new DirectoryInfo("c:\\net2");
                    if (dirNet2.Exists == false)    //若c:\net2目錄不存在
                    {
                        DirectoryInfo dirTest = new DirectoryInfo(@"c:\net\test");
                        dirTest.MoveTo("c:\\net2"); //使用MoveTo方法搬移目錄
                        msg += $"{Environment.NewLine }搬移成功！";
                        DirectoryInfo[] dirs = dirNet2.GetDirectories();
                        msg += $"{Environment.NewLine}c:\\net2目錄下的子目錄：";
                        foreach (DirectoryInfo d in dirs)
                            msg += $"{Environment.NewLine}{d.FullName}";
                    }
                    else
                        msg += $"{Environment.NewLine}無法搬移！";
                }
                else
                    msg += $"{Environment.NewLine}無法搬移！";
            }
            MessageBox.Show(msg);
        }
    }
}
