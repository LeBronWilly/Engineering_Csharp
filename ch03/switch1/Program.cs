using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour;
            Console.Write("=== 請輸入現在時間(小時，廿四時制)：");
            hour = int.Parse(Console.ReadLine());
            if((hour >= 19) || (hour < 5)){
                switch (hour)
                {
                    case 19:
                    case 20:
                        Console.WriteLine("\n ... 一更 ...");
                        break;
                    case 21:
                    case 22:
                        Console.WriteLine("\n ... 二更 ...");
                        break;
                    case 23:
                    case 0:
                        Console.WriteLine("\n ... 三更 ...");
                        break;
                    case 1:
                    case 2:
                        Console.WriteLine("\n ... 四更 ...");
                        break;
                    case 3:
                    case 4:
                        Console.WriteLine("\n ... 五更 ...");
                        break;
                    default:
                        Console.WriteLine("\n ... 輸入值超出範圍 ...");
                        break;
                }
            }
            else
                Console.WriteLine("\n ... 白天 ...");
            Console.Read();
        }
    }
}
