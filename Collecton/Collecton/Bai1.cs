using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collecton
{
    class Bai1
    {
        static void Main()
        {
            var list = new List<int>();
            Console.WriteLine("Demo cac thao tac tren ArrayList so nguyen Java");
            Console.WriteLine("===============================================");
            Console.WriteLine("1- khoi tao danh sach.");
            Console.WriteLine("2- them 1 phan tu vao danh sach.");
            Console.WriteLine("3- xoa 1 phan tu ra khoi danh sach.");
            Console.WriteLine("4- chen 1 phan tu vao danh sach.");
            Console.WriteLine("5- tim 1 phan tu.");
            Console.WriteLine("6- sap xep danh sach tang dan");
            Console.WriteLine("7- sap xep danh sach giam dan");
            Console.WriteLine("8- duyet danh sach.");
            Console.WriteLine("9- thoat chuong trinh");
            Console.WriteLine("Xin moi ban chon :");
            int n;
            do
            {
                Console.WriteLine("\nnhap so ban chon: ");
                 n= Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        khoitao(list);
                        Console.WriteLine("danh sach trong list ban dau:");
                        hienthi(list);
                        break;
                    case 2:
                        themphantu(list);
                        Console.WriteLine("danh sach sau khi them phan tu:");
                        hienthi(list);
                        break;
                    case 3:
                        xoaphantu(list);
                        Console.WriteLine("danh sach sau khi xoa pha tu:");
                        hienthi(list);
                        break;
                    case 4:
                        chenphantu(list);
                        Console.WriteLine("danh sach sau khi chen phan tu ");
                        hienthi(list);
                        break;
                    case 5:
                        timphantu(list);
                        hienthi(list);
                        break;
                    case 6:
                        sapxeptang(list);
                        Console.WriteLine("danh sach sau khi sap xep tang");
                        hienthi(list);
                        break;
                    case 7:
                        sapxepgiam(list);
                        Console.WriteLine("danh sach sau khi sap xep giam");
                        hienthi(list);
                        break;
                    case 8:                        
                        duyetdanhsach(list);
                        hienthi(list);
                        break;
                    case 9:
                        Console.WriteLine("thoat chuong trinh");
                        break;
                    default:
                        break;
                }

            } while (n!=9);
        }

        private static void duyetdanhsach(List<int> list)
        {
            list.AsReadOnly();           
        }

        private static void sapxepgiam(List<int> list)
        {
            list.Reverse();
        }

        private static void sapxeptang(List<int> list)
        {
            list.Sort();
        }

        private static void timphantu(List<int> list)
        {
            Console.WriteLine("nhap phan tu can tim:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (list.Contains(n) == true)
            {
                Console.WriteLine("phan tu co trong danh sach list:"+n);
            }
            else
            {
                Console.WriteLine("phan tu khong co trong list");
            }
        }

        private static void chenphantu(List<int> list)
        {
            Console.WriteLine("nhap vi tri can chen trong list:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so can chen vao list:");
            int n = Convert.ToInt32(Console.ReadLine());
            list.Insert(m, n);
        }

        private static void xoaphantu(List<int> list)
        {
            Console.WriteLine("nhap phan tu can xoa:");
            int n = Convert.ToInt32(Console.ReadLine());
            list.Remove(n);
        }

        private static void themphantu(List<int> list)
        {
            Console.WriteLine("\nnhap phan tu can them:");
            int n= Convert.ToInt32(Console.ReadLine());
            list.Add(n);
        }

        private static void hienthi(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
        }

        private static void khoitao(List<int> list)
        {
            Console.WriteLine("nhap so phan tu trong list:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap phan tu thu "+i+" : ");
                int m = Convert.ToInt32(Console.ReadLine());
                list.Add(m);
            }
        }
    }
}
