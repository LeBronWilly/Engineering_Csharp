using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noodle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int price = 0;  //小菜總價

        private void Form1_Load(object sender, EventArgs e)
        {
            lblNoodle.Text = "寬麵";lblBeef.Text = "招牌";lblSide.Text = "";
            mnuNoodle.DropDown = this.cmnuNoodle;   //設功能項目的下拉式清單來源
            mnuBeef.DropDown = this.cmnuBeef;
            mnuSide.DropDown = this.cmnuSide;
            lblNoodle.ContextMenuStrip = cmnuNoodle;//設標籤的快顯功能表來源
            lblBeef.ContextMenuStrip = cmnuBeef;
            lblSide.ContextMenuStrip = cmnuSide;
            cmnuNoodle2.Click += cmnuNoodle1_Click; //設定共享事件
            cmnuBeef2.Click += cmnuBeef1_Click; cmnuBeef3.Click += cmnuBeef1_Click;
            cmnuSide2.Click += cmnuSide1_Click;cmnuSide3.Click += cmnuSide1_Click;
        }

        private void cmnuNoodle1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem m = (ToolStripMenuItem)sender;//取得觸動事件的物件
            lblNoodle.Text = m.Text;
        }

        private void cmnuBeef1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem m = (ToolStripMenuItem)sender;
            lblBeef.Text = m.Text;
        }

        private void cmnuSide1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem m = (ToolStripMenuItem)sender;
            m.Checked = !m.Checked; //改變項目的勾選狀態
            price = 0;lblSide.Text = "";
            if (cmnuSide1.Checked == true)  //若有勾選
            {
                lblSide.Text = $"{cmnuSide1.Text}, ";
                price = 30; //小菜總價加30
            }
            if (cmnuSide2.Checked == true)
            {
                lblSide.Text += $"{cmnuSide2.Text}, ";
                price += 30;
            }
            if (cmnuSide3.Checked == true)
            {
                lblSide.Text += $"{cmnuSide3.Text}";
                price += 30;
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{lblBeef.Text}{lblNoodle.Text},加 {lblSide.Text},總價{120+price}元");
            Application.Exit();
        }
    }
}
