using System;
using System.Collections.Generic;
using System.Text;

namespace Xulichuoi_string
{
    class Bai4
    {
        public static void Main()
        {
            Console.WriteLine("nhap vao 1 chuoi :");
            string st = Console.ReadLine();
            st = st.Trim();
            st = st.ToLower();
            //xoa ki tu dac biet
            string st1 = "";
            for (int i = 0; i < st.Length; i++)
            {
                if(st[i]>='0'&&st[i]<='9'||st[i]>='a'&&st[i]<='z'||st[i]==' ')
                {
                    st1 += st[i];
                }
            }
            st = st1;
            //bo cac khoang trang thua
            while (st.Contains("  "))
            {
                st = st.Replace("  ", " ");
            }
            //viet hoa chu cai dau
            string[] arr = st.Split(' ');
            string st2 = "";
            for (int i = 0; i < arr.Length; i++)
            {
                st2 += arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1) + " ";
            }
            Console.WriteLine("chuoi sau khi chuan hoa la:");
            st = st2;
            Console.WriteLine(st);
        }
    }
}
