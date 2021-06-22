using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoadImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {   //開啟檔案資料流
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs); //建立二進位資料流讀取器
                long size = br.BaseStream.Length;       //取得資料流的長度
                byte[] imageData = new byte[size];      //建立位元組陣列，大小等於資料流的長度
                imageData = br.ReadBytes((int)size);    //讀取資料流的全部長度到陣列
                picShow.Image = Image.FromStream(fs);   //指定影像來源為fs資料流
                br.Close(); fs.Close();  //關閉資料流
            }
        }
    }
}
