using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k, p;
            i = 5;
            k = 0;
            try
            {
                p = i / k;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"例外訊息ex.Message：{ex.Message}");
                Console.WriteLine($"發生例外的函式ex.StackTrace：{ex.StackTrace}");
                Console.WriteLine($"發生例外的物件ex.Source：{ex.Source}");
                Console.WriteLine($"發生例外的物件型別ex.GetType()：{ex.GetType()}");
                Console.WriteLine($"發生例外的文字說明ex.ToString()：{ex.ToString()}");
            }
            finally
            {
                Console.WriteLine(".... 結束程式執行!! ....");
            }
            Console.Read();
        }
    }
}
