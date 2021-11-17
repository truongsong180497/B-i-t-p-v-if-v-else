using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapVeIfElse
{
    class Cau2
    {
        static void Main()
        {
            // pt bac 2 ax^2+bx+c=0!
            float a, b, c;
            Console.WriteLine(" nhap a = ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" nhap b = ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" nhap c = ");
            c = Convert.ToSingle(Console.ReadLine());
            if (a == 0)// giai pt bac nhat bx+c
            {
                if (b == 0 && c == 0)
                {
                    Console.WriteLine(" pt co vo so nghiem ");
                }
                else if (b == 0 && c != 0)
                {
                    Console.WriteLine(" pt vo ngiem ");
                }
                else
                {
                    float x = -b * 1.0f / a;
                    Console.WriteLine(" pt co 1 nghiem la : x = " + x);
                }
            }
            else // giai pt bac 2 ax^2+bX+c=0
            {
                float Delta = b * b - 4 * a * c;
                if (Delta < 0)
                {
                    Console.WriteLine(" pt vo nghiem ");
                }
                else if (Delta == 0)
                {
                    float x = -b * 1.0f / (2 * a);
                    Console.WriteLine(" pt co nghiem kep la : x = " + x);
                }
                else
                {
                    float x1 = (float)(-b + Math.Sqrt(Delta)) / (2 * a);
                    float x2 = (float)(-b - Math.Sqrt(Delta)) / (2 * a);
                    Console.WriteLine(" pt co nghiem phan biet la : x1 =  " + x1);
                    Console.WriteLine(" pt co nghiem phan biet la : x2 =  " + x2);
                }
            }
        }

    }
}
