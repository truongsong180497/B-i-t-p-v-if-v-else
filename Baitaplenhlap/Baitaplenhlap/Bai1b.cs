using System;
using System.Collections.Generic;
using System.Text;

namespace Baitaplenhlap
{
    class Bai1b
    {
        static void Main()
        {
            Console.WriteLine("nha A = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nha B = ");
            int B = Convert.ToInt32(Console.ReadLine());
            if (B == 0)
            {
                Console.WriteLine("Error divide by zero");
            }
            else
            {
                double C =1.0* A / B;
                Console.WriteLine(" C = "+C);
            }
        }
    }
}
