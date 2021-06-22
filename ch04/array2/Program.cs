using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ary1 = new int[] { 1, 2, 3, 4, 5 };
            int[,] ary2 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            Console.WriteLine();
            Console.WriteLine("讀取 ary1 一維陣列");
            for (int i = 0; i <= ary1.GetUpperBound(0); i++)
            {
                Console.Write($"ary[{i}]={ary1[i]}   " );
            }
            Console.WriteLine();
            Console.WriteLine("讀取 ary2 二維陣列");
            for (int i = 0; i <= ary2.GetUpperBound(ary2.Rank - 2); i++)
            {
                for (int j = 0; j <= ary2.GetUpperBound(ary2.Rank - 1); j++)
                {
                    Console.Write($"ary[{i},{j}]={ary2[i, j]}   " );
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
