using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunAway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Fixed3D; //設定不能調整表單大小
            this.MaximizeBox = false;               //表單不能最大化
            picMouse.Image = imgMouse.Images[0];    //預設picMouse的圖檔
            tmrBall.Enabled = true; //啟動計時器
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)  //按鍵的KeyCode值
            {
                case Keys.Left: //按向左鍵
                    picMouse.Image = imgMouse.Images[1];    //改變picMouse的圖檔
                    if (picMouse.Left > 5)  //若picMouse的Left > 5
                        picMouse.Left -= 5; //圖檔左移
                    break;
                case Keys.Right: //按向右鍵
                    picMouse.Image = imgMouse.Images[2];    //改變picMouse的圖檔
                    //若picMouse的Left < 表單工作寬度減圖檔寬度
                    if (picMouse.Left < this.ClientSize.Width - 30)
                        picMouse.Left += 5; //圖檔右移
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            picMouse.Image = imgMouse.Images[0];    //改變圖檔
        }

        private void tmrBall_Tick(object sender, EventArgs e)
        {
            picBall.Top += 10;  //picBall下移10點
            if (picBall.Top + 20 >= picMouse.Top)//若picBall的Top加圖檔高度>=picMouse的Top
            {
                if (picBall.Left + 20 > picMouse.Left && picBall.Left < picMouse.Left + 32)
                    Application.Exit(); //程式結束
                else
                {
                    this.Width -= 30;           //表單寬度減少30
                    if (tmrBall.Interval > 10)  //若tmrBall的Interval > 10
                        tmrBall.Interval -= 5;  //tmrBall的Interval減5
                    picBall.Top = -10;          //picBall位置移動到最上方
                    picBall.Left = picMouse.Left;
                }
            }
        }
    }
}
