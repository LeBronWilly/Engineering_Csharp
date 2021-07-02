using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            picImage.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void btnStretch_Click(object sender, EventArgs e)
        {
            picImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            picImage.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnSheep_Click(object sender, EventArgs e)
        {
            picImage.Image = Image.FromFile("..\\..\\..\\images\\羊.bmp");
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            picImage.Image = new Bitmap(@"..\..\..\images\貓.bmp");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picImage.Image = null;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            picImage.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
