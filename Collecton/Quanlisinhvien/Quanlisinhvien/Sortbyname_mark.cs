using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Quanlisinhvien
{
    class Sortbyname_mark : IComparer<Student>
    {
        public int Compare([AllowNull] Student x, [AllowNull] Student y)
        {
            int result = 0;                     
            if (x.get_mark()>y.get_mark())
            {
                result = -1;
            }else 
            {
                result = 1;
            }
            if(x.get_mark() == y.get_mark())
            {
                result= x.get_name().CompareTo(y.get_name());
            }
            return result;
        }
    }
}
