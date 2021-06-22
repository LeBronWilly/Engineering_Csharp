using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace link1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "小算盤是Windows內建的小工具\n請按下列超連結來認識小算盤";
            lblMsg.Font = new Font("標楷體", 12, FontStyle.Bold);
        }

        private void llblReadMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("小算盤.TXT");
        }

        private void llblApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\WINDOWS\system32\calc.exe");
        }

        private void llblWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(
                "https://support.microsoft.com/zh-tw/help/4026389/windows-10-calculator-in");
        }
    }
}
