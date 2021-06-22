using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee[] emp = new Employee[5];
        private void Form1_Load(object sender, EventArgs e)
        {

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
            var result = emp.OrderBy(m => m.員工編號).ToList(); 
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
            var result = emp.OrderBy(m => m.薪資).ToList();
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
            var result = emp.OrderBy(m => m.雇用日期).ToList();
            foreach (var p in result)
            {
                richTextBox1.Text += $"{p.員工編號}\t{p.姓名}\t{p.信箱}\t" +
                     $"{p.雇用日期.ToShortDateString()}\t\t{p.薪資}\t{p.是否已婚}\n";
            }

        }

        private void btnSelEmpById_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            var result = emp.Where(m => m.員工編號 == txtEmpId.Text).FirstOrDefault();
            if (result != null)        
            {
                richTextBox1.Text += $"編號：{result.員工編號}\n";
                richTextBox1.Text += $"姓名：{result.姓名}\n";
                richTextBox1.Text += $"信箱：{result.信箱}\n";
                richTextBox1.Text += $"薪資：{result.薪資}";
            }
            else
            {
                MessageBox.Show("沒有此員工");
                return;
            }
        }
    }
}
