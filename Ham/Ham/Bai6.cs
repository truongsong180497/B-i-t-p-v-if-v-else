using System;
using System.Collections.Generic;
using System.Text;

namespace Ham
{
    class Bai6
    {
        static void Main()
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("nhap phan tu thu "+i+" : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("mang arr la :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\ncac so hoan thien trong mang la :");
            for (int i = 0; i < 10; i++)
            {
                if (checkperfect(arr[i]) == true)
                {
                    Console.Write(arr[i]+" ");
                }
            }
        }
        public static bool checkperfect(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (n == sum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
