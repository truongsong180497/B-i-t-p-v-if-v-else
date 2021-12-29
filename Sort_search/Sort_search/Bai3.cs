using System;
using System.Collections.Generic;
using System.Text;

namespace Sort_search
{
    public class Mark
    {
        private string Name_subject;
        private float Mark_theory;
        private float Mark_practice;       
        public float Mark_everage()
        {
            return (Mark_theory + Mark_practice) / 2;
        }
        public void input_subject()
        {
            Console.WriteLine("Nhap ten mon hoc:");
            Name_subject = Console.ReadLine();
            Console.WriteLine("Nhap diem ly thuyet:");
            Mark_theory = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhap diem thuc hanh:");
            Mark_practice = Convert.ToSingle(Console.ReadLine());
        }
        public void output_subject()
        {
            Console.WriteLine("DANH SACH MON HOC");
            Console.WriteLine("Name_subject:"+Name_subject);
            Console.WriteLine("Mark_theory :"+Mark_theory);
            Console.WriteLine("Mark_practice :"+Mark_practice);
            Console.WriteLine("Mark everage:"+Mark_everage());
            Console.WriteLine("-----------------------------");
        }
    }
}
