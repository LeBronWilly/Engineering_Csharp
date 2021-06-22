using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        //表單載入執行
        private void Form1_Load(object sender, EventArgs e)
        {
            var order = db.訂貨主檔.OrderBy(m => m.訂單號碼).ToList();
            dataGridView1.DataSource = order;
            dataGridView1.Dock = DockStyle.Top;
            var orderDetails = db.訂貨明細.ToList();
            dataGridView2.DataSource = orderDetails;
            dataGridView2.Dock = DockStyle.Fill;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var orderDetails = db.訂貨明細.Where(m => m.訂單號碼 == orderId).ToList();
            dataGridView2.DataSource = orderDetails;
        }
    }
}
