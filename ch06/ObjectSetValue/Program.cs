using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectSetValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee
            {
                EmpID = "A0023",
                EmpName = "林婉兒",
                EmpAdd = "台中市中山路一段38號",
                EmpTel = "04-27549542",
                EmpSalary = 35000
            };
            Employee person2 = new Employee
            {
                EmpID = "B0104",
                EmpName = "王柏仁",
                EmpAdd = "台北市南港路四段209號",
                EmpTel = "02-21438667",
                EmpSalary = 19000
            };
            person1.ShowInfo();   //顯示員工資訊
            person2.ShowInfo();
            Console.Read();
        }
    }
}
