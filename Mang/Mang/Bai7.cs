using System;
using System.Collections.Generic;
using System.Text;

namespace Mang
{
    class Bai7
    {
        static void Main()
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                
                while (checknt(arr[i]) == false)
                {
                    Console.WriteLine("nhap phan tu thu " + i+" : ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());                  
                }
            }
            Console.WriteLine("mang arr thoa man la 5 so nguyen to :");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        static bool checknt(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }

}


