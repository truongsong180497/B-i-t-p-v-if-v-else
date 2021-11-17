using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapVeIfElse
{
    class Cau3
    {
        static void Main()
        {
            Console.WriteLine(" nhap a = ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" nhap b = ");
            float b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" nhap c = ");
            float c = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" nhap d = ");
            float d = Convert.ToSingle(Console.ReadLine());
            float Max = a;
            float Min = a;
            //tim Max
            if(a==b && b==c && c == d)
            {
                Console.WriteLine(" k co gt tri lon nhat ");
            }
            else
            {
                if (b > Max)
                {
                    Max = b;
                }
                if (c > Max)
                {
                    Max = c;
                }
                if (d > Max)
                {
                    Max = d;
                }
                Console.WriteLine(" gia tri lon  nhat la Max = "+Max);
            }
            // TIM Min
            if (a == b && b == c && c == d)
            {
                Console.WriteLine(" k co gt tri nho nhat ");
            }
            else
            {
                if (b <Min)
                {
                    Min = b;
                }
                if (c <Min)
                {
                    Min = c;
                }
                if (d <Min)
                {
                    Min = d;
                }
                Console.WriteLine(" gia tri Nho  nhat la Min = " + Min);
            }



        }
    }
}
