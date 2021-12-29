using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
    class Program
    {
        public static void Main()
        {
            List<Product> list = new List<Product>();
            khoitao(list);
            sapxepgiam(list);
            Console.WriteLine("DANH SACH SAN PHAM SAU KHI SAP XEP GIAM:");
            Console.WriteLine("DANH MUC SAN PHAM");
            Console.WriteLine("-----------------------------------------------" +
                "------------------------------------------");
            Console.WriteLine(string.Format("|{0,3}|{1,20}|{2,20}|{3,20}|{4,20}|","STT",
                "Ten san pham","So luong","Don gia($)","Tong tien($)"));
            Console.WriteLine("-----------------------------------------------" +
                "------------------------------------------");
            hienthi(list);
            Console.WriteLine("-----------------------------------------------" +
                "------------------------------------------");
        }

        private static void sapxepgiam(List<Product> list)
        {
            list.Sort(new Sortbysum_name());
        }

        private static void hienthi(List<Product> list)
        {
            foreach (Product item in list)
            {
                item.output_product();
            }
        }

        private static void khoitao(List<Product> list)
        {
            int n = 5;
            for (int i = 0; i < 5; i++)
            {
                Product product = new Product();
                product.input_product();
                list.Add(product);
            }
        }
    }
}
