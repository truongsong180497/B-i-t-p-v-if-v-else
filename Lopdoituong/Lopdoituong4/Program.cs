using System;
using System.Collections.Generic;
using System.Text;

namespace Lopdoituong4
{
    class Program
    {
        public static void Main()
        {
            Account accbill = new Account("Bill gate", 12345, 100000);
            Console.WriteLine("hien thi thong tin:");
            Console.WriteLine("So tien trong tai khoan cua Bill ban dau la:");
            accbill.print();
            Console.WriteLine("So tien trong tai khoan cua Bill khi gui tien vao:");
            accbill.GuiTien(50000);
            accbill.Tienlai(50000);
            accbill.print();
            Console.WriteLine("So tien trong tai khoan cua Bill sau khi rut tien:");
            accbill.RutTien(4200);
            accbill.print();
            accbill.RutTien(200000);
        }
    }
}
