using System;
using System.Collections.Generic;
using System.Text;

namespace Xulichuoi_string
{
    class Bai3
    {
       public static void Main()
        {
            Console.WriteLine("nhap 1 chuoi :");
            string st = Console.ReadLine();
                    
            //kiem tra dieu kien chuoi doi xung
            string check = "";
            for (int i = st.Length-1; i>= 0; i--)
            {
                check = check + st[i];
            }            
            if (check == st)
            {
                Console.WriteLine("day la chuoi doi xung !");
            }
            else
            {
                Console.WriteLine("day k phai la chuoi doi xung!");
            }
        }
    }
}
