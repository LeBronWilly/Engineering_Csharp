﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, k, p;
            i = 5;
            k = 2;
            try
            {
                p = i / k;
            }
            catch
            {
                Console.WriteLine("發生例外");
            }
            finally
            {
                Console.WriteLine(".... 結束程式執行!! ....");
            }
            Console.Read();
        }
    }
}
