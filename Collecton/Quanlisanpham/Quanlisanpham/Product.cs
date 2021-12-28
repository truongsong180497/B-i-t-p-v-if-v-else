using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlisanpham
{
    class Product
    {
        private string name_product;
        private string descreption_product;
        private double price_product;
        public void input_product()
        {
            Console.WriteLine("Nhap ten san pham:");
            name_product = Console.ReadLine();
            Console.WriteLine("Mo ta san pham:");
            descreption_product = Console.ReadLine();
            Console.WriteLine("Nhap gia san pham:");
            price_product = Convert.ToDouble(Console.ReadLine());
        }
        public void output_product()
        {
            Console.WriteLine("DANH SACH SAN PHAM SHOP ABC");
            Console.WriteLine("Ten san pham:");
            Console.WriteLine(name_product);
            Console.WriteLine("Mo ta san pham:");
            Console.WriteLine(descreption_product);
            Console.WriteLine("Gia san pham:");
            Console.WriteLine(price_product);
        }
        public string get_name_product()
        {
            return name_product;
        }
        public double get_price_product()
        {
            return price_product;
        }
    }
}
