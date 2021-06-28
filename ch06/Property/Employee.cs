using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Employee
    {
        public string empID, empName; // 公用欄位成員
        private int empSalary;        // empSalary為私有欄位成員
        public int EmpSalary          // 將私有欄位改共用屬性
        {
            get
            {
                return empSalary;
            }
            set
            {
                if (value < 23800)
                    value = 23800;      //若value<23800,則指定value為23800
                empSalary = value;
                // 驗證是否有執行set區塊
                Console.WriteLine($"== 薪資範圍檢查結果 : empSalary = {empSalary}");
            }
        }

        public void ShowInfo()  //定義ShowInfo方法用來顯示員工的編號,姓名,薪資
        {
            Console.WriteLine($"編號：{empID}");
            Console.WriteLine($"姓名：{empName}");
            Console.WriteLine($"薪資：{EmpSalary}元");
            Console.WriteLine("============================");
        }
    }
}
