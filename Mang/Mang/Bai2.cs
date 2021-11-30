using System;
using System.Collections.Generic;
using System.Text;

namespace Mang
{
    class Bai2
    {
        static void Main()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] b = new double[] { 1.2, 2.3, 3.4, 4.5, 5.6 };
            
            for (int i = 0; i < a.Length; i+=2)
            {
                a[i] = 0;
            }           
            for (int i = 0; i < b.Length; i++)
            {
                 a[2 * i + 1]=(int)b[i];
            }
            Console.WriteLine("mang sau khi chen :");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}
