using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapVeIfElse
{
    class Cau6
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine(" nhập kí tự Alphabet(A-Z,a-z) =  ");
            char kitu = Convert.ToChar(Console.ReadLine());
            
            
            if ((kitu>='A'&&kitu<='Z') || (kitu >= 'a' && kitu <= 'z'))
            {
                Console.WriteLine("kí tự vừa nhập  thuộc bảng chữ cái ");
                Console.WriteLine("===================================");
                if(kitu=='A'||kitu=='E'||kitu=='I'||kitu=='Y'||kitu=='O'||kitu=='U'|| kitu == 'a' || kitu == 'e' || kitu == 'i' || kitu == 'y' || kitu == 'o' || kitu == 'u')
                {
                    Console.WriteLine("kí tự vừa nhập vào là nguyên âm ");
                }
                else
                {
                    Console.WriteLine(" kí tự vừa nhập vào là phụ âm ");
                }
            }
            else
            {
                Console.WriteLine(" kí tự vừa nhập không thuộc bảng chữ cái ");
            }

        }

    }
}
