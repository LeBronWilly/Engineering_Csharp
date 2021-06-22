using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;    //設ch為輸入的字元
            if ((ch < 'a' || ch > 'z') && (ch != '\b')) //若ch不是小寫字母或退位鍵
            {
                if ((byte)ch == 13) //若是Enter鍵
                    txtPW.Focus();  //控制權跳到txtPW
                else
                {
                    e.Handled = true;   //清除輸入的字元
                    MessageBox.Show("請輸入小寫字母", "注意", MessageBoxButtons.OK);
                }
            }
        }

        private void txtPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;    //設ch為輸入的字元
            if ((ch < '0' || ch > '9') && (ch != '\b')) //若ch不是數字或退位鍵
            {
                if ((byte)ch == 13) //若是Enter鍵
                    btnLogin.Focus();  //控制權跳到btnLogin
                else
                {
                    e.Handled = true;   //清除輸入的字元
                    MessageBox.Show("請輸入數字", "注意", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "love" && txtPW.Text == "1314")
            {
                MessageBox.Show("帳號和密碼正確！", "歡迎", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("帳號或是密碼不正確！", "注意", MessageBoxButtons.OK);
                txtPW.Text = ""; txtID.Text = "";   //清空文字方塊內容
                txtID.Focus();  //控制權跳到txtID
            }
        }
    }
}
