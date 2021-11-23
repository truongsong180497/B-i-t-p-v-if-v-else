using System;
using System.Collections.Generic;
using System.Text;

namespace Baitaplenhlap
{
    class Bai7
    {
        static void Main()
        {
            Console.WriteLine("nhap n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            kiemtranguyento(n);
            hienthiketqua(n);            
        }

        static void hienthiketqua(int n)
        {
            Console.WriteLine("cac so nguyen to la :");
            int count = 0;
            int i = 2;
            while (count < n)
            {
                if (kiemtranguyento(i))
                {
                    count++;
                    Console.Write(i+" ");
                }
                i++;
            }
        }

        static bool kiemtranguyento(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
