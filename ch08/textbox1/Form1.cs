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
                txtOut.Text = $"{us * 30.3}元";
            else
                txtIn.Text = "0";
        }
    }
}
