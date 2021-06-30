using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInherits
{
    class Rectangle
    {
        //用來記錄共產生多少個圖形，為保護層級，可讓衍生類別使用
        protected static int num;
        public int Width { get; set; } 	//Width寬屬性
        public int Height { get; set; } 	//Height高屬性
        //呼叫此建構式圖形數量+1
        public Rectangle()
        {
            num++;
        }
        // 定義方法為virtual，表示該方法可讓衍生類別重新定義父類別方法
        public virtual int GetArea()  		//取得矩形的面積
        {
            return Width * Height;             //寬*高=矩形的面積
        }
        //顯示共產生多少個圖形
        public static void ShowNum()
        {
            Console.WriteLine($"共產生 {num} 個圖形");
        }
    }
}
