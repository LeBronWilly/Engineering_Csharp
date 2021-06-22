using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 		//匯入System.IO命名空間

namespace CreateFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string msg = "";     //顯示的訊息
            DirectoryInfo dirNet = new DirectoryInfo("c:\\net");
            if (dirNet.Exists == false) //若c:\net目錄不存在
                dirNet.Create();        //新增c:\net目錄
            string fName;   //檔案名稱
            for (int i = 1; i <= 3; i++)
            {
                fName = @"c:\net\test" + i.ToString() + ".txt";
                FileInfo finTest = new FileInfo(fName); //宣告FileInfo類別物件finTest
                if (finTest.Exists == false) //若檔案不存在
                {
                    FileStream fs = finTest.Create();   //新增檔案
                    msg += $"{Environment.NewLine}{fName} 檔案建立成功！";
                    fs.Close();     //關閉FileStream物件
                }
            }
            try
            {
                if (Directory.Exists(@"c:\net2") == false)  //若c:\net2目錄不存在
                    Directory.CreateDirectory(@"c:\net2");  //新增目錄
                string[] files = Directory.GetFiles("c:\\net"); //取得目錄內檔案名稱
                foreach (string f in files) //逐一讀取檔案名稱陣列
                {   //改變副檔名
                    fName = Path.ChangeExtension(Path.GetFileName(f), "dat");
                    File.Copy(Path.Combine(@"c:\net", f),
                                Path.Combine(@"c:\net2", fName), true);//複製檔案
                    msg += $"{Environment.NewLine}{fName} 檔案複製成功！";
                }
            }
            catch
            {
                msg += $"{Environment.NewLine}檔案複製失敗！";
            }
            MessageBox.Show(msg);
            Directory.Delete(@"c:\net", true);  //刪除net目錄
            Directory.Delete(@"c:\net2", true); 	//刪除net2目錄
        }
    }
}
