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
            int i, k;
            string[] name = new string[] { "陳一", "張三", "王五" };
            int[] tot = new int[name.Length];
            int[,] vote = new int[3, 3];
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine($" 第 {i+1} 鄰各候選人得票數:" );
                for (k = 0; k <= 2; k++)
                {
                    Console.Write($" {k+1}. {name[k]} :" );
                    vote[i, k] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(" ----------------------------------");
            }
            for (i = 0; i <= 2; i++)
            {
                for (k = 0; k <= 2; k++)
                {
                    tot[i] += vote[k, i];
                }
            }
            Console.WriteLine(" ==================================");
            Console.WriteLine(" 候選人   第一鄰  第二鄰  第三鄰  總得票數");
            Console.WriteLine(" ==================================");
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine
                    ($" {name[i]} \t {vote[0, i]} \t  {vote[1, i]} \t  {vote[2, i]} \t  {tot[i]}" );
            }
            Array.Sort(tot, name);
            Console.WriteLine();
            Console.WriteLine($" === {name[2]} 最高票當選, 共計: {tot[2]} 票" );
            Console.Read();
        }
    }
}
