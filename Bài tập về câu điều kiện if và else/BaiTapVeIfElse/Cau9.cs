using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapVeIfElse
{
    class Cau9
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(" Nhập A(Xa,Ya) = ");
            Console.WriteLine(" Nhập Xa = ");
            float Xa = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" Nhập Ya = ");
            float Ya = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" Nhập B(Xb,Yb) = ");
            Console.WriteLine(" Nhập Xb = ");
            float Xb = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" Nhập Yb = ");
            float Yb = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" Nhập C(Xa,Ya) = ");
            Console.WriteLine(" Nhập Xc = ");
            float Xc = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" Nhập Yc = ");
            float Yc = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" Kết quả :");
            float AB, BC, CA;// 3 canh tam giac 
            AB =(float) Math.Sqrt((Xb - Xa) * (Xb - Xa) + (Yb - Ya) * (Yb - Ya));
            BC = (float)Math.Sqrt((Xc - Xb) * (Xc - Xb) + (Yc - Yb) * (Yc - Yb));
            CA =(float) Math.Sqrt((Xa - Xc) * (Xa - Xc) + (Ya - Yc) * (Ya - Yc));
            if (AB<(BC+CA) && BC<(AB+CA) && CA<(AB+BC))
            {
                Console.WriteLine(" 3 điểm  A,B,C  tạo thành 1 tam giac ABC ");
                Console.WriteLine("===================================");
                    Console.WriteLine(" Nhập D(Xd,Yd) = ");
                    Console.WriteLine(" Nhập Xd = ");
                    float Xd = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(" Nhập Yd = ");
                    float Yd = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine(" Kết quả : ");
                    float AD, BD, CD;
                    AD =(float) Math.Sqrt((Xd - Xa) * (Xd - Xa) + (Yd - Ya) * (Yd - Ya));
                    BD = (float)Math.Sqrt((Xd - Xb) * (Xd - Xb) + (Yd - Yb) * (Yd - Yb));
                    CD = (float)Math.Sqrt((Xd - Xc) * (Xd - Xc) + (Yd - Yc) * (Yd - Yc));
                if ((AD + BD + CD) <= (AB + BC + CA))
                {
                    Console.WriteLine(" Điểm D nằm trong tam giác ABC");
                }
                else
                {
                    Console.WriteLine(" Điểm D nằm ngoài tam giác ABC");
                }
                
            }
            else
            {
                Console.WriteLine(" 3 điểm  A,B,C không tạo thành 1 tam giac ABC");
            }
        }

    }
}
