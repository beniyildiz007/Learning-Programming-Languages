using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Yildizlarla_Sekil_Cizme_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Girilen kenar uzunluğuna göre İÇİ BOŞ DİKDÖRTGEN çizdirmek:
            Console.Write("Kenar Sayısını Girin: ");
            int kenar = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine(new String('*', kenar));
                if (i == 0)
                {
                    for(int j = 0; j < kenar - 2; j++)
                    {
                        Console.Write("*");
                        Console.Write(new string(' ', kenar - 2));
                        Console.WriteLine("*");
                    }
                }
            }
            Console.ReadLine();
            */




            //Girilen kenar uzunluğuna göre İÇİ BOŞ KARE çizdirmek:
            Console.Write("Kenar uzunluğunu girin: ");
            int kenar = Convert.ToInt32(Console.ReadLine());

            //Tavan
            for(int i = 0; i < kenar; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();


            //Gövde
            for(int j = 0; j < kenar - 2; j++)
            {
                Console.Write("*");

                //Aradaki boşluklar:
                for(int k = 0; k < kenar - 2; k++)
                {
                    Console.Write("  "); //2 tane boşluk koyuyoruz çünkü biri yıldız için diğeri kendi boşluğu için
                }
                Console.Write(" *");
                Console.WriteLine();
            }


            //Zemin
            for(int n = 0; n < kenar; n++)
            {
                Console.Write("* ");
            }
            Console.ReadLine();
        }
    }
}
