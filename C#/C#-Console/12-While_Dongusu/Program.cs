using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_While_Dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i;
            i = 1;
            while (i < 10)
            {
                Console.WriteLine("Hey Sen!");
                i++;
            }
            Console.ReadLine();
            */


            /*
            int i;
            i = 1;
            while (i < 400)
            {
                Console.WriteLine(i);
                i++;
                //1-399 arası bütün sayılar yazılır, 400 YAZILMAZ!
            }
            Console.ReadLine();
            */


            /*
            int sayi;
            Console.WriteLine("Bir sayı girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            while (sayi % 2 == 0)
            {
                Console.WriteLine("Bir sayı girin: ");
                sayi = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Tek sayı girdiniz!");
            Console.ReadLine();
            */


            
            int sayi;
            Console.WriteLine("Faktoriyeli alınacak sayıyı girin:");
            sayi = Convert.ToInt32(Console.ReadLine());
            int fakt = 1;

            while (sayi > 1)
            {
                fakt = fakt * sayi;
                sayi--;
            }
            Console.WriteLine(fakt);
            Console.Read();

        }
    }
}
