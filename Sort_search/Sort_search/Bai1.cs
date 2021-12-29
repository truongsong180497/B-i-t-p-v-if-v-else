using System;
using System.Collections.Generic;
using System.Text;

namespace Sort_search
{
    class Bai1
    {
        public static void Main()
        {
            Console.WriteLine("Nhap so phan tu cua mang:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            if (n > 0)
            {
                Nhapmang(arr, n);
                Console.WriteLine("Cac phan tu trong mang truoc khi sap xep la:");
                hienthi(arr, n);
                sapxepmangtang(arr, n);
                Console.WriteLine("\nCac phan tu trong mang sau khi sap xep tang la:");
                hienthi(arr, n);
            }
            else
            {
                arr = null;
            }
        }

        private static void hienthi(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }

        private static void sapxepmangtang(int[] arr, int n)
        {
            Array.Sort(arr);
        }

        private static void Nhapmang(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu "+i+" : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
