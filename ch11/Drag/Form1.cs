using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool drag = false;  //drag紀錄是否可拖曳，預設為不可以
        int x_down, y_down; //記錄滑鼠按下時的座標值
        private void Form1_Load(object sender, EventArgs e)
        {
            btnDrag.Text = "再來R";
        }

        private void btnDrag_MouseEnter(object sender, EventArgs e)
        {   //滑鼠移入按鈕時
            btnDrag.BackColor = Color.LightBlue;   //改變按鈕背景色
        }

        private void btnDrag_MouseLeave(object sender, EventArgs e)
        {   //滑鼠離開按鈕時
            btnDrag.BackColor = SystemColors.Control;   //按鈕背景色復原
            btnDrag.Text = "試試看";   //按鈕文字復原
        }

        private void btnDrag_MouseDown(object sender, MouseEventArgs e)
        {   //在按鈕中按下滑鼠左鍵時
            drag = true;    //設按鈕可以拖曳
            x_down = e.X;
            y_down = e.Y;//記錄滑鼠按下時的座標值
            label2.Text = $"x_down = {x_down}, y_down = {y_down}\n" +
                    $"e.X = {e.X}, e.Y = {e.Y}\n";
        }

        private void btnDrag_MouseMove(object sender, MouseEventArgs e)
        {   //在按鈕中移動滑鼠時
            if (drag)  //若drag值為true
            {
                btnDrag.Text = "拖曳中...";   //改變按鈕文字
                label3.Text = $"x_down = {x_down}, y_down = {y_down}\n" +
                    $"e.X = {e.X}, e.Y = {e.Y}\n";
                btnDrag.Left += e.X - x_down;   //改變按鈕的X座標
                btnDrag.Top = btnDrag.Top + (e.Y - y_down);   //改變按鈕的Y座標
                label1.Text = $"x_down = {x_down}, y_down = {y_down}\n" +
                    $"e.X = {e.X}, e.Y = {e.Y}\n" +
                    $"btnDrag.Left = {btnDrag.Left}, btnDrag.Top = {btnDrag.Top}";
            }
            else
            {
                btnDrag.Text = "移動游標";   //改變按鈕文字
            }
        }

        private void btnDrag_MouseUp(object sender, MouseEventArgs e)
        {   //在按鈕中放開滑鼠左鍵時
            drag = false;    //設按鈕不可以拖曳
        }
    }
}
