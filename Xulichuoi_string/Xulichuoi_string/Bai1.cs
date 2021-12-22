using System;
using System.Collections.Generic;
using System.Text;

namespace Xulichuoi_string
{
    class Bai1
    {
        public static void Main()
        {
            Console.WriteLine("nhap 1 chuoi:");
            string st = Console.ReadLine();
            Console.WriteLine("nhap 1 ky tu");
            char kt = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if (kt == st[i])
                {
                    count++;
                }
            }
            Console.WriteLine("so lan xuat hien cua ky tu trong chuoi la:");
            Console.WriteLine(count);
        }
    }
}
