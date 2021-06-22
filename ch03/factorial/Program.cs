using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int keyin, num, factorial = 1;
            Console.Write("請輸入整數: ");
            keyin = int.Parse(Console.ReadLine()); //將輸入整數指定給keyin
            num = keyin;			// 將keyin指定給num
            while (num >= 1)        // 計算num!階乘
            {
                factorial *= num;
                num -= 1;
            }
            Console.WriteLine($"{keyin}! = {factorial} " );  // 顯示階乘結果
            Console.Read();
        }
    }
}
