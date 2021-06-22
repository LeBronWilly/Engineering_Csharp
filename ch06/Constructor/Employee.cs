using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Employee
    {
        public string EmpID { get; set; }  		//EmpID 為編號屬性
        public string EmpName { get; set; } 	//EmpName 為姓名屬性
        private int empSalary;   	   	 	//私有薪資欄位 
        public int EmpSalary            		//薪資欄位改薪資屬性
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
        //含三個引數的Employee建構式
        public Employee(string vID, string vName, int vSalary)
        {
           EmpID = vID;
           EmpName = vName;
           EmpSalary = vSalary;    //執行此行會自動執行第8~21行作薪資範圍檢查
        }

        public void ShowInfo()	   //定義ShowInfo方法用來顯示員工的編號,姓名,薪資
        {
           Console.WriteLine($"編號：{EmpID}");
           Console.WriteLine($"姓名：{EmpName}");
           Console.WriteLine($"薪資：{EmpSalary}元");
           Console.WriteLine("============================");
        }
    }
}
