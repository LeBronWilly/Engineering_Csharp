using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMember
{
    class Employee
    {
        public string EmpID { get; set; }
        public string EmpName { get; set; }
        private int empSalary;   	         //empSalary為私有欄位成員       
        public int EmpSalary
        {
            get
            { return empSalary; }
            set
            {
                if (value < 23800)
                    value = 23800;   //若value小於23800,則指定value為23800
                empSalary = value;
            }
        }
        // -----------------------------------------------------------
        private static int num;      //num為私有靜態成員用來記錄共建幾個物件
        public static int Num         //欄位變屬性
        {
            get { return num; }      //唯讀屬性
        }
        // -----------------------------------------------------------
        public static void ShowNum()   //定義的方法成員
        {
            Console.WriteLine($"目前共建立 {num} 位員工資料!!\n");
        }

        // --------------------------------------------------------------- 
        public void ShowInfo()   //無引數的ShowInfo()方法多載, 可顯示員工資訊
        {
            Console.WriteLine($"編號：{EmpID}");
            Console.WriteLine($"姓名：{EmpName}");
            Console.WriteLine($"薪資：{EmpSalary}元");
            Console.WriteLine("============================");
        }
        //有引數的ShowInfo()方法多載, 可設定及顯示員工的編號, 姓名, 薪資資訊
        public void ShowInfo(string vID, string vName, int vSalary)
        {
            EmpID = vID;
            EmpName = vName;
            EmpSalary = vSalary;
            ShowInfo();              //呼叫Employee類別的ShowInfo()方法
        }
        // -----無引數的Employee建構函式-------------------------------
        public Employee()
        {
            num += 1;
            EmpID = "送審中";
            EmpName = "姓名未知";
            EmpSalary = 0;
        }
        // ------------- 有引數Employee建構式 --------------------------- 
        public Employee(string vID, string vName, int vSalary)
        {
            num += 1;
            EmpID = vID;
            EmpName = vName;
            EmpSalary = vSalary;
        }
    }
}
