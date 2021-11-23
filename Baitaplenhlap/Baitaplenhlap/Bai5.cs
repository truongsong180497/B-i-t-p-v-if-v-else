using System;
using System.Collections.Generic;
using System.Text;

namespace Baitaplenhlap
{
    class Bai5
    {
        static void Main()
        {
            Console.WriteLine("nhap n>0 = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;// tong chu so trong 1 so 
            int sodu = 0;
            while (n > 0)
            {
                sodu = n % 10;
                n /= 10;
                sum += sodu;
            }
            Console.WriteLine("Tong cac chu so trong 1 so la sum = "+sum);

        }
    }
}
