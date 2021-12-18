using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lopdoituong5
{
    class Mark
    {
        private string Tenmonhoc;
        private double Diemlt;
        private double Diemth;
        public Mark()
        {

        }
        public Mark(string tenmonhoc,double diemlt,double diemth)
        {
            this.Tenmonhoc = tenmonhoc;
            this.Diemlt = diemlt;
            this.Diemlt = diemth;
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
            Console.WriteLine("Diem TB:" + tinhDiemtb());
            Console.WriteLine("\n");
        }
        public double tinhDiemtb()
        {
            return (Diemlt + Diemth) / 2;
        }
    }
    class Subject
    {
        public static void Main()
        {
            Console.WriteLine("-------------Menu-------------");
            Console.WriteLine("|    1-Nhap danh sach mon hoc|");
            Console.WriteLine("|    2-Hien thi danh sach    |");
            Console.WriteLine("|    3-Diem TB cao nhat      |");
            Console.WriteLine("|    4-Thoat                 |");
            Console.WriteLine("------------------------------");
            int menu = 0;           
            ArrayList list = new ArrayList();           
            int n = 8;
            do
            {
                Console.WriteLine("xin moi ban chon:");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        for (int i = 0; i < 8; i++)
                        {
                           
                        }
                        break;
                    case 2:
                        for (int i = 0; i < 8; i++)
                        {
                            ((Mark)list[i]).Xuatmonhoc();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Mon hoc co die tb cao nhat la:");
                        Mark max = new Mark();
                        max = (Mark)list[0];
                        for (int i = 1; i < 8; i++)
                        {
                            if (max.tinhDiemtb() < ((Mark)list[i]).tinhDiemtb())
                            {
                                max = (Mark)list[i];
                            }
                        }
                        max.Xuatmonhoc();
                        break;
                    case 4:
                        Console.WriteLine("bye bye ban!chuc ban 1 ngay tot lanh!");
                        break;
                    default:
                        break;
                }
            } while (menu!=4);
        }
    }
}
