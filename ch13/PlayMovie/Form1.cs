using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMovie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            wmpMovie.URL = "林義傑篇.AVI";
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuNone_Click(object sender, EventArgs e)
        {
            wmpMovie.uiMode = "None";
        }

        private void mnuMini_Click(object sender, EventArgs e)
        {
            wmpMovie.uiMode = "Mini";
        }

        private void mnuFull_Click(object sender, EventArgs e)
        {
            wmpMovie.uiMode = "Full";
        }

        private void mnuInvisible_Click(object sender, EventArgs e)
        {
            wmpMovie.uiMode = "Invisible";
        }
    }
}
