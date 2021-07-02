using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleTea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPrice.Text = "";         //預設總價訊息為空字串
            rdbTea1.Checked = true;     //預設為紅茶
            rdbSizeL.Checked = true;    //預設為大杯
            textBox1.Text = "1";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string msg = "";    //設訊息為空字串
            int price = 0;      //設總價為0元
            if (rdbSizeS.Checked == true)   //若選擇小杯
            {
                msg = "小杯";  //設訊息為小杯
                price = 30;    //設總價為30
            }
            else
            {
                msg = "大杯";
                price = 35; //設大杯訊息和總價
            }


            if (rdbTea1.Checked == true)//若選rdbTea1
                msg += rdbTea1.Text;    //訊息加rdbTea1文字
            else if (rdbTea2.Checked == true)   //若選rdbTea2
                msg += rdbTea2.Text;    //訊息加rdbTea2文字
            else
            {
                msg += rdbTea3.Text;    //否則訊息加rdbTea3文字
                price += 5; //奶茶比紅茶跟綠茶貴5元
            }



            if (chk1.Checked == true)
                msg += chk1.Text;       //若勾選chk1就訊息加chk1文字

            if (chk2.Checked == true)   //若勾選chk2
            {
                msg += chk2.Text;       //訊息加chk2文字
                price += 2;             //總價加2
            }

            if (chk3.Checked == true)   //若勾選chkAdd3
            {
                msg += $"({chk3.Text})";
                price -= 5;  //總價減5
            }

            int n;
            if (int.TryParse(textBox1.Text, out n) && n>0)
            {
                price *= n;
                lblPrice.Text = $"{n}杯{msg}：{price}元"; //顯示訊息和總價
            }
            else if (textBox1.Text=="") 
            {
                MessageBox.Show("請輸入杯數謝謝！");
            }
            else
            {
                MessageBox.Show("數值錯誤喇乾！");
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
