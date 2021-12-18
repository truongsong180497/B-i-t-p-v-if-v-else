using System;
using System.Collections.Generic;
using System.Text;

namespace Lopdoituong
{
     class Mark
    {
        private string TenMonHoc;
        private float DiemlT;
        private float DiemTH;       
        public float TinhDTB()
        {
            return (DiemlT + DiemTH) / 2;
        }
        public void NhapMonHoc()
        {
           
                Console.WriteLine("Nhap ten mon hoc:");
                TenMonHoc = Convert.ToString(Console.ReadLine());
                Console.WriteLine("nhap diem ly thuyet:");
                DiemlT = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("nhap diem thuc hanh:");
                DiemTH = Convert.ToInt32(Console.ReadLine());
           
        }
        public void XuatMonHoc()
        {
            
                Console.WriteLine("THONG TIN VE MON HOC");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Ten mon hoc:" + TenMonHoc);
                Console.WriteLine("Diem ly thuyet:" + DiemlT);
                Console.WriteLine("Diem thuc hanh:" + DiemTH);
                Console.WriteLine("Diem trung binh:" + TinhDTB());
                     
        }
    }
}
