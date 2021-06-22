using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee("A0023", "林婉兒", 37000);
            person1.ShowInfo();
            Employee.ShowNum();       //呼叫static成員ShowNum()方法
            Employee person2 = new Employee();
            person2.ShowInfo("B0104", "王柏仁", 19000);
            //呼叫Employee類別的Num靜態屬性
            Console.WriteLine("目前建立第 {0} 位員工資料!!", Employee.Num);
            Console.Read();
        }
    }
}
