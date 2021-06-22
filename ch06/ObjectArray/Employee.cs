using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray
{
    class Employee
    {
        private static int num;	// num為私有靜態欄位成員，用來記錄共產生幾個物件
        public string EmpID { get; set; }          
        public string EmpName { get; set; }    
        private int empSalary;         //empSalary為私有欄位成員
        public int EmpSalary           //欄位改屬性成員並作薪資範圍檢查 
        {
           get
           { return empSalary; }
           set
           {
              if (value< 23800)
                 value = 23800;     //若value小於23800,則指定value為23800
              empSalary = value;
           }
        }  
        //顯示共建立幾個員工記錄的靜態方法成員
        public static void ShowNum()
        {
           Console.WriteLine($"目前共建立 {num} 個員工記錄!!\n");
        }
        //無引數的Employee預設建構式
        public Employee()
        {
           num += 1;      //物件數量累加1
        }
        //此ShowInfo()多載方法可顯示員工資訊
        public void ShowInfo()
        {
           Console.WriteLine($"編號：{EmpID}");
           Console.WriteLine($"姓名：{EmpName}");
           Console.WriteLine($"薪資：{EmpSalary}元");
           Console.WriteLine("============================");
        }    
    }
}
