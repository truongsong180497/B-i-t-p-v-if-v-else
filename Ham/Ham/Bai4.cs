using System;
using System.Collections.Generic;
using System.Text;

namespace Ham
{
    class Bai4
    {
        static void Main()
        {
            Console.WriteLine("nhap diem so n =");
            int n = Convert.ToInt32(Console.ReadLine());
            kytudiemchu(n);
        }
        public static void kytudiemchu(int n)
        {
            if(n>=8.5 && n <= 10)
            {
                Console.WriteLine($"diem so cua {n} la: diem A");
            }else if(n>=7 && n <= 8.4)
            {
                Console.WriteLine($"diem so cua {n} la: diem B");
            }else if(n>=5.5 && n <= 6.9)
            {
                Console.WriteLine($"diem so cua {n} la: diem C");
            }else if(n>=4 && n < 5.4)
            {
                Console.WriteLine($"diem so cua {n} la: diem D");
            }else if(n>=0 && n <= 3.9)
            {
                Console.WriteLine($"diem so cua {n} la: diem F");
            }
            else
            {
                Console.WriteLine(" nhap diem khong hop le tra ve ky tu :'E'");
            }
        }
    }
}
