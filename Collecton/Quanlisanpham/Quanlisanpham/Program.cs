using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Quanlisanpham
{
    class Program
    {
        public static void Main()
        {
            List<Product> list = new List<Product>();
            Console.WriteLine("Chuong trinh quan ly danh sách sản phẩm SHOP ABC");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1- khoi tao danh sach.");
            Console.WriteLine("2- them 1 san pham vao danh sach.");
            Console.WriteLine("3- xoa 1 san pham ra khoi danh sach.");
            Console.WriteLine("4- duyet danh sach.");
            Console.WriteLine("5- tim thong tin san pham theo ten.");
            Console.WriteLine("6- tim thong tin san pham theo gia.");
            Console.WriteLine("7- sap xep danh sach giam dan theo gia ban.");
            Console.WriteLine("8- thoat chuong trinh.");
            int n = 0;
            do
            {
                Console.WriteLine("Xin moi ban chon:");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        khoitao(list);
                        break;
                    case 2:
                        them1sp(list);
                        break;
                    case 3:
                        xoa1sp(list);
                        break;
                    case 4:
                        duyetdanhsach(list);
                        break;
                    case 5:
                        timsptheoten(list);
                        break;
                    case 6:
                        timsptheogia(list);
                        break;
                    case 7:
                        sapxepgiam(list);
                        duyetdanhsach(list);
                        break;
                    case 8:
                        Console.WriteLine("Chuc ban 1 ngay vui ve !Hen gap lai!");
                        break;
                    default:
                        break;
                }
            } while (n != 8);
        }

        private static void sapxepgiam(List<Product> list)
        {
            list.Sort(new Sortbyprice());
        }

        private static void timsptheogia(List<Product> list)
        {
            Console.WriteLine("Nhap gia san pham can tim trong list");
            double price_product = Convert.ToDouble(Console.ReadLine());
            Product product = null;
            foreach (Product item in list)
            {
                if (price_product == item.get_price_product())
                {
                    product = item;
                }
            }
            if (product != null)
            {
                product.output_product();
            }
            else
            {
                Console.WriteLine("not found name product in list follow price");
            }
        }

        private static void timsptheoten(List<Product> list)
        {
            Console.WriteLine("Nhap ten san pham trong list can tim:");
            string name_product = Console.ReadLine();
            Product product = null;
            foreach (Product item in list)
            {
                if (name_product == item.get_name_product())
                {
                    product = item;
                }
            }
            if (product != null)
            {
                product.output_product();
            }
            else
            {
                Console.WriteLine("not found name product in list");
            }
        }

        private static void duyetdanhsach(List<Product> list)
        {            
            for (int i = 0; i < list.Count; i++)
            {
                ((Product)list[i]).output_product();
            }
        }

        private static void xoa1sp(List<Product> list)
        {
            Console.WriteLine("Nhap ten san pham can xoa trong list:");
            string name_product = Console.ReadLine();
            Product product = null;
            foreach (Product item in list)
            {
                if (name_product == item.get_name_product())
                {
                    product = item;                    
                }
            }
            if (product != null)
            {
                list.Remove(product);
                Console.WriteLine("Ban da xoa san pham thanh cong ! vui " +
                    "long hien thi danh sach de xem ket qua");
            }
            else
            {
                Console.WriteLine("not found name product in list");
            }
        }

        private static void them1sp(List<Product> list)
        {
            Console.WriteLine("Nhap san pham can them vao list:");
            Product product = new Product();
            product.input_product();
            list.Add(product);
        }

        private static void khoitao(List<Product> list)
        {
            Console.WriteLine("Nhap so luong san pham trong list");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Product product = new Product();
                product.input_product();
                list.Add(product);
            }
        }
    }
}
