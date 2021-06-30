using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            lblShow_LBJ.BackColor = Color.Aqua;
            lblShow_LBJ.Text = "大家好";
            lblShow_LBJ.Font = new Font("微軟正黑體", lblShow_LBJ.Font.Size, FontStyle.Bold);
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            lblShow_LBJ.BackColor = Color.Chocolate;
            lblShow_LBJ.Text = DateTime.Now.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblShow_Click(object sender, EventArgs e)
        {

        }
    }
}
