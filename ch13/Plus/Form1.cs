using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Plus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SoundPlayer sp = new SoundPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum1.MaxLength = 2; txtNum2.MaxLength = 2;   //最多輸入兩個字元
            txtNum2.KeyPress += txtNum1_KeyPress;//txtNum2.KeyPress共享txtNum1_KeyPress
            lblAns.Text = "";   //預設答案為空白
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch < '0' || ch > '9') && ch != '\b')
            {
                e.Handled = true;
                sp.SoundLocation = "注意.wav"; sp.Load();//載入注意.wav語音
                sp.Play();  //播放 注意 語音
                MessageBox.Show("請輸入數字", "注意");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            if (num1 >= 50 )
            {
                SystemSounds.Asterisk.Play();   //播放系統警告音效
                MessageBox.Show("請輸入小於50的數字", "注意");
                txtNum1.Text = ""; txtNum1.Focus();
            }
            else if (num2 >= 50)
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("請輸入小於50的數字", "注意");
                txtNum2.Text = ""; txtNum2.Focus();
            }
            else
            {
                lblAns.Text = (num1 + num2).ToString();
                NumSounds(num1.ToString());//呼叫NumSounds方法播放num1數字
                sp.SoundLocation = "加.wav"; sp.Load();//載入加.wav語音
                sp.PlaySync();  //播放 加 語音
                NumSounds(num2.ToString());//呼叫NumSounds方法播放num2數字
                sp.SoundLocation = "等於.wav"; sp.Load();//載入等於.wav語音
                sp.PlaySync();  //播放 等於 語音
                NumSounds(lblAns.Text);//呼叫NumSounds方法播放lblAns.Text數字
            }
        }

        private void NumSounds(string s)
        {
            if (s.Length == 1)  //如果s長度等於1
                Sound(s);   //呼叫Sound方法播放數字
            else
            {
                if (s.Substring(0, 1) != "1")   //若不等於1就
                    Sound(s.Substring(0, 1));   //呼叫Sound方法播放第一個數字
                sp.SoundLocation = "10.wav"; sp.Load();//載入10.wa語音
                sp.PlaySync();  //播放 10 語音
                if (s.Substring(1, 1) != "0")   //若不等於0就
                    Sound(s.Substring(1, 1));   //呼叫Sound方法播放第二個數字
            }
        }

        private void Sound(string s)
        {
            sp.SoundLocation = s + ".wav"; sp.Load();//載入s參數對應的wav檔
            sp.PlaySync();  //播放數字語音
        }
    }
}
