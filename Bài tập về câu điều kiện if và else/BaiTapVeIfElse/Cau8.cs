using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapVeIfElse
{
    class Cau8
    {
        static void Main()
        {
            Console.WriteLine("        MENU        ");
            Console.WriteLine("====================");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("x");
            Console.WriteLine(":");
            Console.WriteLine("====================");
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("nhập a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhập b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" vui lòng nhập sự lựa chọn ");
            char Menu = Convert.ToChar(Console.ReadLine());
            switch (Menu)
            {
                case '+':
                    Console.WriteLine("tổng a+b = " + (a + b));
                    break;
                case '-':
                    Console.WriteLine("tổng a-b = " + (a - b));
                    break;
                case 'x':
                    Console.WriteLine("tổng a*b = " + (a * b));
                    break;
                case ':':
                    double x = (double)a / b;
                    Console.WriteLine("tổng a/b = " + x);
                    break;
               


                default:
                    break;
            }
            
        }

    }
}
