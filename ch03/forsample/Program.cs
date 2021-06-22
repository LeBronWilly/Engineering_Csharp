using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forsample
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 6; i++)
            {
                for (int k = 1; k <= i; k++)
                    Console.Write($"{k}");
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
