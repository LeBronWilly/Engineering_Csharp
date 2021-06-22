using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomArray
{
    class Program
    {
        static void GetRnd(int[] ranAry, int min, int max, int num)
        {
            int temp;
            int n = 0;
            bool more;
            Random ranObj = new Random();
            do
            {
                more = false;
                temp = ranObj.Next(min, max + 1);
                for (int k = 0; k <= n; k++)
                {
                    if (ranAry[k] == temp)
                    {
                        more = true;
                        break;
                    }
                }
                if(more == false)
                {
                    ranAry[n] = temp;
                    n++;
                }
            } while (n < num);
        }
        static void Main(string[] args)
        {
            int min = 10, max = 20, num = 8;
            int[] ran = new int[num];
            GetRnd(ran, min, max, num);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"第{i+1}個亂數: {ran[i]}" );
            }
            Console.Read();
        }
    }
}
