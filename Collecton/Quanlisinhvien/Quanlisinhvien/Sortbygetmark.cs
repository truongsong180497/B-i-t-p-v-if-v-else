using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Quanlisinhvien
{
    class Sortbygetmark : IComparer<Student>
    {
        public int Compare([AllowNull] Student x, [AllowNull] Student y)
        {
            return y.get_mark().CompareTo(x.get_mark());
        }
    }
}
