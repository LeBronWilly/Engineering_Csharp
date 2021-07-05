using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Touch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool drag = false;  //紀錄是否為拖曳，預設不是拖曳
        int sX, sY;         //紀錄觸碰螢幕的座標值

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseWheel += picTouch_Zoom;   //訂閱表單的MouseWheel事件
        }

        private void picTouch_DoubleClick(object sender, EventArgs e)
        {
            picTouch.Size = new Size(116, 159);     //恢復預設大小
            picTouch.Location = new Point(160, 80);  //恢復預設位置
        }

        private void picTouch_Zoom(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)    //若是伸展手勢
            {
                picTouch.Width = (int)(picTouch.Width * 1.1);   //寬度加大
                picTouch.Height = (int)(picTouch.Height * 1.1); //高度加大
            }
            else
            {
                picTouch.Width = (int)(picTouch.Width * 0.9);   //寬度縮小
                picTouch.Height = (int)(picTouch.Height * 0.9); //高度縮小
            }
        }
        private void picTouch_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;        //設為是拖曳
            sX = e.X;
            sY = e.Y;  //紀錄座標值
        }

        private void picTouch_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)   //若是拖曳
            {
                picTouch.Left += (e.X - sX);    //改變X座標
                picTouch.Top += (e.Y - sY);     //改變Y座標
            }
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void picTouch_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;   //設為不是拖曳
        }
    }
}
