using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{
    class Program
    {
        static int fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return (fib(n - 1) + fib(n - 2));
            }
        }
        static void Main(string[] args)
        {
            int keyin;
            Console.Write("  請輸入欲顯示到第幾個費波南希係數： ");
            if (int.TryParse(Console.ReadLine(), out keyin))
            {
                Console.WriteLine("\n === 費氏數列：\n");
                Console.Write("     ");
                for (int i = 1; i <= keyin; i++)
                {
                    Console.Write($"{fib(i)}  ");
                }
            }
            else
            {
                Console.WriteLine("輸入值無法轉換成整數!!");
            }
            Console.Read();
        }
    }
}
