using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
    class Product
    {
        private int Stt;
        private string Name_product;
        private int Quantity_product;
        private double price_product;
        public string get_name_product()
        {
            return Name_product;
        }
        public double sum_money()
        {
            return Quantity_product * price_product;
        }
        public void input_product()
        {
            Console.WriteLine("Nhap stt:");
            Stt= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten san pham:");
            Name_product = Console.ReadLine();
            Console.WriteLine("Nhap so luong san pham:");
            Quantity_product = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap don gia san pham:");
            price_product = Convert.ToDouble(Console.ReadLine());
        }
        public void output_product()
        {
            Console.WriteLine(string.Format("|{0,3}|{1,20}|{2,20}|{3,20}|{4,20}",Stt,Name_product,
                Quantity_product,price_product,sum_money()));
        }
    }
}
