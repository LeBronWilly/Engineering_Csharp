using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {
            float us;
            if (float.TryParse(txtIn.Text, out us))
            {
                txtOut.Text = $"{us * 27.91}元";
                label3.Text = Convert.ToString(txtIn.Text.Length) + "字";
                //label3.Text += "字";
            }

            else
                txtIn.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
