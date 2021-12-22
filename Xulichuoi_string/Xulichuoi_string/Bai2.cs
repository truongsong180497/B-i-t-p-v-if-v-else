using System;
using System.Collections.Generic;
using System.Text;

namespace Xulichuoi_string
{
    class Bai2
    {
        public static void Main()
        {
            Console.WriteLine("nhap vao 1 chuoi:");
            string st = Convert.ToString(Console.ReadLine());
            string chain = st.ToLower();
            Console.WriteLine("so ky tu trong chuoi la:");
            Console.WriteLine(st.Length);
            int vowel = 0;
            int consonant = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if(chain[i]=='a'|| chain[i] =='e'|| chain[i] =='o'|| chain[i] =='i'|| chain[i] == 'u')
                {                  
                    vowel++;
                }else if (chain[i] >= 'a' && chain[i] <= 'z')
                {                    
                    consonant++;
                }
            }
            Console.WriteLine("so ky tu nguyen am trong chuoi la:");
            Console.WriteLine(vowel);
            Console.WriteLine("so ky tu phu am trong chuoi la:");
            Console.WriteLine(consonant);
            int numberword = 0;
            for (int i = 0; i <chain.Length-1; i++)
            {
               if(chain[i]!=' ' && chain[i+1]==' ' || chain[i] != ' ' && chain[i + 1] != ' '&&
                    (i+1)==(chain.Length - 1))
                {
                    numberword++;
                }            
            }
            Console.WriteLine("so tu trong chuoi la:");
            Console.WriteLine(numberword);
        }
    }
}
