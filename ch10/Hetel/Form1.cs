using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hetel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] rooms = new string[] { "標準雙人房", "豪華雙人房", "標準家庭房", "豪華家庭房" };
        int[] price = new int[] { 3000, 4000, 4000, 5000 };
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 3; i++)
            {
                cboRoom.Items.Add(rooms[i] + price[i].ToString() + " 元");
            }
            cboRoom.SelectedIndex = 0;      //預設房型為標準雙人房
            mcnDate.MinDate = DateTime.Today;       //可入住的最早日期為今天
            mcnDate.SelectionStart = DateTime.Today;  //預設入住日期為今天
            mcnDate.MaxSelectionCount = 4;  //最多可連住4天
            lblMsg.Text = "請先輸入生日，壽星當月入住房價打9折";
        }

        private void dtpBD_ValueChanged(object sender, EventArgs e)
        {
            lblMsg.Text = $"您的生日是{dtpBD.Value.Month}月{dtpBD.Value.Day}日";
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMsg.Text = $"您選擇的房型是{cboRoom.SelectedItem}";
        }

        private void mcnDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblMsg.Text = $"您入住日期為：{mcnDate.SelectionStart.ToShortDateString()} ~ {mcnDate.SelectionEnd.ToShortDateString()}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lblMsg.Text = $"入住房型為：{rooms[cboRoom.SelectedIndex]}";
            double room_price = price[cboRoom.SelectedIndex];
            if (dtpBD.Value.Month == mcnDate.SelectionStart.Month)
            {
                room_price *= 0.9;
                lblMsg.Text += "\n\n壽星入住房價打九折!";
            }
            int days = (mcnDate.SelectionEnd.Subtract(mcnDate.SelectionStart)).Days + 1;
            lblMsg.Text += $"\n\n入住天數為：{days} 天";
            lblMsg.Text += $"\n\n房價總計為：{days * room_price} 元";
        }
    }
}
