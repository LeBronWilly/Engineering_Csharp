using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   //設定開檔對話方塊的檔名篩選字串
            openFileDialog1.Filter = "Rich Text(*.rtf)|*.rtf";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.DefaultExt = ".rtf";    //設定存檔時的預設副檔名為rtf
            fontDialog1.MinSize = 30;
            fontDialog1.MaxSize = 60;//設字型大小範圍
            rtbShow.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {   //若在開檔對話方塊按<確定>鈕，就開啟指定的檔案
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbShow.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("開檔成功！");
                rtbShow.ForeColor = rtbShow.SelectionColor; //設前景色和目前顏色相同
                rtbShow.Font = rtbShow.SelectionFont;       //設字型和目前字型相同
                rtbShow.Text += "　　";
                mnuWord.Text = rtbShow.Text;       //設ttxtWord文字和rtbShow相同
                tmrMove.Start(); //啟動計時器
            }
        }

        private void tmrMove_Tick(object sender, EventArgs e)
        {
            string s = rtbShow.Text;
            rtbShow.Text = s.Substring(1, s.Length - 1) + s.Substring(0, 1);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {   //若在存檔對話方塊按確定鈕，就儲存指定的檔案
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbShow.Text = mnuWord.Text.Replace("　", "");
                //rtbShow.Text = rtbShow.Text.Replace("　", "");
                rtbShow.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("存檔成功！");
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {   // 若在字型對話方塊按確定鈕，就設定選取文字的字型
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                rtbShow.Font = fontDialog1.Font;
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {   // 若在色彩對話方塊按確定鈕，就設定選取文字的前景色
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                rtbShow.ForeColor = colorDialog1.Color;
        }

        private void mnuText_Click(object sender, EventArgs e)
        {
            mnuWord.Text += "　　";  //加兩個全形空白字元
            rtbShow.Text = mnuWord.Text;       //設rtbShow文字和ttxtWord相同
            tmrMove.Start(); //啟動計時器
        }

        private void rtbShow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
