using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RndObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndObj = new Random();
            Console.Write("== Pass1：");
            for (int k = 1; k <= 5; k++)
            {
                Console.Write($" {rndObj.Next(1, 11)}" );
            }
            Console.WriteLine();
            Console.Write("== Pass2：");
            for (int k = 1; k <= 5; k++)
            {
                Console.Write($" {rndObj.Next(1, 11)}" );
            }
            Console.Read();
        }
    }
}
