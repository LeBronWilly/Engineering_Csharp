using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string unit = "公分"; //成員變數紀錄計算單位
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbL.Checked = true;    //預設選取圓周長
            rdbCm.Checked = true;   //預設選取公分
            lblAns.Text = "";       //預設為空字串
        }

        private void rdbCm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCm.Checked == true)  //若rdbCm被選取
                unit = "公分";
            else
                unit = "英吋";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int r = int.Parse(txtR.Text);   //讀取半徑值並轉為整數
            if (rdbL.Checked == true)  //若rdbL被選取
                lblAns.Text = $"圓周長為 {Math.Round(Math.PI * 2 * r,2)} {unit}";
            else
                lblAns.Text = $"圓面積為 {Math.Round(Math.PI * r * r,2)} 平方{unit}";
        }
    }
}
