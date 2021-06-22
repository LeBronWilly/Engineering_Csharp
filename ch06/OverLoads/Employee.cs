using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoads
{
    class Employee
    {
        public string EmpID { get; set; }       //EmpID 為編號屬性
        public string EmpName { get; set; }    //EmpName 為姓名屬性
        private int empSalary;     //私有欄位成員
        public int EmpSalary      //將私有共用欄位改屬性，並作薪資範圍檢查
        {
           get
           {
              return empSalary;
           }
           set
           {
              if (value< 23800)
                 value = 23800;    //若value小於23800,則指定value為23800
              empSalary = value;
              Console.WriteLine($"== 薪資範圍檢查結果 : empSalary = {empSalary}");    
           } 
        }
        public Employee()         //預設建構式
        {
           EmpID = "送審中";
           EmpName = "姓名未知";
           EmpSalary = 0;         //自動執行第8~21行薪資範圍檢查
        }
        public Employee(string vID, string vName, int vSalary)   //三個引數的建構式
        {
           EmpID = vID;
           EmpName = vName;
           EmpSalary = vSalary;    //自動執行第8~21行薪資範圍檢查
        }
        //ShowInfo()多載方法1-無引數僅可顯示員工資訊資訊
        public void ShowInfo()
        {
           Console.WriteLine($"編號：{EmpID}");
           Console.WriteLine($"姓名：{EmpName}");
           Console.WriteLine($"薪資：{EmpSalary}元");
           Console.WriteLine("============================");
        }
        //ShowInfo()多載方法2-有引數可設定員工編號, 姓名, 薪資並顯示員工資訊
        public void ShowInfo(string vID, string vName, int vSalary)
        {
           EmpID = vID;
           EmpName = vName;
           EmpSalary = vSalary;    //自動執行第8~21行薪資範圍檢查
           ShowInfo();     //呼叫Employee.cs第35~41行ShowInfo()方法
        }
    }
}
