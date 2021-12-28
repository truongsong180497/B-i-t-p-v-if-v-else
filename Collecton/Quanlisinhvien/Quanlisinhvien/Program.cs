using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Quanlisinhvien
{
    class Program
    {
        public static void Main()
        {
            List<Student> list = new List<Student>();
            Console.WriteLine("Chuong trinh quan ly danh sach sinh vien su dung ArrayList");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("1- khoi tao danh sach.");
            Console.WriteLine("2- them 1 sinh vien vao danh sach.");
            Console.WriteLine("3- duyet danh sach.");
            Console.WriteLine("4- tim thong tin sinh vien theo ten sinh vien.");
            Console.WriteLine("5- sua diem cho sinh vien.");
            Console.WriteLine("6- danh sach sinh vien duoc nhan hoc bong.");
            Console.WriteLine("7- xem diem cua sinh vien.");
            Console.WriteLine("8- sap xep danh sach giam dan theo DTB.");
            Console.WriteLine("9- sap xep danh sach giam dan theo DTB, tang dan theo ten.");
            Console.WriteLine("10- thoat chuong trinh.");
            int n = 0;
            do
            {
                Console.WriteLine("xin moi ban chon:");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        khoitao(list);
                        break;
                    case 2:
                        them1sv(list);
                        break;
                    case 3:
                        hienthi(list);
                        break;
                    case 4:
                        timtensv(list);
                        break;
                    case 5:
                        suadiemsv(list);
                        break;
                    case 6:
                        svnhanhocbong(list);
                        break;
                    case 7:
                        xemdiemsv(list);
                        break;
                    case 8:
                        sapxeptheodiemtb(list);
                        hienthi(list);
                        break;
                    case 9:
                        sapxeptheodiemvaten(list);
                        hienthi(list);
                        break;
                    case 10:
                        Console.WriteLine("bye bye ban! hen gap lai!");
                        break;
                    default:
                        break;
                }
            } while (n != 10);

        }

        private static void sapxeptheodiemvaten(List<Student> list)
        {
            list.Sort(new Sortbyname_mark());
        }

        private static void sapxeptheodiemtb(List<Student> list)
        {
            list.Sort(new Sortbygetmark());
        }

        private static void xemdiemsv(List<Student> list)
        {
            Console.WriteLine("Nhap mssv can xem diem");
            string code = Console.ReadLine();
            Student student = null;
            foreach (Student item in list)
            {
                if (code == item.get_code())
                {
                    student = item;
                }
            }
            if (student != null)
            {
                student.output_student();
            }
            else
            {
                Console.WriteLine("not found sv in list");
            }
        }

        private static void svnhanhocbong(List<Student> list)
        {
            Student student = null;
            Console.WriteLine("danh sach sv nhan duoc hoc bong la:");
            foreach (Student item in list)
            {
                if (item.check_scholarship()==true)
                {
                    student = item;
                    student.output_student();
                }                        
            }
            if (student == null)
            {
                Console.WriteLine("khong co sv nao nhan duoc hoc bong");
            }
           
        }

        private static void suadiemsv(List<Student> list)
        {
            Console.WriteLine("Nhap mssv can tim:");
            string code = Console.ReadLine();
            Student student = null;
            foreach (Student item in list)
            {
                if (code == item.get_code())
                {
                    student = item;
                }
            }
            if (student != null)
            {
                Console.WriteLine("Nhap diem can sua cho sv");
                float s_mark = Convert.ToSingle(Console.ReadLine());
                student.set_mark(s_mark);
            }
            else
            {
                Console.WriteLine("not found sv list");
            }
        }

        private static void timtensv(List<Student> list)
        {
            Console.WriteLine("Nhap ten sv can tim:");
            string name = Console.ReadLine();
            Student student = null;
            foreach (Student item in list)
            {
                if (name == item.get_name())
                {
                    student = item;
                }
            }
            if (student != null)
            {
                student.output_student();
            }
            else
            {
                Console.WriteLine("not found sv list");
            }
        }

        private static void them1sv(List<Student> list)
        {
            Student student = new Student();
            student.input_student();
            list.Add(student);
        }

        private static void hienthi(List<Student> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                ((Student)list[i]).output_student();
            }
        }

        private static void khoitao(List<Student> list)
        {
            Console.WriteLine("Nhap so sv trong list:");
            int n = Convert.ToInt32(Console.ReadLine());           
            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                student.input_student();
                list.Add(student);
            }
        }
    }
}
