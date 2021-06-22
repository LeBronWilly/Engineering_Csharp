using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void CheckYear(int y)
        {
            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
            {
                Console.WriteLine($"\n=== {y} 年 為 閏年! ===");
            }
            else
            {
                Console.WriteLine($"\n=== {y} 年 為 平年! ===");
            }
        }
        static void Main(string[] args)
        {
            int year;  //宣告year用來存放年份
            Console.Write("請輸入年份:");
            if (int.TryParse(Console.ReadLine(), out year))
            {
                CheckYear(year);
            }
            else
            {
                Console.WriteLine("輸入字串格式不正確");
            }
            Console.Read();
        }
    }
}
