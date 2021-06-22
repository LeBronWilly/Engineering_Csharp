using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breakcontinue
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, keyin = 0, sum = 0;
            string str1;
            do
            {
                Console.Write("  == 請輸入一個數值: ");
                keyin = Convert.ToInt32(Console.ReadLine());  //將輸入的資料轉成整數
                sum += keyin;    // 累加輸入值
                count++;
                Console.Write("  == 是否繼續(Y/N) ? ");
                str1 = Console.ReadLine();
                if ((str1 == "y") || (str1 == "Y"))  //如果輸入"Y" 或 "y"則返回迴圈開始處
                {
                    continue; 	//返回迴圈開始處
                }
                else
                {
                    break;      	//離開迴圈
                }
            } while (true);    	//無窮迴圈
            Console.WriteLine($"\n  == {count}個數的總和: {sum} "); //顯示累加結果
            Console.Read();
        }
    }
}
