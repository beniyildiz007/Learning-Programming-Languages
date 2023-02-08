using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Diziler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Pozitif tek sayıları yazdır
            int[] sayilar = { 4, 1, 7, -8, 23, 14, 51, 84, -75, 26, -8, 9 };
            foreach(int i in sayilar)
            {
                if (i > 0 && i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            */


            
            //Kullanıcının girdiği 5 sayıyı sıralama
            int[] sayilar = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Sayıyı Girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(sayilar);
            Array.Reverse(sayilar); //Diziyi tersten yazdırır.

            foreach(int i in sayilar)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("En Küçük Eleman: " + sayilar[4]);
            Console.WriteLine("En Büyük Eleman: " + sayilar[0]);
            Console.WriteLine("Dizinin Boyutu: " + sayilar.Length);
            Console.Read();
            




        }
    }
}
