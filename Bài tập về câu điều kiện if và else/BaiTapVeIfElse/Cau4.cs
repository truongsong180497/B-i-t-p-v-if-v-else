using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapVeIfElse
{
    class Cau4
    {
        static void Main()
        {
            Console.WriteLine(" nhap a = ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" nhap b = ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" nhap c = ");
            float c = Convert.ToSingle(Console.ReadLine());
            Console.OutputEncoding = Encoding.Unicode;//  xuất hiện được tiếng việt
            if(a<b+c && b<a+c && c < a + b)
            {
                Console.WriteLine("  Ba số a,b,c là 3 cạnh của 1 tam giác");  
            }
            else
            {
                Console.WriteLine(" Ba số a,b,c không phải là 3 cạnh của 1 tam giác ");
            }

        }

    }
}
