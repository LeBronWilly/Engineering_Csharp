using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method3
{
    class Program
    {
        static void CheckYear(int y, ref string s1)
        {
            if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0)
            {
                s1 = "閏年!";
            }
            else
            {
                s1 = "平年!";
            }
        }
        static void Main(string[] args)
        {
            int year;  //宣告year用來存放年份
            string str1 = "";
            Console.Write("請輸入年份:");
            if (int.TryParse(Console.ReadLine(), out year))
            {
                CheckYear(year, ref str1);
                Console.WriteLine($"\n=== {year}年為{str1} === " );
            }
            else
            {
                Console.WriteLine("輸入字串格式不正確");
            }
            Console.Read();
        }
    }
}
