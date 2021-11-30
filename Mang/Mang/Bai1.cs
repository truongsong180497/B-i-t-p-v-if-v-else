using System;
using System.Collections.Generic;
using System.Text;

namespace Mang
{
    class Bai1
    {
        static void Main()
        {
            Console.WriteLine("nhap so luong phan tu mang n= ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("phan tu thu " + i + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("cac phan tu o vi tri chan la :");
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
