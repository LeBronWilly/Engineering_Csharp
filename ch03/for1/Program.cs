using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, count = 0;  	//宣告k為for迴圈的控制變數
            for (k = 1; k <= 100; k++)
            {
                if ((k % 4) == 0)
                {
                    Console.Write($"{k} ");	  //若k為4的倍數則執行此行
                    Console.Write(k + " ");	  //若k為4的倍數則執行此行
                    count++;               	        //count變數為5時將游標移下一行
                    if (count == 5)               //若印5個數後即將游標移下一行
                    {
                        Console.WriteLine();
                        count = 0;                  //count變數為0
                    }
                }
            }
            Console.Read();
        }
    }
}
