using System;
using System.Collections.Generic;
using System.Text;

namespace Lopdoituong4
{
    class Account
    {
        private int Sotaikhoan;
        private string Tentaikhoan;
        private double Sodutaikhoan;
        private double Laisuattaikhoan;
        public Account(string tentaikhoan,int sotaikhoan,double sodutaikhoan)
        {
            this.Tentaikhoan = tentaikhoan;
            this.Sotaikhoan = sotaikhoan;
            this.Sodutaikhoan = sodutaikhoan;
        }

        public double GuiTien(double n)
        {           
            if (n<0) 
            {
                Console.WriteLine("So tien gui vao khong hop le! vui long kiem tra lai!");
            }
            else
            {
                Sodutaikhoan = Sodutaikhoan + n;
            }
            return Sodutaikhoan;
        }
        public double RutTien(double n)
        {              
            if (n < 0)
            {
                Console.WriteLine("So tien rut khong hop le! vui long kiem tra lai!");
            }else if (n > Sodutaikhoan)
            {
                Console.WriteLine("Giao dich rut tien khong duoc thuc hien!");
            }
            else
            {
                Sodutaikhoan = Sodutaikhoan - n;
            }
            return Sodutaikhoan;
          
        }
        public double Tienlai(double n)
        {
            Sodutaikhoan = Sodutaikhoan + 0.045 * n;
            return Sodutaikhoan;
        }
        public double Get_Sotaikhoan()
        {
            return Sotaikhoan;
        }
        public double Get_Sodu()
        {           
            return Sodutaikhoan;
        }
        public void print()
        {
            Console.WriteLine("name:"+Tentaikhoan);
            Console.WriteLine("stk:"+Sotaikhoan);
            Console.WriteLine("sodu:"+Sodutaikhoan);
        }
        
    }
    
}
