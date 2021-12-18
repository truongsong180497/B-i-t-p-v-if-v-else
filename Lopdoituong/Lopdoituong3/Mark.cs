using System;
using System.Collections.Generic;
using System.Text;

namespace Lopdoituong3
{
    class Mark
    {
        private string Tenmonhoc;
        private double Diemlt;
        private double Diemth;
        public Mark()
        {

        }      
        public void Nhapmonhoc()
        {

            Console.WriteLine("Nhap ten mon hoc:");
            Tenmonhoc = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap diem ly thuyet:");
            Diemlt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap diem thuc hanh:");
            Diemth = Convert.ToDouble(Console.ReadLine());
        }
        public void Xuatmonhoc()
        {
            Console.WriteLine("DANH SANH MON HOC");
            Console.WriteLine("-----------------");
            Console.WriteLine("Ten mon hoc :" + Tenmonhoc);
            Console.WriteLine("Diem ly thuyet :" + Diemlt);
            Console.WriteLine("Diem thuc hanh :" + Diemth);
            Console.WriteLine("Diem TB:"+tinhDiemtb());
            Console.WriteLine("\n");
        }
        public double tinhDiemtb()
        {
            return (Diemlt + Diemth) / 2;
        }
    }
    class Student
    {
        public static void Main()
        {
            Console.WriteLine("-------------Menu-------------");
            Console.WriteLine("|    1-Nhap danh sach mon hoc|");
            Console.WriteLine("|    2-Hien thi danh sach    |");
            Console.WriteLine("|    3-Diem TB cao nhat      |");
            Console.WriteLine("|    4-Thoat                 |");
            Console.WriteLine("------------------------------");            
            Mark s = new Mark();
            Mark s1 = new Mark();
            Mark s2 = new Mark();
            Mark s3 = new Mark();
            Mark s4 = new Mark();
            Mark s5 = new Mark();
            Mark s6 = new Mark();
            Mark s7 = new Mark();
            int Menu;
            do
            {
                Console.WriteLine("Xin moi ban chon :");
                 Menu = Convert.ToInt32(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        s.Nhapmonhoc();
                        s1.Nhapmonhoc();
                        s2.Nhapmonhoc();
                        s3.Nhapmonhoc();
                        s4.Nhapmonhoc();
                        s5.Nhapmonhoc();
                        s6.Nhapmonhoc();
                        s7.Nhapmonhoc();
                        break;
                    case 2:
                        s.Xuatmonhoc();
                        s1.Xuatmonhoc();
                        s2.Xuatmonhoc();
                        s3.Xuatmonhoc();
                        s4.Xuatmonhoc();
                        s5.Xuatmonhoc();
                        s6.Xuatmonhoc();
                        s7.Xuatmonhoc();
                        break;
                    case 3:
                        Console.WriteLine("Diem TB cao nhat trong cac mon hoc la :");
                        double a=s.tinhDiemtb();
                        double a1=s1.tinhDiemtb();
                        double a2=s2.tinhDiemtb();
                        double a3=s3.tinhDiemtb();
                        double a4=s4.tinhDiemtb();
                        double a5=s5.tinhDiemtb();
                        double a6=s6.tinhDiemtb();
                        double a7=s7.tinhDiemtb();
                        double[] b = { a, a1, a2, a3, a4, a5, a6, a7 };
                        double max = b[0];
                        for (int i = 0; i < 8; i++)
                        {
                            if (max < b[i])
                            {
                                max = b[i];
                            }
                        }
                        Console.WriteLine(max);
                        
                        break;
                    case 4:
                        Console.WriteLine("Tam biet ban! chuc ban 1 ngay tot lanh.");
                        break;
                    default:
                        break;
                }
            } while (Menu!=4);
        }
    }
}
