using System;

namespace BaiTapVeIfElse
{
    class Cau1a
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" nhap a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" nhap b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Error divide by zezo");
            }
            else
            {
                float c = (float)a / b;
                Console.WriteLine("Display C="+c);
            }
             

        }
    }
}
