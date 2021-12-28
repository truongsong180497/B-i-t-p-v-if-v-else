using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collecton
{
    class Program
    {
        public static void Main()
        {
            Student student = new Student("1","song",24,9);
            Student student1 = new Student("2", "thao", 21, 8);
            Student student2 = new Student("3", "doan", 20, 9);
            Student student3 = new Student("4", "tai", 25, 7);
            Student student4 = new Student("5", "hoa", 18, 6);
            ArrayList arrstudent = new ArrayList();
            arrstudent.Add(student);
            arrstudent.Add(student1);
            arrstudent.Add(student2);
            arrstudent.Add(student3);
            arrstudent.Add(student4);
            //xuat 
            Console.WriteLine("hien thi danh sach sv:");
            foreach (Student std in arrstudent)
            {
                std.output_student();
            }
            //tim ten 
            Console.WriteLine("tiem ten sv trong list");
            string name = "hai";
            Student obj = null;
            foreach (Student std in arrstudent)
            {
                if (name == std.get_name())
                {
                    obj = std;
                }               
            }
            if (obj != null)
            {
                obj.output_student();
            }
            else
            {
                Console.WriteLine("not found list");
            }
            //tim mssv
            Console.WriteLine("tim mssv thay doi diem :");
            string code = "2";
            Student obj_code = null;
            foreach (Student std in arrstudent)
            {
                if (code == std.get_code())
                {
                    obj_code = std;
                }
            }
            if (obj_code != null)
            {
                obj_code.set_mark(10);
            }
            else
            {
                Console.WriteLine("not found list:");
            }
            obj_code.output_student();
            //
            Console.WriteLine("duyet sv dc nhan hoc bong :");          
            foreach (Student std in arrstudent)
            {
                if (std.get_mark() > 8)
                {
                    std.output_student();
                }                              
            }
            //xem diem sv
            Console.WriteLine("xem diem cua sv:");
            string code1 = "3";
            Student obj2 = null;
            foreach (Student std in arrstudent)
            {
                if (code1 == std.get_code())
                {
                    obj2 = std;
                }
            }
            if (obj2 != null)
            {
                obj2.output_student();
            }
            else
            {
                Console.WriteLine("not found list");
            }

        }
    }
}
