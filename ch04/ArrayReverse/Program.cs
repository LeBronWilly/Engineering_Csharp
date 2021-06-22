using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[6] { "陳一", "徐二", "張三", "李四", "王五", "趙六" };
            int[] avg = new int[6] { 80, 56, 95, 63, 50, 79 };
            Console.WriteLine(" === 排序前 === ");
            for (int k = 0; k <= avg.GetUpperBound(0); k ++)
            {
                Console.WriteLine($" name[{k}] = {name[k]} avg[{k}] = {avg[k]}");
            }
            Console.WriteLine();
            Array.Sort(avg, name);  // 由小到大排序avg陣列與name陣列
            Array.Reverse(avg);
            Array.Reverse(name);
            Console.WriteLine(" === 排序後 === ");
            Console.WriteLine("       姓名           學期成績 \t 名次 ");
            for (int k = 0; k <= avg.GetUpperBound(0); k ++)
            {
                Console.WriteLine($" name[{k}] = {name[k]} avg[{k}] = {avg[k]} \t {k+1}");

            }
            Console.Read();
        }
    }
}
