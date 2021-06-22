using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] pic = new string[] { "貓", "綿羊", "土撥鼠", "雁", "駝馬", "大角羊" };
        private void Form1_Load(object sender, EventArgs e)
        {//訂定圖片會隨圖片方塊大小調整
            picShow.SizeMode = PictureBoxSizeMode.StretchImage;
            hsbWidth.Minimum = 10;  //最小值為10
            hsbWidth.Maximum = 260; //最大值為260
            hsbWidth.Value = 100;   //設定現值為100
            picShow.Width = hsbWidth.Value;    //設picShow的寬度等於hsbWidth值
            vsbHeight.Minimum = 10;  //最小值為10
            vsbHeight.Maximum = 200; //最大值為200
            vsbHeight.Value = 80;    //設定現值為80
            picShow.Height = vsbHeight.Value;  //設picShow的高度等於vsbHeight值
            tkbNum.Minimum = 0; //最小值為0
            tkbNum.Maximum = 5; //最大值為5
            tkbNum.Value = 2;   //設定現值為2
        }
        private void vsbHeight_Scroll(object sender, ScrollEventArgs e)
        {   //在vsbHeight的Scroll事件中設定picShow的高度
            picShow.Height = vsbHeight.Value;
        }

        private void hsbWidth_Scroll(object sender, ScrollEventArgs e)
        {   //在hsbWidth的Scroll事件中設定picShow的寬度
            picShow.Width = hsbWidth.Value;
        }

        private void tkbNum_ValueChanged(object sender, EventArgs e)
        {   //在tkbNum的ValueChanged事件中設定picShow顯示的圖檔
            picShow.Load(pic[tkbNum.Value]+".bmp");//以tkbNum的值當陣列的註標值
            lblNum.Text = $"第 {tkbNum.Value + 1} 張圖片";
        }
    }
}
