using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_Matematik_Menusu_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {

            int islem;
            Console.WriteLine("Aritmetik işlemler menüsüne hoşgeldiniz!\n");
            Console.WriteLine("******** Menü *********");
            Console.WriteLine("1- Aritmetik Dört İşlem");
            Console.WriteLine("2- Üs Alma");
            Console.WriteLine("3- Kök Alma");
            Console.WriteLine("4- Karenin Çevre ve Alan Hesabı");
            Console.WriteLine("5- Dikdörtgende Alan ve Çevre Hesabı");
            Console.WriteLine("6- Eşkenar Üçgende Çevre Hesabı\n");

            Console.WriteLine("********************\n");

            Console.Write("İşlem yapmak istediğiniz alan: ");
            islem = Convert.ToInt16(Console.ReadLine());

            if (islem == 1)
            {
                int a, b, toplam, fark, carpim, bolum;
                Console.Write("1. Sayıyı Giriniz: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayıyı Giriniz: ");
                b = Convert.ToInt32(Console.ReadLine());

                toplam = a + b;
                fark = a - b;
                carpim = a * b;
                bolum = a / b;

                Console.WriteLine("Toplam: " + toplam);
                Console.WriteLine("Fark: " + fark);
                Console.WriteLine("Çarpım: " + carpim);
                Console.WriteLine("Bölüm: " + bolum);
            }
            else if (islem == 2)
            {
                double sayi, us, sonuc;
                Console.Write("Üssünü almak istediğiniz sayıyı giriniz: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                Console.Write("Üssü giriniz: ");
                us = Convert.ToDouble(Console.ReadLine());
                sonuc = Math.Pow(sayi, us);
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if (islem == 3)
            {
                double sayi, kok;
                Console.Write("Kökü alınacak sayıyı girin: ");
                sayi = Convert.ToDouble(Console.ReadLine());
                kok = Math.Sqrt(sayi);
                Console.WriteLine("Sonuç: " + kok);
            }
            else if (islem == 4)
            {
                int kenar, alan, cevre;
                Console.Write("Kenar değeri: ");
                kenar = Convert.ToInt32(Console.ReadLine());
                alan = kenar * kenar;
                cevre = kenar * 4;
                Console.WriteLine("Alanı: " + alan);
                Console.WriteLine("Çevresi: " + cevre);
            }
            else if (islem == 5)
            {
                int kisakenar, uzunkenar, cevredik, alandik;
                Console.Write("Kısa Kenarı Girin: ");
                kisakenar = Convert.ToInt32(Console.ReadLine());
                Console.Write("Uzun Kenarı Girin: ");
                uzunkenar = Convert.ToInt32(Console.ReadLine());
                cevredik = kisakenar + kisakenar + uzunkenar + uzunkenar;
                alandik = kisakenar * uzunkenar;
                Console.WriteLine("Alan: " + alandik);
                Console.WriteLine("Çevre: " + cevredik);
            }
            else if (islem == 6)
            {
                int kenar, cevre;
                Console.Write("Kenar Değeri: ");
                kenar = Convert.ToInt32(Console.ReadLine());
                cevre = kenar * 3;
                Console.WriteLine("Çevre: " + cevre);
            }
            Console.ReadLine();
        }
    }
}
