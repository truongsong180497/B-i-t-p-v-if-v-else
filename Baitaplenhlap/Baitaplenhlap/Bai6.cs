using System;
using System.Collections.Generic;
using System.Text;

namespace Baitaplenhlap
{
    class Bai6
    {
        static void Main()
        {
            Console.WriteLine("Nhap n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Vui long nhap lai n>0");
            }
            else
            {
                Console.WriteLine("cac so fibonacy la :");
                int f0 = 0;
                int f1 = 1;
                int fn = f0 + f1;
                for (int i = 0; i < n; i++)
                {
                    fn = f0 + f1;
                    f0 = f1;
                    f1 = fn;
                    Console.Write(fn + " ");
                }
               
            }
        }

        
    }
}
