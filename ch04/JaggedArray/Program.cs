using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] stuary = new string[3][];   //先建立3列
            stuary[0] = new string[] { "林子厚", "反應敏捷", "熱心公務", "表現大方" };
            stuary[1] = new string[] { "趙玲玲", "溫和良善", "主動求知", "做事負責", "待人親切" };
            stuary[2] = new string[] { "吳學剛", "性情率真", "尚知勤學" };
            for (int i = 0; i <= stuary.Length - 1; i++)
            {
                Console.Write($"第{i}列: " );
                for (int k = 0; k <= stuary[i].Length - 1; k++)
                {
                    Console.Write($"{stuary[i][k]} " );
                }
                Console.WriteLine("\n");
            }
            Console.Read();
        }
    }
}
