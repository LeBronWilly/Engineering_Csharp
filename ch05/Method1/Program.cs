using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method1
{
    class Program
    {
        private static double PI = 3.1416;   　　　　//PI為圓周率
        static double Compute(double r)
        {
            return (4.0 / 3.0 * PI * r * r * r);
        }
        static void Main(string[] args)
        {
            double volume, radius;
            Console.Write(" 請輸入球半徑(公分) : ");
            radius = double.Parse(Console.ReadLine());
            volume = Compute(radius);
            Console.WriteLine();
            Console.WriteLine($" 球半徑 = {radius}公分  球體積 = {volume} 立方公分");
            Console.Read();
        }
    }
}
