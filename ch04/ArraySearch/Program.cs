using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            string myobject;
            string[] word = new string[6] { "mango", "papaya", "apple", "coconut", "orange", "tomato" };
            Array.Sort(word);
            Console.WriteLine(" === 排序後 === ");
            for (int k = 0; k < word.Length; k++)
            {
                Console.WriteLine($" {k + 1}.word[{k}] = {word[k]} ");
            }
            Console.WriteLine("----------------------------");
            Console.Write("請輸入欲查詢的單字 : ");
            myobject = Console.ReadLine();
            index = Array.BinarySearch(word, myobject);
            Console.WriteLine("----------------------------");
            Console.WriteLine("*** 查詢結果 : ");
            if (index < 0)
            {
                Console.WriteLine("== 該資料不存在 !");
            }
            else
            {
                Console.WriteLine($"== 該資料位於陣列中 word[{index}] = {word[index]}");
            }
            Console.Read();
        }
    }
}
