using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectArray
{
    class Program
    {
        static void Main(string[] args)
        {
            try   //監控可能會發生例外的程式碼
            {
                Console.Write("請輸入欲產生幾個員工記錄：");
                int n = int.Parse(Console.ReadLine());  //輸入的資料轉型成整數
                Employee[] per = new Employee[n];   //產生per[0]~per[n-1]陣列元素
                for (int i = 0; i <= per.GetUpperBound(0); i++)
                {
                    per[i] = new Employee();                //建立per[i] 物件的實體
                    Console.WriteLine($"請輸入第 {i + 1} 筆員工記錄");
                    Console.Write(" 編號：");
                    per[i].EmpID = Console.ReadLine();   //輸入編號
                    Console.Write(" 姓名：");
                    per[i].EmpName = Console.ReadLine();     //輸入姓名
                    Console.Write(" 薪資：");
                    per[i].EmpSalary = int.Parse(Console.ReadLine());//輸入數量轉整數
                    Console.WriteLine("---------------------------");
                    Console.WriteLine($"顯示第 {i + 1} 筆員工記錄");
                    per[i].ShowInfo();
                }
                Employee.ShowNum();     //顯示共產生幾個員工記錄
            }
            catch (Exception ex)    //補捉並處理例外
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("輸入資料有誤, 準備離開程式!");
            }
            Console.Read();
        }
    }
}
