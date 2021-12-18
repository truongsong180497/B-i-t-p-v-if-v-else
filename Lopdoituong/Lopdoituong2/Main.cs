using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lopdoituong2
{
    class Run
    {
        public static void Main()
        {
            Console.WriteLine("DANH MUC SAN PHAM");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(string.Format("{0,-10} {1,-15} {2,-10} {3,-10} {4,-10}", "|STT|",
                "Ten san pham |", "So luong |", "Don gia($) |", "Tong tien($) |"));
            Console.WriteLine("-----------------------------------------------------------------");
            Product p = new Product("May in",5,150);
            Console.Write("| 1 |"); p.Print();
            Product p1 = new Product("Man hinh LCD", 10, 350);
            Console.Write("| 2 |"); p1.Print();
            Product p2 = new Product("Chuot Mitsumi", 25, 10);
            Console.Write("| 3 |"); p2.Print();
            Product p3 = new Product("Ban phim", 10, 12);
            Console.Write("| 4 |"); p3.Print();
            Product p4 = new Product("USB 2G", 100, 13);
            Console.Write("| 5 |"); p4.Print();
            Console.WriteLine("-----------------------------------------------------------------");
            double sum=p.tongtien() + p1.tongtien() + p2.tongtien() + p3.tongtien() + p4.tongtien();
            Console.WriteLine("|                                                           "+sum+"|");
            Console.WriteLine("-----------------------------------------------------------------");
        }
       
    }
}
