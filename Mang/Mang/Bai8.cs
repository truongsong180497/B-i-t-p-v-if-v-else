using System;
using System.Collections.Generic;
using System.Text;

namespace Mang
{
    class Bai8
    {
        static void Main()
        {
            char[] arr = new char[10];
            for (int i = 0; i < 10; i++)
            {
                while(checkdk(arr[i])==false)
                {
                    Console.WriteLine("nhap ky tu thu "+i+" : ");
                    arr[i] = Convert.ToChar(Console.ReadLine());
                }
            }
            Console.WriteLine("mang arr chu thuong :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nmang arr chu hoa:");
            for (int i = 0; i < 10; i++)
            {
                char ch = arr[i];
                if (char.IsLower(ch))
                {
                    Console.Write(char.ToUpper(ch)+" ");
                }
            }

        }
        static bool checkdk(char n)
        {
            
            if (n >= 'a' && n <= 'z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
