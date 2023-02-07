using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_If_Else_Yapisi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1-
            string isim;
            isim = "Mehmet";

            if (isim == "Mehmet")
            {
                Console.Write("Doğru isim girişi");
            }
            else
            {
                Console.Write("Hatalı İsim");
            }
            Console.ReadLine();
            */

            /* 2-
            string isim;
            Console.Write("İsminizi Girin: ");
            isim = Console.ReadLine();

            if (isim == "Berkan")
            {
                Console.Write("Doğru isim girişi!");
            }
            else
            {
                Console.Write("Hatalı isim girişi yaptınız!!");
            }
            Console.ReadLine();
            */

            /* 3-
            string sehir;
            Console.WriteLine("Türkiye'nin Başkenti Neresidir?: ");
            sehir = Console.ReadLine();

            if (sehir == "Ankara")
            {
                Console.WriteLine("Tebrikler doğru bildiniz!!");
            }
            else
            {
                Console.WriteLine("Yanlış Cevap!!");
            }
            Console.Read();
            */

            /* 4-
            int sayi;
            Console.WriteLine("Lütfen sayıyı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                Console.WriteLine("Pozitif Tam Sayı Girdiniz!");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Negatif Tam Sayı Girdiniz");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı sıfırdır.");
            }
            Console.ReadLine();
            */


            int s1, s2, ort;

            Console.Write("1. Sınavınız: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sınavınız: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            ort = (s1 + s2) / 2;

            if (ort >= 50)
            {
                Console.WriteLine("Öğrenci dersi geçti.");
            }
            else
            {
                Console.WriteLine("Öğrenci dersten kaldı!");
            }
            Console.Read();
        }
    }
}
