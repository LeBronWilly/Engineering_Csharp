using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboSize.SelectedItem = "10";
            cboFont.SelectedItem = "新細明體";
            rtbText.Font = new Font(cboFont.Text, Convert.ToInt32(cboSize.Text));
        }

        private void cboForeColor_SelectedIndexChanged(object sender, EventArgs e)
        {   //根據cboForeColor選項的索引值設定選取字串的前景色
            switch (cboForeColor.SelectedIndex)
            {
                case 0:
                    rtbText.SelectionColor = Color.Black;
                    break;
                case 1:
                    rtbText.SelectionColor = Color.Red;
                    break;
                case 2:
                    rtbText.SelectionColor = Color.Blue;
                    break;
            }
        }

        private void cboBgColor_SelectedIndexChanged(object sender, EventArgs e)
        {   //根據cboForeColor選項的索引值設定選取字串的背景色
            switch (cboBgColor.SelectedIndex)
            {
                case 0:
                    rtbText.SelectionBackColor = Color.LightGray; break;
                case 1:
                    rtbText.SelectionBackColor = Color.LightPink; break;
                case 2:
                    rtbText.SelectionBackColor = Color.LightGreen; break;
            }
        }

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {   //選取cboSize下拉式清單時重設字型大小
            rtbText.SelectionFont = new Font(cboFont.Text, Convert.ToInt32(cboSize.Text));
            //rtbText.SelectionFont = new Font(cboFont.Text, int.Parse(cboSize.Text));
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {  //選取cboFont下拉式清單時重設字型名稱
            rtbText.SelectionFont = new Font(cboFont.Text, int.Parse(cboSize.Text));
            //rtbText.SelectionFont = new Font(cboFont.Text, Convert.ToInt32(cboSize.Text));
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {   //按開檔鈕將MyFile.rtf檔的內容載入rtbText控制項的Text屬性內
            rtbText.LoadFile("MyFile.rtf", RichTextBoxStreamType.RichText);
            MessageBox.Show("開檔成功!!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {   //按存檔鈕將rtbText的內容存入MyFile.rtf
            rtbText.SaveFile("MyFile.rtf", RichTextBoxStreamType.RichText);
            MessageBox.Show("存檔成功!!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   //按btnClear鈕時將選取的文字清除
            rtbText.SelectedText = "";  //清除選取的文字
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbText_LinkClicked(object sender, LinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";  //清除所有文字
        }
    }
}
