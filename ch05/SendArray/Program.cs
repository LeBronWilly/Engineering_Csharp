using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendArray
{
    class Program
    {
        static int GetMax(ref int[] tempAry) // ref可省略
        {
            int max = tempAry[0];
            foreach (int temp in tempAry)
            {
                if (temp > max)
                    max = temp;
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] ary = new int[] { 10, -88, -6, 34, 27 };
            Console.Write("ary陣列為 --> ");
            for (int i = 0; i <= ary.GetUpperBound(0); i++)
            {
                Console.Write($"{ary[i]} " );
            }
            Console.WriteLine();
            Console.WriteLine($"\nary陣列最大數為：{GetMax(ref ary)}" ); // ref以及[]可省略
            Console.Read();
        }
    }
}
