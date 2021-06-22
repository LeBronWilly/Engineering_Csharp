using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int win, loss, same, pc;

        private void btn0_Click(object sender, EventArgs e)
        {
            string str;

            if (pc == 0)
            {
                str = "電腦出剪刀，結果平手";
                same++;
            }
            else if (pc == 1)
            {
                str = "電腦出石頭，結果電腦贏";
                loss++;
            }
            else
            {
                str = "電腦出布，結果你贏";
                win++;
            }
            lblMsg.Text = $"你出剪刀，{str}\n戰績：贏({win})平手({same})敗({loss})";
            btn0.Enabled = btn1.Enabled = btn2.Enabled = false;
            btnGo.Enabled = btnExit.Enabled = true;
            lblTitle.Text = "按開始鈕進行遊戲，按結束鈕結束遊戲";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string str;

            if (pc == 1)
            {
                str = "電腦出石頭，結果平手";
                same++;
            }
            else
            {
                if (pc == 2)
                {
                    str = "電腦出布，結果電腦贏";
                    loss++;
                }
                else
                {
                    str = "電腦出剪刀，結果你贏";
                    win++;
                }
            }
            lblMsg.Text = $"你出石頭，{str}\n戰績：贏({win})平手({same})敗({loss})";
            btn0.Enabled = btn1.Enabled = btn2.Enabled = false;
            btnGo.Enabled = btnExit.Enabled = true;
            lblTitle.Text = "按開始鈕進行遊戲，按結束鈕結束遊戲";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string str;

            switch (pc)
            {
                case 0:
                    str = "電腦出剪刀，結果電腦贏";
                    loss++;
                    break;
                case 1:
                    str = "電腦出石頭，結果你贏";
                    win++;
                    break;
                default:
                    str = "電腦出布，結果平手";
                    same++;
                    break;
            }
            lblMsg.Text = $"你出布，{str}\n戰績：贏({win})平手({same})敗({loss})";
            btn0.Enabled = btn1.Enabled = btn2.Enabled = false;
            btnGo.Enabled = btnExit.Enabled = true;
            lblTitle.Text = "按開始鈕進行遊戲，按結束鈕結束遊戲";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "選擇要出剪刀、石頭、布";
            btn0.Enabled = btn1.Enabled = btn2.Enabled = true;
            btnGo.Enabled = btnExit.Enabled = false;
            Random ranobj = new Random();
            pc = ranobj.Next(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            win = loss = same = 0;
            lblTitle.Text = "按開始鈕進行遊戲，按結束鈕結束遊戲";
            lblMsg.Text = "";
            btn0.Enabled = btn1.Enabled = btn2.Enabled = false;
        }
    }
}
