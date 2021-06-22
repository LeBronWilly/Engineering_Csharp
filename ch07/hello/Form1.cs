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
            lblShow.BackColor = Color.Aqua;
            lblShow.Text = "大家好";
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            lblShow.BackColor = Color.Chocolate;
            lblShow.Text = DateTime.Now.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
