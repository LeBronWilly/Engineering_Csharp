using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dbEmployeeEntities db = new dbEmployeeEntities();

        //  ------   表單載入時執行   -------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            txtEmpId.Text = txtName.Text = txtEmail.Text = txtSalary.Text = "";
            dataGridView1.DataSource = db.員工
                .OrderByDescending(m=>m.員工編號).ToList();
        }
        //  ------   按下 [新增] 鈕執行   -------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                員工 emp = new 員工();
                emp.員工編號 = txtEmpId.Text;
                emp.姓名 = txtName.Text;
                emp.信箱 = txtEmail.Text;
                emp.薪資 = int.Parse(txtSalary.Text);
                emp.雇用日期 = DateTime.Parse(dtpDate.Value.ToShortDateString());
                emp.是否已婚 = chkIsMarry.Checked;
                db.員工.Add(emp);
                db.SaveChanges();
                Form1_Load(sender, e); 
                MessageBox.Show("新增成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"新增失敗\n錯誤訊息：{ex.Message}");
            }
        }
        //  ------   按下 [修改] 鈕執行   -------------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = db.員工
                    .Where(m => m.員工編號 == txtEmpId.Text)
                    .FirstOrDefault();
                if (emp != null)
                {
                    emp.姓名 = txtName.Text;
                    emp.信箱 = txtEmail.Text;
                    emp.薪資 = int.Parse(txtSalary.Text);
                    emp.雇用日期 = DateTime.Parse(dtpDate.Value.ToShortDateString());
                    emp.是否已婚 = chkIsMarry.Checked;
                    db.SaveChanges();
                    Form1_Load(sender, e);
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show($"找不到員工編號{txtEmpId.Text}的記錄");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改成功\n錯誤訊息：{ex.Message}");
            }
        }
        //  ------   按下 [刪除] 鈕執行   -------------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                var emp = db.員工
                    .Where(m => m.員工編號 == txtEmpId.Text)
                    .FirstOrDefault();
                if (emp != null)
                {
                    db.員工.Remove(emp);
                    db.SaveChanges();
                    Form1_Load(sender, e);
                    MessageBox.Show("刪除成功");
                }
                else
                {
                    MessageBox.Show($"找不到員工編號{txtEmpId.Text}的記錄");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除成功\n錯誤訊息：{ex.Message}");
            }
        }
    }
}
