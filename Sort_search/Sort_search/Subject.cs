using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Sort_search
{
    class Subject :IComparer<Mark>
    {
        public static void Main()
        {
            List<Mark> list = new List<Mark>();
            khoitao(list);
            Console.WriteLine("DANH SACH MON HOC BAN DAU:");
            hienthi(list);
            Console.WriteLine("DANH SACH MON HOC KHI SAP XEP GIAM THEO DTB:");
            sapxepgiam(list);
            hienthi(list);
        }

        private static void sapxepgiam(List<Mark> list)
        {
            list.Sort(new Subject());
        }

        private static void hienthi(List<Mark> list)
        {
            foreach (Mark item in list)
            {
                item.output_subject();
            }
        }

        private static void khoitao(List<Mark> list)
        {
            int n = 8;
            for (int i = 0; i < n; i++)
            {
                Mark subject = new Mark();
                subject.input_subject();
                list.Add(subject);
            }
        }

        public int Compare([AllowNull] Mark x, [AllowNull] Mark y)
        {
           return  y.Mark_everage().CompareTo(x.Mark_everage());
        }
    }
}
