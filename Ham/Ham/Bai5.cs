using System;
using System.Collections.Generic;
using System.Text;

namespace Ham
{
    class Bai5
    {
        static void Main()
        {
            int[] arr = new int[10];          
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("nhap phan tu thu "+i+" : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());                
            }
            Console.WriteLine("mang arr la:");
            for (int i = 0; i < 10; i++)
            {                
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\ncac so nguyen to trong mang arr la:");
            for (int i = 0; i < 10; i++)
            {
                if (checknumber(arr[i]) == true)
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
        public static bool checknumber(int n)
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
