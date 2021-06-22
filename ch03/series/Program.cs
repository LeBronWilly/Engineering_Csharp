using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace series
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("\n === 求級數的總和 ==== \n");
            Console.WriteLine("    x          3x+2 ");
            Console.WriteLine(" =======     ======= ");
            for (int x = 1; x <= 5; x++)
            {
                Console.WriteLine($"    {x}           {3 * x + 2}" );
                sum += 3 * x + 2;
            }
            Console.WriteLine(" ---------------------------- ");
            Console.WriteLine($" 此級數總和為 : {sum}\n"); 
            Console.Read();
        }
    }
}
