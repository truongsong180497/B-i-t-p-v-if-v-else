using System;
using System.Collections.Generic;
using System.Text;

namespace Ham
{
    class Bai8
    {
        static void Main()
        {
            hienthimenu();
            menu();
        }
        public static void hienthimenu()
        {
            Console.WriteLine("+-------------------------------------+");
            Console.WriteLine("|                 Menu                |");
            Console.WriteLine("+-------------------------------------+ ");
            Console.WriteLine("|  1.Menu 1                           |");
            Console.WriteLine("|  2.Menu 2                           |");
            Console.WriteLine("| 3.Menu 3                            |");
            Console.WriteLine("| 4.Menu 4                            |");
            Console.WriteLine("| 5.Exit                              |");
            Console.WriteLine("+-------------------------------------+");
            Console.WriteLine("          please choose :        ");

        }
        public static void menu()
        {
            int n = 0;
            do
            {
                Console.WriteLine("nhap n = ");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("doing menu 1 ...");
                        Console.WriteLine("please choose :");
                        break;

                    case 2:
                        Console.WriteLine("doing menu 2 ...");
                        Console.WriteLine("please choose :");
                        break;
                    case 3:
                        Console.WriteLine("doing menu 3 ...");
                        Console.WriteLine("please choose :");
                        break;
                    case 4:
                        Console.WriteLine("doing menu 4 ...");
                        Console.WriteLine("please choose :");
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;


                    default:
                        Console.WriteLine("ban nhap sai vui long nhap lai");

                        break;


                }
            } while (n != 5);
        }
    }
}
