using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employee[] emp = new Employee[5];
        //List<Employee> emp = new List<Employee>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //emp.Add( new Employee
            //{
            //    姓名 = "菜一林",
            //    信箱 = "jolin@yahoo.com.tw",
            //    是否已婚 = false,
            //    員工編號 = "E001",
            //    雇用日期 = new DateTime(2007, 1, 1),
            //    薪資 = 65000
            //});
            //emp.Add(new Employee
            //{
            //    姓名 = "林字祥",
            //    信箱 = "kklao@yahoo.com.tw",
            //    是否已婚 = true,
            //    員工編號 = "E002",
            //    雇用日期 = new DateTime(2006, 1, 1),
            //    薪資 = 75000
            //});
            //emp.Add(new Employee
            //{
            //    姓名 = "周傑輪",
            //    信箱 = "jackcc@yahoo.com.tw",
            //    是否已婚 = false,
            //    員工編號 = "E003",
            //    雇用日期 = new DateTime(2008, 1, 1),
            //    薪資 = 55000
            //});
            //emp.Add(new Employee
            //{
            //    姓名 = "王建名",
            //    信箱 = "wange@yahoo.com.tw",
            //    是否已婚 = true,
            //    員工編號 = "E004",
            //    雇用日期 = new DateTime(2006, 5, 3),
            //    薪資 = 105000
            //});
            //emp.Add(new Employee
            //{
            //    姓名 = "李五六",
            //    信箱 = "finde@yahoo.com.tw",
            //    是否已婚 = false,
            //    員工編號 = "E005",
            //    雇用日期 = new DateTime(2008, 5, 2),
            //    薪資 = 45000
            //});
            emp[0] = new Employee
            {
                姓名 = "菜一林",
                信箱 = "jolin@yahoo.com.tw",
                是否已婚 = false,
                員工編號 = "E001",
                雇用日期 = new DateTime(2007, 1, 1),
                薪資 = 65000
            };
            emp[1] = new Employee
            {
                姓名 = "林字祥",
                信箱 = "kklao@yahoo.com.tw",
                是否已婚 = true,
                員工編號 = "E002",
                雇用日期 = new DateTime(2006, 1, 1),
                薪資 = 75000
            };
            emp[2] = new Employee
            {
                姓名 = "周傑輪",
                信箱 = "jackcc@yahoo.com.tw",
                是否已婚 = false,
                員工編號 = "E003",
                雇用日期 = new DateTime(2008, 1, 1),
                薪資 = 55000
            };
            emp[3] = new Employee
            {
                姓名 = "王建名",
                信箱 = "wange@yahoo.com.tw",
                是否已婚 = true,
                員工編號 = "E004",
                雇用日期 = new DateTime(2006, 5, 3),
                薪資 = 105000
            };
            emp[4] = new Employee
            {
                姓名 = "李五六",
                信箱 = "finde@yahoo.com.tw",
                是否已婚 = false,
                員工編號 = "E005",
                雇用日期 = new DateTime(2008, 5, 2),
                薪資 = 45000
            };
            richTextBox1.Text = "編號\t姓名\t信箱\t\t\t雇用日期\t薪資\t是否已婚\n";
            richTextBox1.Text +=
               "========================================================================\n";
            var result = from p in emp
                         select p;
            foreach (var p in result)
            {
                richTextBox1.Text += $"{p.員工編號}\t{p.姓名}\t{p.信箱}\t" +
                    $"{p.雇用日期.ToShortDateString()}\t\t{p.薪資}\t{p.是否已婚}\n";
            }

        }

        private void btnEmpId_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "編號\t姓名\t信箱\t\t\t雇用日期\t薪資\t是否已婚\n";
            richTextBox1.Text +=
            "========================================================================\n";
            var result = from p in emp
                         orderby p.員工編號 ascending
                         select p;
            foreach (var p in result)
            {
                richTextBox1.Text += $"{p.員工編號}\t{p.姓名}\t{p.信箱}\t" +
                     $"{p.雇用日期.ToShortDateString()}\t\t{p.薪資}\t{p.是否已婚}\n";
            }
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "編號\t姓名\t信箱\t\t\t雇用日期\t薪資\t是否已婚\n";
            richTextBox1.Text +=
                       "========================================================================\n";
            var result = from p in emp
                         orderby p.薪資 ascending
                         select p;
            foreach (var p in result)
            {
                richTextBox1.Text += $"{p.員工編號}\t{p.姓名}\t{p.信箱}\t" +
                     $"{p.雇用日期.ToShortDateString()}\t\t{p.薪資}\t{p.是否已婚}\n";
            }

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "編號\t姓名\t信箱\t\t\t雇用日期\t薪資\t是否已婚\n";
            richTextBox1.Text +=
                "========================================================================\n";
            var result = from p in emp
                         orderby p.雇用日期 ascending
                         select p;
            foreach (var p in result)
            {
                richTextBox1.Text += $"{p.員工編號}\t{p.姓名}\t{p.信箱}\t" +
                     $"{p.雇用日期.ToShortDateString()}\t\t{p.薪資}\t{p.是否已婚}\n";
            }

        }

        private void btnSelEmpById_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            var result = from p in emp
                         where p.員工編號 == txtEmpId.Text
                         select new
                         {
                             p.員工編號,
                             p.姓名,
                             p.信箱,
                             p.薪資
                         };
            if (result.Count() == 0)        //判斷查詢的結果是否為零筆
            {
                MessageBox.Show("沒有此員工");
                return;
            }
            foreach (var p in result)
            {
                richTextBox1.Text += $"編號：{p.員工編號}\n" ;
                richTextBox1.Text += $"姓名：{p.姓名}\n"  ;
                richTextBox1.Text += $"信箱：{p.信箱}\n"  ;
                richTextBox1.Text += $"薪資：{p.薪資}"  ;
            }
        }
    }
}
