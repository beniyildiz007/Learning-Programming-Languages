using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_If_Else_Yapisi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1-
            int s1, s2, proje, ort;
            Console.Write("1. Sınavı Giriniz: ");
            s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sınavı Giriniz: ");
            s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Proje Notunuzu Giriniz: ");
            proje = Convert.ToInt32(Console.ReadLine());

            ort = (s1 + s2 + proje) / 3;
            Console.WriteLine("Ortalama: " + ort);

            if (ort > 0 && ort < 30)
            {
                Console.WriteLine("Durum: Çok Kötü");
            }
            else if (ort >= 30 && ort < 50)
            {
                Console.WriteLine("Durum: İyi Değil");
            }
            else if(ort>=50 && ort < 75)
            {
                Console.WriteLine("Durum: İyi");
            }
            else if(ort>=75 && ort < 90)
            {
                Console.WriteLine("Durum: Çok iyi");
            }
            else if(ort>=90 && ort <= 100)
            {
                Console.WriteLine("Durum: Mükemmel");
            }
            else
            {
                Console.WriteLine("Not Hesaplamada Hata Oluştu!");
            }

            Console.ReadLine();
            */


            int sayi;
            Console.WriteLine("Sayıyı Girin: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 5 == 0)
            {
                Console.WriteLine("Sayi 5'e Tam Bölünür!");
            }
            else
            {
                Console.WriteLine("Sayı 5'e tam bölünemez!!");
            }
            Console.ReadLine();
        }
    }
}
