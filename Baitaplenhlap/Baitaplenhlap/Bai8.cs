using System;
using System.Collections.Generic;
using System.Text;

namespace Baitaplenhlap
{
    class Bai8
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("nhập n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            string nhiphan="" ;
            while (n > 0)
            {
                nhiphan = n % 2 + nhiphan;
                n = n / 2;
            }
            Console.WriteLine("số nhị phân của n là :");
            Console.WriteLine(nhiphan);
        }
    }
}
    
