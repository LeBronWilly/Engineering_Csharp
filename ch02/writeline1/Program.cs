using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace writeline1
{
    class Program
    {
        static void Main(string[] args)
        {
            //宣告整數變數price為100，整數變數qty為30
            int price = 100, qty = 30;
            //印出資料後游標往下移一行
            Console.WriteLine("單價：{0}     數量：{1}", price, qty);
            Console.WriteLine();     //游標往下移一行
            Console.WriteLine($"打八折後,總金額：{price * qty * 0.8}");
            Console.Read();    
        }
    }
}
