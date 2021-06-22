using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInherits
{
    //Triangle類別繼承Rectangle類別, 
    //Traiangle類別會擁有Rectanglel類別的public 和 protected的成員
    class Triangle : Rectangle
    {
        //由於三角形的面積的計算方式和矩形不一樣
        //所以必須重新定義GetArea方法
        public override int GetArea()        //取得三角形的面積
        {
           return (Width* Height) / 2;  	//寬(底)*高/2=三角形的面積
        }
        //新增ShowData方法，用來顯示三角形的寬, 高, 面積
        public void ShowData()
        {
            Console.WriteLine($"三角形 寬={Width},高={Height},面積={GetArea()}");
        }
    }
}
