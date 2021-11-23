using System;
using System.Collections.Generic;
using System.Text;

namespace Baitaplenhlap
{
    class Bai2
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("nhập ký tự = ");
            char kytu = Convert.ToChar(Console.ReadLine());

            if (kytu >= 'a' && kytu <= 'z' || kytu >= 'A' && kytu <= 'Z')
            {
                Console.WriteLine("ký tự vừa nhập là chữ cái ");
            }else if(kytu>='0' && kytu <= '9')
            {

                Console.WriteLine("ký tự vừa nhập là chữ số ");
            }
            else if(kytu==' ')
            {
                Console.WriteLine("chương trình dừng lại vì nhập ký tự khoảng trắng");
            }
            else
            {
                Console.WriteLine("ký tự vừa nhập là ký tự đặc biệt ");
            }

                
        }


    }
}