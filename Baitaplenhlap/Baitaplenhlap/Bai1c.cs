using System;
using System.Collections.Generic;
using System.Text;

namespace Baitaplenhlap
{
    class Bai1c
    {
        static void Main()
        {
            Console.WriteLine("nhap N>2 = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int M = 2;
            double R = N % M;
            if (R == 0)
            {
                Console.WriteLine("N is not a prime number");
            }
            else
            {
                for (M=2;  M< N-1; M ++)
                {
                    Console.WriteLine("N is a prime number");
                }
            }
                
            

        }
    }
}

