using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bai4
{
    class Sortbysum_name : IComparer<Product>
    {
        public int Compare([AllowNull] Product x, [AllowNull] Product y)
        {
            int result = 0;
            if (x.sum_money() > y.sum_money())
            {
                result = -1;
            }
            else
            {
                result = 1;
            }
            if(x.sum_money() == y.sum_money())
            {
                result = x.get_name_product().CompareTo(y.get_name_product());
            }
            return result;
        }
    }
}
