using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEventTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int form_left, form_top, form_width, form_height;

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Location = new Point(form_left, form_top);
            this.Size = new Size(form_width, form_height);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Left += 20;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Width += 10;
            this.Height -= 10;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form_left = this.Left;
            form_top = this.Top;
            form_width = this.Width;
            form_height = this.Height;
            this.Text = "表單事件測試";
        }
    }
}
