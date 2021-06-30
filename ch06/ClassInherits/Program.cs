using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInherits
{
    class Program
    {
        static void Main(string[] args)
        {
            //建立矩形物件r
            Rectangle r = new Rectangle { Width = 10, Height = 5 };
            Console.WriteLine($"　矩形 寬={r.Width},長={r.Height},面積={r.GetArea()}");
            Console.WriteLine();
            Triangle t = new Triangle { Width = 10, Height = 5 };   // 建立三角形物件t
            t.ShowData();
            Console.WriteLine("=================================");
            Rectangle.ShowNum();  // 顯示產生多少個圖形也可用Triangle.ShowNum();
            Triangle.ShowNum();  // 和Rectangle.ShowNum()一樣
            Console.Read();
        }
    }
}
