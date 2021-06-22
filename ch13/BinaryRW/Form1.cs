using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BinaryRW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool first = false;     //是否為第一次使用
        string userName = "";   //使用者帳號
        int passWord;           //使用者密碼

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("user.bin") == false) //若檔案不存在
            {
                first = true;   //設為第一次使用
                lblMsg.Text = "請建立帳號(英文)和密碼(第1碼非零的整數)";
            }
            else    //若檔案已經存在
            {
                first = false;   //設為非第一次使用
                using (BinaryReader br = new BinaryReader(new FileStream("user.bin", FileMode.Open, FileAccess.Read)))
                {
                    userName = br.ReadString(); //讀取字串資料-帳號
                    passWord = br.ReadInt32();  //讀取整數資料-密碼
                    lblMsg.Text = "請輸入帳號和密碼後，按確定鈕登入";
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (first == true)  //若是第一次使用
            {
                FileStream fs = new FileStream("user.bin", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(txtUser.Text);     //寫入帳號(字串)
                bw.Write(int.Parse(txtPW.Text));  //寫入密碼(整數)
                bw.Flush(); //清空緩衝區
                bw.Close(); fs.Close(); //關閉占用資源
                lblMsg.Text = "帳號和密碼建立完成。";
            }
            else  //若非第一次使用
            {
                if (txtUser.Text == userName && int.Parse(txtPW.Text) == passWord)
                    lblMsg.Text = "登入成功！";
                else
                    lblMsg.Text = "帳號或密碼錯誤！";
            }
        }
    }
}
