using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapVeIfElse
{
    class Cau1b
    {
       static void Main()
        {
            Console.WriteLine(" nhap n>2 = ");
            float n = Convert.ToSingle(Console.ReadLine());
            int m = 2;
            float r = n % m;
            if (r!=0)
            {
                if (n < m - 1)
                {
                    m++;
                }
                else
                {
                    Console.WriteLine(" n is  a prime number ");
                }
            }
            else
            {
                Console.WriteLine(" n is not a prime number");
            }
        }

    }
}
