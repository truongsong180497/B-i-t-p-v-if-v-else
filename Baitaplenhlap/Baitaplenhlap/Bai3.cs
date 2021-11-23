using System;
using System.Collections.Generic;
using System.Text;

namespace Baitaplenhlap
{
    class Bai3
    {
        static void Main()
        {
            Console.WriteLine(" nhap m= ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" nhap n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            if(m>0 && n > 0)// gia su m<n
            {
                Console.Write("cac so chia het cho 7 trong khoang m va n la :" );
                for (int i = m; i < n; i++)
                {
                    if (i % 7 == 0)
                    {
                        Console.Write(i+" ");
                    }
                }
            }
            else
            {
                Console.WriteLine("vui long nhap lai m>0 va n>0");
            }
        }
    }
}
