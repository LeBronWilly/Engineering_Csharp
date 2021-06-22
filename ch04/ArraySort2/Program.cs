using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort2
{
    class Program
    {
        static void Main(string[] args)
        {
            //學生姓名name陣列
            string[] name = new string[6] { "陳一", "徐二", "張三", "李四", "王五", "趙六" };
            //學期成績avg陣列
            int[] avg = new int[6] { 80, 56, 95, 63, 50, 79 };
            Console.WriteLine(" === 排序前 === ");
            for (int k = 0; k <= avg.GetUpperBound(0); k++)
            {
                Console.WriteLine($" name[{k}] = {name[k]}  avg[{k}]={avg[k]}" );
            }
            Console.WriteLine();
            Array.Sort(avg, name);  // name陣列依avg陣列做由小而大排序
            Console.WriteLine(" === 排序後 === ");
            for (int k = 0; k <= avg.GetLength(0) - 1; k++)
            {
                Console.WriteLine($" name[{k}] = {name[k]}   avg[{k}]={avg[k]}" );
            }
            Console.Read();
        }
    }
}
