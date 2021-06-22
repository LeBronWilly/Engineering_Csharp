using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sec = 10;   //欄位成員變數sec記錄秒數，各函式彼此共用

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSec.BackColor = Color.Black;         //背景為黑色
            lblSec.ForeColor = Color.LightGreen;    //字為亮綠色
            lblSec.TextAlign = ContentAlignment.MiddleCenter;   //文字置中
            txtSec.Text = sec.ToString();           //設定預設秒數
            lblSec.Text = string.Format("{0:000.0 秒}", sec);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sec = int.Parse(txtSec.Text);   //讀取txtSec的秒數
            tmrCount.Enabled = true;        //啟動計時器
        }

        private void tmrCount_Tick(object sender, EventArgs e)
        {
            if (sec >= 0.1) //若秒數大於等於0.1秒
            {
                lblSec.Text = string.Format("{0:000.0 秒}", sec -= 0.1);//秒數減0.1
            }
            else
            {
                tmrCount.Stop(); //關閉計時器
            }
        }
    }
}
