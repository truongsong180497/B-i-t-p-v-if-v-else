using System;
using System.Collections.Generic;
using System.Text;

namespace Ham
{
    class Bai3
    {
        static void Main()
        {
            Console.WriteLine("nhap n = ");
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"so fibonacy thu {n} la :"+fibo(n));
        }
        public static long fibo(long n)
        {
            if (n == 0)
            {
                return 0;
            }else if (n == 1)
            {
                return 1;
            }
            return fibo(n - 2) + fibo(n - 1);
        }

    }
}
