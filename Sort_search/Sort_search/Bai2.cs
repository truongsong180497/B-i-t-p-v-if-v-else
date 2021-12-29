using System;
using System.Collections.Generic;
using System.Text;

namespace Sort_search
{
    class Bai2
    {
        public static void Main()
        {
            int[] arr = new int[100];           
            Nhapmang(arr);
            sapxepmangtang(arr);
            hienthi(arr);
            timxtrongmang(arr);
        }

        private static void timxtrongmang(int[] arr)
        {
            int n = arr.Length;            
            int count = 0;
            Console.WriteLine("Nhap 1 so nguyen x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vi tri dau tien cua x trong mang la:");
            for (int i = 0; i < n; i++)
            {               
                if (arr[i] == x)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("khong tim thay x trong mang");
            }
        }

        private static void sapxepmangtang(int[] arr)
        {
            Array.Sort(arr);
        }

        private static void hienthi(int[] arr)
        {
            int n = arr.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {                
                Console.Write(arr[i]+"  ");
                count++;
                if (count == 10 || count==20||count==30 ||count==40||count==50||count==60
                    ||count==70||count==80||count==90||count==100)
                {
                    Console.WriteLine();
                }
            }
        }

        private static void Nhapmang(int[] arr)
        {
            int n = arr.Length;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(1, 1000);
            }
        }
    }
}
