using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            float fnum;
            bool bfg;
            do
            {
                Console.Write("請輸入一個整數：");
                bfg = int.TryParse(Console.ReadLine(), out num);
                Console.WriteLine($"bfg：{bfg}");
            } while (bfg == false);
            Console.WriteLine($"您輸入的整數是：{num}");
            //Console.WriteLine($"bfg：{bfg}");
            //Console.Read();

            do // 不太正確
            {
                Console.Write("請輸入一個小數：");
                bfg = float.TryParse(Console.ReadLine(), out fnum);
                Console.WriteLine($"bfg：{bfg}");
            } while (bfg == false);
            Console.WriteLine($"您輸入的小數是：{fnum}");
            //Console.WriteLine($"bfg：{bfg}");
            Console.Read();

        }
    }
}
