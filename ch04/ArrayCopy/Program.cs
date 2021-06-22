using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] srcary = new int[] { 10, 20, 30, 40, 50, 60 };
            int[] dstary = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Array.Copy(srcary, 2, dstary, 5, 3);
            Console.WriteLine(" 來源陣列      目的陣列");
            for (int k = 0; k <= 10; k++)
            {
                if (k <= 5)
                {
                    Console.WriteLine($"srcary[{k}]={srcary[k]}  dstary[{k}]={dstary[k]}");
                }
                else
                {
                    Console.WriteLine($"              dstary[{k}]={dstary[k]}" );
                }
            }
            Console.Read();
        }
    }
}
