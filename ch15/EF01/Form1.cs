using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dbEmployeeEntities db = new dbEmployeeEntities();
        // ------ 表單載入時執行此事件處理函式  -----------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            var result = db.員工.ToList();

            dataGridView1.DataSource = result;

            lblShow.Text = $"最高薪資：{result.Max(m => m.薪資)}\n" +
                 $"最低薪資：{result.Min(m => m.薪資)}\n" +
                 $"平均薪資：{(int)result.Average(m => m.薪資)}\n" +
                 $"薪資加總：{result.Sum(m => m.薪資)}";
            lblShow.BorderStyle = BorderStyle.Fixed3D;
            lblShow.BackColor = Color.Pink;
        }

        // ------  按員工編號鈕執行此事件處理函式  ----------------------
        private void btnEmpId_Click(object sender, EventArgs e)
        {
            var result = db.員工.OrderBy(m => m.員工編號).ToList();
            dataGridView1.DataSource = result;
        }

        // ------  按薪資鈕執行此事件處理函式  ---------------------------
        private void btnSalary_Click(object sender, EventArgs e)
        {
            var result = db.員工.OrderBy(m => m.薪資).ToList();
            dataGridView1.DataSource = result;
        }

        // ------   按雇用日期鈕執行此事件處理函式  ------------------------
        private void btnDate_Click(object sender, EventArgs e)
        {
            var result = db.員工.OrderBy(m => m.雇用日期).ToList();
            dataGridView1.DataSource = result;
        }

        // ------ 按單筆查詢鈕執行此事件處理函式  ------------------------
        private void btnSelEmpById_Click(object sender, EventArgs e)
        {
            var result = db.員工
              .Where(m => m.員工編號 == txtEmpId.Text)
              .FirstOrDefault();
            if (result != null)
            {
                string str = $"編號：{result.員工編號}\n" +
                  $"姓名：{result.姓名}\n" +
                  $"信箱：{result.信箱}\n" +
                  $"薪資：{result.薪資}";
                MessageBox.Show(str);
            }
            else
            {
                MessageBox.Show("沒有此員工");
                return;
            }
        }

    }
}
