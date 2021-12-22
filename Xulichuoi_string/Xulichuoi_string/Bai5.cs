using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Xulichuoi_string
{
    class Bai5
    {
       public static void Main()
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine("|                         Menu                      |");
            Console.WriteLine("+---------------------------------------------------+");
            Console.WriteLine("| 1.Khoi tao danh sach hoc vien                     |");
            Console.WriteLine("| 2.Nhap them mot hoc vien moi                      |");
            Console.WriteLine("| 3.tim kiem hoc vien                               |");
            Console.WriteLine("| 4.Chuan hoa ten hoc vien                          |");
            Console.WriteLine("| 5.Hien thi danh sach hoc vien                     |");
            Console.WriteLine("| 6.Thoat chuong trinh                              |");
            Console.WriteLine("+---------------------------------------------------+");
            int n=0;
            do
            {
                Console.WriteLine("Moi ban chon:");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        khoitaodanhsach(list);
                        break;
                    case 2:
                        themhocvien(list);
                        break;
                    case 3:
                        timkiemhocvien(list);
                        break;
                    case 4:
                        chuanhoaten(list);
                        break;
                    case 5:
                        hienthidanhsach(list);
                        break;
                    case 6:
                        Console.WriteLine("thoat chuong trinh");
                        break;
                    default:
                        break;
                }
            } while (n!=6);

        }

        private static void chuanhoaten(ArrayList list)
        {
            int n = list.Count;
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("nhap ten hoc vien can chuan hoa :");
                string st = Console.ReadLine();               
                st = st.Trim();
                st = st.ToLower();
                //xoa ki tu dac biet
                string st1 = "";
                for (int i = 0; i < st.Length; i++)
                {
                    if (st[i] >= '0' && st[i] <= '9' || st[i] >= 'a' && st[i] <= 'z' || st[i] == ' ')
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
                st = st2;
                Console.WriteLine("ten hoc vien sau khi chuan hoa la:");
                Console.WriteLine(st);
            }          
        }

        private static void timkiemhocvien(ArrayList list)
        {
            Console.WriteLine("nhap ten hoc vien can tim kiem:");
            string n = Console.ReadLine();
            if (list.Contains(n) == true)
            {
                Console.WriteLine("hoc vien co trong danh sach list :"+n);
            }
            else
            {
                Console.WriteLine("hoc vien khong co trong danh sach list");
            }
        }

        private static void themhocvien(ArrayList list)
        {
            Console.WriteLine("nhap ten hoc vien can them:");
            string n = Console.ReadLine();
            list.Add(n);
        }

        private static void hienthidanhsach(ArrayList list)
        {
            Console.WriteLine("cac hoc vien trong danh sach la:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        private static void khoitaodanhsach(ArrayList list)
        {
            Console.WriteLine("nhap so hoc vien trong danh sach");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("nhap hoc vien thu " + i + " : ");
                string m = Console.ReadLine();
                list.Add(m);
            }
        }
    }
}
