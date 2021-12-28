using System;
using System.Collections.Generic;
using System.Text;

namespace Quanlisinhvien
{
    class Student
    {
        private string s_code;
        private string s_name;
        private int s_age;
        private float s_mark;
        public void input_student()
        {
            Console.WriteLine("Nhap s_code:");
            s_code = Console.ReadLine();
            Console.WriteLine("Nhap s_name:");
            s_name = Console.ReadLine();
            Console.WriteLine("Nhap s_age:");
            s_age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap s_mark:");
            s_mark= Convert.ToSingle(Console.ReadLine());
        }
        public void output_student()
        {
            Console.WriteLine("Danh sach sinh vien ");
            Console.WriteLine("Mssv:"+s_code);
            Console.WriteLine("Ten sv:"+s_name);
            Console.WriteLine("Tuoi sv:"+s_age);
            Console.WriteLine("Dtb sv:"+s_mark);
            Console.WriteLine("--------------------");
        }
        public bool check_scholarship()
        {
            if (s_mark > 8)
            {
                return true;
            }           
            return false;
        }
        public string get_name()
        {
            return s_name;
        }
        public string get_code()
        {
            return s_code;
        }
        public float get_mark()
        {
            return s_mark;
        }
        public void set_mark(float newMark)
        {
            this.s_mark = newMark;
        }
    }
}
