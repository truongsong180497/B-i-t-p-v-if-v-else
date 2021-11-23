using System;
using System.Collections.Generic;
using System.Text;

namespace Baitaplenhlap
{
    class Bai4
    {
        static void Main()
        {
            Console.WriteLine("SO THICH CA NHAN");
            Console.WriteLine("================");
            Console.WriteLine("1.Doc sach");
            Console.WriteLine("2.Nghe nhac");
            Console.WriteLine("3.Choi the thao");
            Console.WriteLine("4.May tinh");
            Console.WriteLine("5.Thoat");
            Console.WriteLine("================");
            Console.WriteLine("Chon:");
            int chon = Convert.ToInt32(Console.ReadLine());
            switch (chon)
            {
                case 1:
                    Console.WriteLine("Doc sach");
                    break;
                case 2:
                    Console.WriteLine("Nghe nhac");
                    break;
                case 3:
                    Console.WriteLine("Choi the thao");
                    break;
                case 4:
                    Console.WriteLine("May tinh");
                    break;
                case 5:
                    Console.WriteLine("Thoat");                   
                    break;
                default:
                    Console.WriteLine("Ban chon sai , vui long chon lai");
                    break;
            }
        }
    }
}
