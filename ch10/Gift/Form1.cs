using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gift
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[][] gift = new string[4][]; //建立gift不規則陣列
        private void Form1_Load(object sender, EventArgs e)
        {
            gift[0] = new string[] { "鳳梨酥", "古早味肉乾" };
            gift[1] = new string[] { "芋頭酥", "烏龍茶", "奶油酥餅" };
            gift[2] = new string[] { "烏魚子", "豬腳", "牛軋糖", "肉紙" };
            gift[3] = new string[] { "三星蔥蛋捲", "牛舌餅", "小米麻糬" };
            string[] area = new string[] { "北部", "中部", "南部", "東部" };
            cboArea.Items.AddRange(area);   //載入地區項目
            cboArea.SelectedIndex = 0;      //預設選取第一個地區項目
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstGift.Items.Clear();  //將伴手禮項目清除
            lstGift.Items.AddRange(gift[cboArea.SelectedIndex]);//載入地區對應的伴手禮項目
            lstGift.SelectedIndex = 0;//預設選取第一個伴手禮項目
        }

        private void lstGift_SelectedIndexChanged(object sender, EventArgs e)
        {
            picGift.Load(lstGift.SelectedItem + ".jpg");
        }
    }
}
