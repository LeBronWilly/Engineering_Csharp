using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("請輸入第一個整數(num1) ：");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("請輸入第二個整數(num2) ：");
            num2 = Convert.ToInt32(Console.ReadLine());
            // 判斷 num1 是否等於 num2
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} = {num2}");
            }
            else  // num1 不等於 num2 則執行下面程式區塊
            {
                if(num1 > num2)  // 判斷 num1 是否大於 num2
                {
                    Console.WriteLine($"{num1} > {num2}");
                }
                else
                {
                    Console.WriteLine($"{num1} < {num2}");
                }
            }
            Console.Read();
        }
    }
}
