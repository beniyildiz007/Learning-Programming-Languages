using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Donguler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //120 Sayısının Bölenleri:
            int sayi = 120;
            for(int i = 1; i < 120; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            */


            int a = 1, b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for(int i = 1; i <= 8; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
