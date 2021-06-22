using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoads
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
        static int GetMax(int a, int b, int c)
        {
            int max;
            if (a > b)
            {
                if (a > c) 
                    max = a;
                else 
                    max = c;
            }
            else
            {
                if (b > c) 
                    max = b;
                else 
                    max = c;
            }
            return max;
        }
        static int GetMax(int[] a)
        {
            int i, max;
            max = a[0];
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > max) max = a[i];
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] n = new int[] { 34, -66, 19, 48, 1 };
            Console.WriteLine($"5 和 7 之最大數為 {GetMax(5, 7)}" );
            Console.WriteLine($"20,-53,9 之最大數為 {GetMax(20, -53, 9)}" );
            Console.WriteLine($"陣列(34, -66, 19, 48, 1)中最大數為 {GetMax(n)}" );
            Console.Read();
        }
    }
}
