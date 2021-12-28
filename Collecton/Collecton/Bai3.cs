using System;
using System.Collections.Generic;
using System.Text;

namespace Collecton
{
    class Bai3
    {
        public static void Main()
        {
            Queue<int> list = new Queue<int>();
            Console.WriteLine("Demo cac thao tac tren Queue so nguyen Java");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1- khoi tao Queue.");
            Console.WriteLine("2- them 1 phan tu vao Queue.");
            Console.WriteLine("3- lay phan tu dau ra khoi Queue.");
            Console.WriteLine("4- xem phan tu dau Queue.");
            Console.WriteLine("5- duyet Queue.");
            Console.WriteLine("6- thoat chuong trinh.");
            int n = 0;
            do
            {
                Console.WriteLine("\nMoi ban chon :");
                n= Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        khoitao(list);
                        break;
                    case 2:
                        them1phantu(list);
                        break;
                    case 3:
                        layphantudau(list);
                        break;
                    case 4:
                        xemphantudau(list);
                        break;
                    case 5:
                        hienthi(list);
                        break;
                    case 6:
                        Console.WriteLine("Tam biet ban!Hen gap lai");
                        break;
                    default:
                        break;
                }
            } while (n!=6);
        }

        private static void xemphantudau(Queue<int> list)
        {
            Console.WriteLine("Phan tu dau trong queue la:");
            Console.WriteLine(list.Peek());
        }

        private static void layphantudau(Queue<int> list)
        {
            list.Dequeue();
        }

        private static void them1phantu(Queue<int> list)
        {
            Console.WriteLine("Nhap phan tu can them:");
            int n = Convert.ToInt32(Console.ReadLine());
            list.Enqueue(n);
        }

        private static void hienthi(Queue<int> list)
        {
            Console.WriteLine("Cac phan tu trong queue la:");
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
        }

        private static void khoitao(Queue<int> list)
        {
            Console.WriteLine("Nhap so luong phan tu trong queue:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap phan tu thu "+i+" : ");
                int m = Convert.ToInt32(Console.ReadLine());
                list.Enqueue(m);
            }
        }
    }
}
