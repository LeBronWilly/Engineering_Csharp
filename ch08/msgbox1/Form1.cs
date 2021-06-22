using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace msgbox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int num = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult result;
            num++;

            if ((txtID.Text == "google") && (txtPW.Text == "1688"))
            {
                MessageBox.Show("歡迎光臨, Google網站");
                System.Diagnostics.Process.Start("http://www.google.com.tw");
                Application.Exit();
            }
            else
            {
                if(num == 3)
                {
                    MessageBox.Show("帳號密碼連續三次輸入錯誤\n無法進入Google網站");
                    Application.Exit();
                }
                else
                {
                    result = MessageBox.Show($"你的帳號密碼有誤，剩下{3-num}次！是否重新輸入？",
                        "帳號密碼錯誤", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No) 
                        Application.Exit();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
