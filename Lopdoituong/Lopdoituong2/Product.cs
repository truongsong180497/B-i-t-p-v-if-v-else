using System;
using System.Collections.Generic;
using System.Text;

namespace Lopdoituong2
{
    class Product
    {
        private string tensanpham;
        private int soluong;
        private double dongia;
        public Product(string tensanpham,int soluong,double dongia)
        {
            this.tensanpham = tensanpham;
            this.soluong = soluong;
            this.dongia = dongia;
        }
        
        public double tongtien()
        {
            return soluong * dongia;
        }
        public  void Print()
        {           
            Console.WriteLine(string.Format("{0}{1,-16}|{2,11}|{3,12}|{4,14}|","   ",
                tensanpham,soluong,dongia,tongtien()));
        }
    }
}
