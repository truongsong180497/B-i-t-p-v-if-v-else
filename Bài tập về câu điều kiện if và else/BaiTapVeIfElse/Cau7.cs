using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapVeIfElse
{
    class Cau7
    {
        

        static void Main()
        {
            Console.WriteLine("        MENU       ");
            Console.WriteLine("====================");
            Console.WriteLine("1.CF");
            Console.WriteLine("2.C");
            Console.WriteLine("3.HDJ");
            Console.WriteLine("4.DreamWeaver");
            Console.WriteLine("5.RDBMS");
            Console.WriteLine("6.learn Java By Example");
            Console.WriteLine("====================");
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("vui lòng nhập sự lựa chọn ");
            int Menu = Convert.ToInt32(Console.ReadLine());
           
            switch (Menu)
            {
                case 1:
                    Console.WriteLine("Bạn Chọn CF!");
                    break;
                case 2:
                    Console.WriteLine("Bạn Chọn C!");
                    break;
                case 3:
                    Console.WriteLine("Bạn Chọn HDJ!");
                    break;
                case 4:
                    Console.WriteLine("Bạn Chọn DreamWeaver!");
                    break;
                case 5:
                    Console.WriteLine("Bạn Chọn RDBMS!");
                    break;
                case 6:
                    Console.WriteLine("Bạn Chọn learn Java By Example!");
                    break;
                
                default:
                    break;
            }
        }
    }
}
