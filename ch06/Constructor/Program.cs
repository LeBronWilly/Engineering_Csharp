using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee person1 = new Employee();        //無法使用
            //使用建構函式建立物件時給予初值
            Employee person2 = new Employee("B0104", "王柏仁", 19000);
            person2.ShowInfo();
            Console.Read();
        }
    }
}
