using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Quanlisanpham
{
    class Sortbyprice : IComparer<Product>
    {
        public int Compare([AllowNull] Product x, [AllowNull] Product y)
        {
            return y.get_price_product().CompareTo(x.get_price_product());
        }
    }
}
