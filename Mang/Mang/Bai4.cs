using System;
using System.Collections.Generic;
using System.Text;

namespace Mang
{
    class Bbai4
    {
        static void Main()
        {
            int[] a = new int[] { 2, 100, 11, 7, 50, 6, 100, 2, 22, 100 };
            int max = a[0];
            int min = a[0];
            int demmax = 0;
            int demmin = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (max == a[i])
                {
                    demmax++;
                }else if (max < a[i])
                {
                    max = a[i];
                }
                if (min == a[i])
                {
                    demmin++;
                }
                else if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("mang goc:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("\n=====================");
            Console.WriteLine("max = " + max);
            Console.WriteLine("so lan xuat hien:" + demmax);
            Console.WriteLine("min = " + min);
            Console.WriteLine("so lan xuat hien:" + demmin);
        }
    }
}
