using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Label[] lbls = new Label[7]; //宣告Label控制項陣列lbls，大小為7

        private void Form1_Load(object sender, EventArgs e)
        {   //指定lbls控制項陣列的元素值
            lbls[0] = lblDo;
            lbls[1] = lblRe;
            lbls[2] = lblMi;
            lbls[3] = lblFa;
            lbls[4] = lblSol;
            lbls[5] = lblLa;
            lbls[6] = lblSi;
            for (int i = 1; i < lbls.Length; i++) //使用for迴圈訂閱事件
                lbls[i].Click += lblDo_Click;
        }

        private void lblDo_Click(object sender, EventArgs e)
        {   //宣告freg整數陣列，元素值為各音階的頻率
            int[] freq = new int[] { 262, 294, 330, 349, 392, 440, 493 };
            Label lbl = (Label)sender;    //sender轉型為Label在指定給lbl
            for (int i = 0; i < lbls.Length; i++) //使用for迴圈逐一檢查控制項陣列
                if (lbl.Equals(lbls[i]))        //如果等於對應的標籤控制項
                    Console.Beep(freq[i], 500); //播放對應的音階
        }

        private void lblRe_Click(object sender, EventArgs e)
        {

        }
    }
}
