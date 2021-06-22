using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   // 設定列印相關物件的列印資料來源為printDocument1
            printDialog1.Document = printDocument1;
            pageSetupDialog1.Document = printDocument1;
            printPreviewDialog1.Document = printDocument1;
            txtText.Text = "Visual C#";
            txtText.ScrollBars = ScrollBars.Both;
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {   // 若在色彩對話方塊按確定鈕，就設定文字方塊的前景色
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                txtText.ForeColor = colorDialog1.Color;
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {   // 若在字型對話方塊按確定鈕，就設定文字方塊的字型
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                txtText.Font = fontDialog1.Font;
        }

        private void mnuSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();  //開啟列印格式對話方塊
            //將使用者在列印格式對話方塊的設定值，指定給printDocument1
            printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
        }

        private void mnuPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();  //開啟預覽列印對話方塊
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {   // 若在列印對話方塊按確定鈕，就呼叫printDocument1的Print方法
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics pg = e.Graphics;  //宣告pg為繪圖物件
            //建立pf為字型物件，其值和txtText字型屬性值相同
            Font pf = new Font(txtText.Font.Name, txtText.Font.Size, txtText.Font.Style);
            //建立pb為筆刷物件，其值和txtText的前景色相同
            SolidBrush pb = new SolidBrush(txtText.ForeColor);
            pg.DrawString(txtText.Text, pf, pb, e.MarginBounds);//以DrawString方法繪製文字
        }
    }
}
