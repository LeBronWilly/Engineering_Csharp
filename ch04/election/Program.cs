using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace election
{
    class Program
    {
        static void Main(string[] args)
        {
            int i= add(3,3), k;
            Console.WriteLine(i);
            string[] name = new string[] { "陳一", "張三", "王五", "Kobe" };
            int[] tot = new int[name.Length];
            int[,] vote = new int[name.Length, 3];
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine($" 第 {i + 1} 鄰各候選人得票數:");
                for (k = 0; k <= name.Length - 1; k++)
                {
                    Console.Write($" {k + 1}. {name[k]} :");
                    vote[k, i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(" ----------------------------------");
            }
            for (k = 0; k <= name.Length - 1; k++)
            {
                for (i = 0; i <= 2; i++)
                {
                    tot[k] += vote[k, i];
                }
            }
            Console.WriteLine(" ==================================");
            Console.WriteLine(" 候選人   第一鄰  第二鄰  第三鄰  總得票數");
            Console.WriteLine(" ==================================");
            for (k = 0; k <= name.Length - 1; k++)
            {
                Console.WriteLine
                    ($" {name[k]} \t {vote[k,0]} \t  {vote[k,1]} \t  {vote[k,2]} \t  {tot[k]}");
            }
            Array.Sort(tot, name);
            Console.WriteLine();
            Console.WriteLine($" === {name[name.Length - 1]} 最高票當選, 共計: {tot[tot.Length - 1]} 票");
            Console.WriteLine($" === {name[0]} 最低票落選, 共計: {tot[0]} 票");
            Console.Read();
        }
        static int add(int a,int b)
        {
            return a + b;
        }
    }
}
