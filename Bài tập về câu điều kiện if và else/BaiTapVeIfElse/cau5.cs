using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapVeIfElse
{
    class cau5
    {
        static void Main()
        {
            // tinh tien taxi
            Console.WriteLine(" nhap km = ");
            double km = Convert.ToSingle(Console.ReadLine());            
            double tinhtientaxi = 0;
            int gia1 = 15000;//km<=1
            int gia2 = 13500;//1<k<=5
            int gia3 = 11000;//km>5
            Console.OutputEncoding = Encoding.Unicode;
            if (km <= 1)
            {
                tinhtientaxi = km * gia1;
                Console.WriteLine(" số tiền đi taxi là : "+tinhtientaxi+"đ");
            }else if(1<km && km <= 5)
            {
                tinhtientaxi = km * gia1 + (km - 1) * gia2;
                Console.WriteLine(" số tiền đi taxi là : " + tinhtientaxi + "đ");
            }else if(5<km && km <= 120)
            {
                tinhtientaxi = km * gia1 + 4 * gia2 + (km - 5) * gia3;
                Console.WriteLine(" số tiền đi taxi là : " + tinhtientaxi + "đ");
            }else 
            {
                tinhtientaxi = (km * gia1 + 4 * gia2 + (km - 5) * gia3)*0.9;
                Console.WriteLine(" số tiền đi taxi là : " + tinhtientaxi + "đ");
            }
            
        }
    }
}
