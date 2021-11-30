using System;
using System.Collections.Generic;
using System.Text;

namespace Mang
{
    class Bai6
    {
        static void Main()
        {
            Console.WriteLine("nhap so luong phan tu n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("cac phan tu cua mang a khi random:");
            if (n > 0)
            {
               
                for (int i = 0; i < n; i++)
                {
                    Random rd = new Random();
                    int numbers = rd.Next(100);//random so ngau nhien tu 0->100,co the thay doi dc
                    a[i] = numbers;
                    Console.Write(a[i]+" ");
                }
                Console.WriteLine("\nnhap x = ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("cac phan tu trong mang sau khi random ma chia het cho x la:");
                for (int i = 0; i < n; i++)
                {
                    if (a[i] % x == 0)
                    {
                        Console.Write(a[i]+" ");
                    }                                                         
                }
                
            }   
            else
            {
                a = null;
            }
                                                                         
        }
    }
}
