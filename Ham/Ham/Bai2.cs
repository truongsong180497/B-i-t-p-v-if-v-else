using System;
using System.Collections.Generic;
using System.Text;

namespace Ham
{
    class Bai2
    {
        static void Main()
        {
            Console.WriteLine("nhap x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x^n = "+power(x,n));
        }
        public static int power(int a,int n)
        {
            int a_mu_n = (int)Math.Pow(a, n);
            return a_mu_n;
        }
    }
}
