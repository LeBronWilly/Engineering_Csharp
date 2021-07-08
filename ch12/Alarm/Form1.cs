using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int setSec; //紀錄設定的秒數
        int sec;    //倒數的秒數
        int count;
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            ttxtS.Text = "5";          //預設倒數10秒
            tcboDate.SelectedIndex = 0; //預設選擇時間項目
            tcboSet.SelectedIndex = 0;  //預設選擇時鐘項目
            tbtnPause.Text = "暫停";
            tbtnStart.Text = "開始倒數";
        }
        private void tcboSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcboSet.SelectedIndex == 0)
            {
                slblSet.Text = tcboSet.Text;    //設狀態列顯示選擇項目
                if (tcboDate.SelectedIndex == 0)   //若選擇時間項目
                    lblTime.Text = DateTime.Now.ToLongTimeString();
                else
                    lblTime.Text = DateTime.Now.ToLongDateString();
                tbtnPause.Enabled = false;
                tbtnStart.Enabled = false;
                tcboDate.Enabled = true;
                ttxtS.Enabled = false;
                spgbSec.Value = 0;  //設進度棒的值為0
                tmrTime.Start();    //啟動tmrTime計時器
                tmrAlarm.Stop(); //關閉tmrAlarm計時器
            }
            else
            {
                slblSet.Text = tcboSet.Text+"準備";    //設狀態列顯示選擇項目
                lblTime.Text = $"{int.Parse(ttxtS.Text)} 秒";
                //tbtnPause.Enabled = true;
                tbtnStart.Enabled = true;
                tcboDate.Enabled = false;
                ttxtS.Enabled = true;
                tmrTime.Stop();     //關閉tmrTime計時器
            }

        }
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            if (slblSet.Text == "時鐘")   //若狀態列顯示時鐘
            {
                if (tcboDate.SelectedIndex == 0)   //若選擇時間項目
                    lblTime.Text = DateTime.Now.ToLongTimeString();
                else
                    lblTime.Text = DateTime.Now.ToLongDateString();
            }
            else
            {

                if (sec > 0)    //若倒數秒數大於0
                {
                    sec -= 1;   //倒數秒數減1
                    lblTime.Text = $"{sec} 秒";  //顯示倒數秒數
                    spgbSec.Value = setSec - sec;  //設進度棒值
                    tbtnStart.Text = "重新倒數";
                }
                else
                {
                    slblSet.Text = "倒數結束";  //狀態列顯示結束訊息
                    tmrTime.Stop();//關閉tmrTime
                    tmrAlarm.Start();//啟動tmrAlarm計時器
                    tbtnStart.Text = "開始倒數";
                    tbtnPause.Text = "停止嗶聲";
                }
            }
        }

        private void tbtnStart_Click(object sender, EventArgs e)
        {
            count = 0;
            tbtnPause.Text = "暫停";
            tbtnPause.Enabled = true;
            tmrAlarm.Stop();//關閉tmrAlarm計時器
            slblSet.Text = "倒數開始";      //狀態列顯示倒數開始訊息
            setSec = int.Parse(ttxtS.Text); //設定秒數
            lblTime.Text = $"{setSec} 秒";
            sec = setSec;   //倒數秒數
            spgbSec.Maximum = setSec;   //設進度棒的最大值為設定秒數
            spgbSec.Value = 0;  //設進度棒的值為0
            tmrTime.Start();    //啟動tmrTime計時器
        }

        private void tmrAlarm_Tick(object sender, EventArgs e)
        {
            Console.Beep(); //發出嗶聲
        }

        
        private void tbtnPause_Click(object sender, EventArgs e)
        {
            count++;
            if (sec == 0)
            {
                tbtnPause.Text = "暫停";
                tbtnPause.Enabled = false;
                tmrAlarm.Stop();//關閉tmrAlarm計時器
            }
            else if (count % 2 == 1)
            {
                tbtnPause.Text = "繼續倒數";
                //tmrAlarm.Stop();//關閉tmrAlarm計時器
                tmrTime.Stop();//關閉計時器
                slblSet.Text = "倒數暫停";
            }
            else
            {
                tbtnPause.Text = "暫停";
                //setSec = sec;
                tmrTime.Start();    //啟動tmrTime計時器
                slblSet.Text = "倒數繼續";
                //tmrAlarm.Start();//關閉tmrAlarm計時器
            }


        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {

        }
    }
}
