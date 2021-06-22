using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = 0;  //紀錄飛鳥圖檔的索引值
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("背景.jpg");
            this.DoubleBuffered = true;
            picBird.Image = imgBirds.Images[index];
            picBird.BackColor = Color.Transparent;  //背景色設為透明
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrFly.Start(); //啟動計時器
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrFly.Stop(); //關閉計時器
        }

        private void tmrFly_Tick(object sender, EventArgs e)
        {
            picBird.Left += 15; //圖片右移15點
            if (picBird.Left >= this.ClientSize.Width)
                picBird.Left = -picBird.Width;
            if (index == 5)
                index = 0;
            else
                index += 1;
            picBird.Image = imgBirds.Images[index];
        }
    }
}
