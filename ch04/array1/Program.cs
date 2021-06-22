using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k;
            int[] myAry = new int[5];
            Console.WriteLine("=== 由鍵盤連續輸入五個整數值到 myAry 陣列 : \n ");
            //連續輸入5個整數並指定給myAry[0]~myAry[4]
            for (k = 0; k < 5; k++)
            {
                Console.Write($" {k+1}. 第 {k+1} 個陣列元素 : myAry[{k}] = ");
                myAry[k] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(" == myAry 陣列的元素內容 == ");
            //印出陣列元素的內容, 並累計總和
            int sum = 0;
            foreach (int item in myAry)
            {
                Console.Write($"  {item}");
                sum += item;
            }
            Console.WriteLine();
            Console.WriteLine($" myAry 陣列的元素總和為 {sum} ");
            Console.Read();
        }
    }
}
