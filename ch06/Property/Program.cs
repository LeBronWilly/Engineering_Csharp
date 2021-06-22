using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1;             //宣告person1物件屬於Employee類別
            person1 = new Employee();     //建立person1物件
            person1.empID = "A0023";      //設定編號欄位
            person1.empName = "林婉兒";   //設定姓名欄位
            person1.EmpSalary = 37000;    //設定薪資欄位自動執行上一程式
                                          //第7-21行薪資檢查
            person1.ShowInfo();           //呼叫上一程式第23-29行方法
            
            Employee person2 = new Employee();  //宣告並建立person2物件
            person2.empID = "B0104";
            person2.empName = "王柏仁";
            person2.EmpSalary = 19000;    //執行此行會自動執行上一程式
                                          //第7-21行作薪資檢查
            person2.ShowInfo();           //呼叫上一程式第23-29行方法
            
            Console.Read();
        }
    }
}
