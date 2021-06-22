using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] citys = { "臺北市", "新北市", "桃園市", "新竹縣", "苗栗縣",
                    "臺中市", "彰化縣", "南投縣", "雲林縣", "嘉義縣", "臺南市" };
            listBox1.Items.AddRange(citys);  //使用AddRange方法加入項目陣列
            listBox1.SelectionMode = SelectionMode.MultiSimple; //設為多選
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";                       //預設為空字串
            for (int i = 0; i < listBox1.Items.Count; i++)
                if (listBox1.GetSelected(i)) //判斷第i個項目是否被選
                    msg += $"{listBox1.Items[i]}  ,";
            //另一種寫法
            //foreach (string m in listBox1.SelectedItems) //讀選取項目集合值
            //{
            //    msg += $"{m} ,";
            //}
            //使用SelectedIndices的另一種寫法
            //foreach (int i in listBox1.SelectedIndices) //讀選取註標集合值
            //{
            //    msg += $"{listBox1.Items[i]} ,";
            //}

            MessageBox.Show(msg, "選擇縣市");
        }
    }
}
