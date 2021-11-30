using System;
using System.Collections.Generic;
using System.Text;

namespace Mang
{
    class Bai5
    {
        static void Main()
        {

            int[] a = new int[] { 2, 6, 7, 9, 13, 11, 8, 9, 11, 13 };
            Console.WriteLine("mang a:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\nnhap x = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=================================");
            if (x == a[0] || x == a[1] || x == a[2] || x == a[3]
                || x == a[4] || x == a[5] || x == a[6] || x == a[7] || x == a[8] || x == a[9])
            {
                int vitri = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (x == a[i])
                    {
                        vitri = i;
                        break;
                    }
                }
                Console.WriteLine("vi tri dau tien cua x trong mang la :" + vitri);
                int dem = 0;                
                for (int i = 0; i < a.Length; i++)
                {                    
                    if (x == a[i])
                    {
                        dem++;
                    }                    
                }               
                Console.WriteLine("so lan xuat hien cua x trong mang la :" + dem);
            }
            else
            {
                Console.WriteLine("x khong co trong mang so nguyen");
            }





        }



    }
}
