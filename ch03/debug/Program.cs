using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debug
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,  k, sum = 0;
            k = 11;
            // k 開始為11，每次累加5；sum累加1，2，3
            for(i = 1; i <= 3; i++)
            {
                k += 5;
                sum += i;
                Console.WriteLine($"i={i} , k={k}");  // 顯示k每次累加5的結果
            }
            Console.WriteLine($"i={i} , sum =  {sum}");  // 顯示sum的結果
            Console.Read();
        }
    }
}
