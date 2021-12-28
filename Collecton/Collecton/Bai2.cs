using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collecton
{
    class Bai2
    {
        public static void Main()
        {
            Stack<int> list = new Stack<int>();
            Console.WriteLine("Demo cac thao tac tren Stack so nguyen Java");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1- khoi tao stack.");
            Console.WriteLine("2- them 1 phan tu vao stack.");
            Console.WriteLine("3- lay phan tu dau ra khoi stack.");
            Console.WriteLine("4- xem phan tu dau stack.");
            Console.WriteLine("5- duyet stack.");
            Console.WriteLine("6- thoat chuong trinh.");
            int n = 0;
            do
            {
                Console.WriteLine("\nMoi ban chon:");
                n = Convert.ToInt32(Console.ReadLine());
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
                        Console.WriteLine("cac phan tu trong stack la:");
                        hienthi(list);
                        break;
                    case 6:
                        Console.WriteLine("Tam biet ban ! hen gap lai");
                        break;
                    default:
                        break;
                }
            } while (n!=6);
        }

        private static void xemphantudau(Stack<int> list)
        {
            Console.WriteLine("phan tu dau trong stack la:");
            Console.WriteLine(list.Peek());
        }

        private static void layphantudau(Stack<int> list)
        {
            list.Pop();
        }

        private static void them1phantu(Stack<int> list)
        {
            Console.WriteLine("\nNhap phan tu can them:");
            int n = Convert.ToInt32(Console.ReadLine());
            list.Push(n);
        }

        private static void hienthi(Stack<int> list)
        {          
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
        }

        private static void khoitao(Stack<int> list)
        {
            Console.WriteLine("nhap so luong phan tu trong stack");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                Console.WriteLine("nhap phan tu thu "+i+" : ");
                int m = Convert.ToInt32(Console.ReadLine());
                list.Push(m);
            }
        }
    }
}
