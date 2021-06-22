using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectSetValue
{
    class Employee
    {
        public string EmpID { set; get; }
        public string EmpName { set; get; }
        public string EmpTel { set; get; }
        public string EmpAdd { set; get; }
        private int empSalary;		   //empSalary薪資欄位
        public int EmpSalary           //薪資欄位改屬性並限制薪資大於23800
        {
           get
           {
              return empSalary;
           }
           set
           {
              if (value< 23800)  value = 23800; 
              empSalary = value;
           }
        }
        //顯示員工資訊
        public void ShowInfo()
        {
           Console.WriteLine($"編號：{EmpID}");
           Console.WriteLine($"姓名：{EmpName}");
           Console.WriteLine($"電話：{EmpTel}");
           Console.WriteLine($"住址：{EmpAdd}");
           Console.WriteLine($"薪資：{EmpSalary}");
           Console.WriteLine("===========================");
        }
    }
}
