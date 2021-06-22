using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoads
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee anyone = new Employee(); //呼叫上面程式第22~27行預設建構式
            anyone.ShowInfo();
            Console.WriteLine("送審中的員工姓名更新後...");
            anyone.ShowInfo("D0007", "劉鑫金", 30000);
            //執行第12行時自動呼叫上面程式第28~33行有引數建構式
            Employee person1 = new Employee("A0023", "林婉兒", 37000);
            person1.ShowInfo();
            Console.Read();
        }
    }
}
