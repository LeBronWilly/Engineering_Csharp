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
        double sec = 2;   //欄位成員變數sec記錄秒數，各函式彼此共用

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
            if (double.TryParse(txtSec.Text, out sec))
            {
                txtSec.Enabled = false;
                sec = double.Parse(txtSec.Text);   //讀取txtSec的秒數
                tmrCount.Enabled = true;        //啟動計時器
            }
            else
            {
                MessageBox.Show("格式錯誤喇乾");
            }

        }

        private void tmrCount_Tick(object sender, EventArgs e)
        {
            if (sec >= 0.1) //若秒數大於等於0.1秒
            {
                lblSec.Text = string.Format("{0:000.0 秒}", sec -= 0.1);//秒數減0.1
            }
            else
            {
                lblSec.Text = string.Format("{0:000.0 秒}", 0.0); //確保結束為0
                //lblSec.Text = "000.0 秒"; //確保結束為0
                tmrCount.Stop(); //關閉計時器
                //tmrCount.Enabled = false; //關閉計時器
                txtSec.Enabled = true;
            }
        }

        private void txtSec_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSec.Text, out sec))
            {
                lblSec.Text = string.Format("{0:000.0 秒}", sec);
            }
            else
            {

                lblSec.Text = string.Format("{0:000.0 秒}", 0.0);
            }
        }
    }
}
