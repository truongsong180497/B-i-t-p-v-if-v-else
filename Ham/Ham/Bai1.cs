using System;
using System.Collections.Generic;
using System.Text;

namespace Ham
{
    class Bai1
    {
        static void Main()
        {
            Console.WriteLine("nhap a = ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap b = ");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap c = ");
            float c = Convert.ToInt32(Console.ReadLine());
            giaipt2(a, b, c);
        }
        
        //ax^2+bx+c
        public static void giaipt2(float a,float b,float c)
        {
            if (a == 0) //bx+c
            {
                if(b==0 && c == 0)
                {
                    Console.WriteLine("pt co vo so nghiem");
                }else if(b==0 && c != 0)
                {
                    Console.WriteLine("pt vo nghiem");
                }
                else
                {
                    float x = -c / b;
                    Console.WriteLine("pt co 1 nghiem x = "+x);
                }
            }
            else //ax^2+bx+c
            {
                float denta = b * b - 4 * a * c;
                if (denta > 0)
                {
                    float x1 = (float)(-b + Math.Sqrt(denta)) / (2 * a);
                    float x2 = (float)(-b - Math.Sqrt(denta)) / (2 * a);
                    Console.WriteLine("pt co 2 nghiem ");
                    Console.WriteLine("x1 = "+x1);
                    Console.WriteLine("x2 = " + x2);
                }else if (denta == 0)
                {
                    float x=-b/(2*a);
                    Console.WriteLine("pt co nghiem kep x = "+x);
                }
                else
                {
                    Console.WriteLine("pt vo nghiem");
                }
                
            }
        }
    }
}
