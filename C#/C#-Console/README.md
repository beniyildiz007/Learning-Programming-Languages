# Merhaba Dünya
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merhaba_Dunya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba Dünya"); /*Ekrana yazı yazdırdık*/
            Console.Read(); /*Ekranın açık kalmasını sağladık*/

            Console.WriteLine("C# Console Dersleri"); /*Cursor'ün aşağıda bitmesini sağladık*/
            Console.Read();
        }
    }
}

```

# String Örnekleri
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_String_Ornekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //string isim;
            //isim = "Berkan";
            //Console.Write(isim);
            //Console.Read();


            //string isim;
            //Console.Write("İsminizi Giriniz: ");
            //isim = Console.ReadLine();
            //Console.Write("Hoşgeldiniz " + isim);
            //Console.Read();


            //string ad, soyad, yas, meslek, sehir;
            //Console.WriteLine("Lütfen sırasıyla Ad, Soyad, Yaş, Meslek ve Şehir bilgilerinizi giriniz...");

            //ad = Console.ReadLine();
            //soyad = Console.ReadLine();
            //yas = Console.ReadLine();
            //meslek = Console.ReadLine();
            //sehir = Console.ReadLine();

            //Console.WriteLine(" ");

            //Console.WriteLine("Ad: " + ad);
            //Console.WriteLine("Soyad: " + soyad);
            //Console.WriteLine("Yaş: " + yas);
            //Console.WriteLine("Meslek: " + meslek);
            //Console.WriteLine("Şehir: " + sehir);

            //Console.Read();


            string ad, soyad, sehir;
            Console.WriteLine("Ad: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyad: ");
            soyad = Console.ReadLine();
            Console.WriteLine("Şehir: ");
            sehir = Console.ReadLine();

            Console.WriteLine("Ad:{0}  Soyad:{1}  Şehir:{2}", ad, soyad, sehir);
            Console.Read();
            //Bir üstteki örneğe göre daha kısa ve daha az satır ile sonucumuzu çıkarmış olduk.
        }
    }
}

```

# Int Değişkenleri
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Int_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1, sayi2, toplam;
            //sayi1 = 5;
            //sayi2 = 7;
            //toplam = sayi1 + sayi2;
            //Console.Write(toplam);
            //Console.Read();


            //int deger1, deger2, bolum;
            //deger1 = 12;
            //deger2 = 22;
            //bolum = (deger1 + deger2) / 2;
            //Console.Write(bolum);
            //Console.Read();


            string isim, soyisim, numara;
            int s1, s2, s3, proje, ortalama;
            Console.WriteLine("***Öğrenci Bilgileri***");
            Console.WriteLine();
            isim = "Berkan Nihat";
            soyisim = "Yıldız";
            numara = "100222981";
            Console.WriteLine("İsim = " + isim);
            Console.WriteLine("Soyisim = " + soyisim);
            Console.WriteLine("Numara = " + numara);
            Console.WriteLine();
            Console.WriteLine("***Not Bilgileri***");
            Console.WriteLine();
            s1 = 60;
            s2 = 70;
            s3 = 100;
            proje = 90;
            Console.WriteLine("1. Sınav = " + s1);
            Console.WriteLine("2. Sınav = " + s2);
            Console.WriteLine("3. Sınav = " + s3);
            Console.WriteLine("Proje Notu = " + proje);
            Console.WriteLine();
            Console.WriteLine("***Ortalama Bilgileri***");
            Console.WriteLine();
            ortalama = (s1 + s2 + s3 + proje) / 4;
            Console.WriteLine("Ortalama Notu = " + ortalama);
            Console.ReadLine();
        }
    }
}

```

# Aritmetik İşlem Uygulaması
```c#
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

```

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Double_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci Not Hesaplama");

            double s1, s2, s3, proje, ort;
            string ad, soyad, numara;

            Console.WriteLine();
            Console.WriteLine("*** Öğrenci Kimlik Bilgileri ***");
            Console.WriteLine();

            Console.Write("Adınız: ");
            ad = Console.ReadLine();

            Console.Write("Soyadınız: ");
            soyad = Console.ReadLine();

            Console.Write("Numaranız: ");
            numara = Console.ReadLine();

            Console.WriteLine("*** Öğrenci Sınav Bilgileri ***");
            Console.WriteLine();

            Console.Write("Birinci Sınav: ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Sınav: ");
            s2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçüncü Sınav: ");
            s3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Prone Notunuz: ");
            proje = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("*** Ortalama Değeri ***");
            Console.WriteLine();

            ort = (s1 + s2 + s3 + proje) / 4;
            Console.WriteLine("Ad Soyad = " + ad +" "+ soyad);
            Console.Write("Ortalama = " + ort);

            Console.ReadLine();



        }
    }
}

```
