using System;
using System.Collections.Generic;
using System.Text;

namespace Mang
{
    class Bai9
    {
        static void Main()
        {
            

            double[,] arr = new double [5, 6];
            for (int i = 0; i < 5; i++)
            {
                for (int j  = 0; j  <6; j ++)
                {
                    Console.WriteLine($"nhap gia tri cac phan tu [{i},{j}] = ");
                    arr[i, j] = Convert.ToDouble(Console.ReadLine());                                      
                }                               
            }
            Console.WriteLine("mang arr:");
            for (int i = 0; i < 5; i++)
            {
                for (int j  = 0; j < 6; j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("diem trung binh cong cua cac Hv theo hang la :");
            double tong = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tong = tong + arr[i, j];
                }
                Console.WriteLine(tong / 6);
            }
           
            
            
        }
    }
}
