using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexof
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[6] { "Jack", "Tom", "Fred", "Mary", "Lucy", "Jane" };
            Console.WriteLine($"{Array.IndexOf(name, "Tom")}");
            Console.WriteLine($"{Array.IndexOf(name, "Tom", 3)}");
            Console.WriteLine($"{Array.IndexOf(name, "Mary", 1, 4)}");
            Console.Read();
        }
    }
}
