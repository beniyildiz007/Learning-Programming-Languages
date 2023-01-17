using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Aritmetik_İslem_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ornek-1
            int sayi1, sayi2, toplam;

            Console.WriteLine("***Toplama İşlemi***");

            Console.WriteLine("Birinci Sayıyı Giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Birinci Sayıyı Giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam = " + toplam);

            Console.Read();
            */

            /* Ornek-2
            int s1, s2, toplam, fark, carpim, bolum;

            Console.WriteLine("***Aritmetik Dört İşlem***");
            Console.WriteLine();

            Console.WriteLine("1. Sayıyı Giriniz:");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz:");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            toplam = s1 + s2;
            Console.WriteLine("Toplam = " + toplam);
            fark = s1 - s2;
            Console.WriteLine("Fark = " + fark);
            carpim = s1 * s2;
            Console.WriteLine("Çarpım = " + carpim);
            bolum = s1 / s2;
            Console.WriteLine("Bölüm = " + bolum);

            Console.ReadLine();
            */


            //Kare ve Dikdörtgen Alan ve Çevre Hesaplaması
            int kenar, kareAlan, kareCevre;
            int kisaKenar, uzunKenar, dikAlan, dikCevre;

            Console.WriteLine("***Karenin Alan ve Çevresini Bulma***");
            Console.Write("Karenin Bir Kenarının Uzunluğunu Girin: ");
            kenar = Convert.ToInt32(Console.ReadLine());
            kareAlan = kenar * kenar;
            kareCevre = kenar * 4;

            Console.WriteLine("Kare Alanı = " + kareAlan);
            Console.WriteLine("Kare Çevresi = " + kareCevre);

            Console.WriteLine();
            Console.WriteLine("***Dikdörtgenin Alan ve Çevresini Bulma***");

            Console.Write("Kısa Kenarın Uzunluğunu Girin: ");
            kisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun Kenarın uzunluğunu Girin: ");
            uzunKenar = Convert.ToInt32(Console.ReadLine());

            dikAlan = kisaKenar * uzunKenar;
            dikCevre = (kisaKenar * 2) + (uzunKenar * 2);

            Console.WriteLine("Dikdörtgenin Alanı = " + dikAlan);
            Console.WriteLine("Dikdörtgenin Çevresi = " + dikCevre);

            Console.ReadLine();



        }
    }
}
