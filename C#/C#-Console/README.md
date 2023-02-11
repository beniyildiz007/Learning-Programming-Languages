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

# Double Değişkenler
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

# IF - ELSE Yapısı 1
```c#
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

```

# IF - ELSE Yapısı 2
```c#
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

```

# IF - ELSE Yapısı 3
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_If_Else_Yapisi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string mevsim;
            Console.Write("Lütfen bir mevsim giriniz: ");
            mevsim = Console.ReadLine();

            if (mevsim == "kış")
            {
                Console.Write("Kış mevsimi ayları: Aralık - Ocak - Şubat");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.Write("İlkbahar mevsimi ayları: Mart - Nisan - Mayıs");
            }
            else if (mevsim == "yaz")
            {
                Console.Write("Yaz mevsimi ayları: Haziran - Temmuz - Ağustos");
            }
            else if (mevsim == "sonbahar")
            {
                Console.Write("Sonbahar mevsimi ayları: Eylül - Ekim - Kasım");
            }

            Console.ReadLine();
            */


            Console.WriteLine("*** Ali Amcanın Kitapçı Dükkanı ***");

            double x, indirim, odenecek;
            Console.Write("Alışveriş Tutarını Girin: ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x < 100)
            {
                indirim = x * 10 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Uygulanacak İndirim= " + indirim);
                Console.Write("Toplam Miktar= " + odenecek);
            }
            if (x >= 100 && x < 150)
            {
                indirim = x * 15 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Uygulanacak İndirim= " + indirim);
                Console.Write("Toplam Miktar= " + odenecek);
            }
            if (x >= 150 && x < 200)
            {
                indirim = x * 20 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Uygulanacak İndirim= " + indirim);
                Console.Write("Toplam Miktar= " + odenecek);
            }
            if (x >= 200)
            {
                indirim = x * 30 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Uygulanacak İndirim= " + indirim);
                Console.Write("Toplam Miktar= " + odenecek);
            }

            Console.Read();

        }
    }
}

```

# Switch - Case Yapısı
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Switch_Case_Yapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int sayi;
            Console.WriteLine("1 ile 7 arasında bir sayı giriniz:");
            sayi = Convert.ToInt16(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Gün = Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Gün = Salı");
                    break;
                case 3:
                    Console.WriteLine("Gün = Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Gün = Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Gün = Cuma");
                    break;
                case 6:
                    Console.WriteLine("Gün = Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Gün = Pazar");
                    break;
                default:
                    Console.WriteLine("Hatalı Gün Girişi!");
                    break;
            }

            Console.ReadLine();
            */


            string mevsim;
            Console.WriteLine("Lütfen mevsimi küçük harflerle giriniz: ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "yaz":
                    Console.WriteLine("Yaz mevsimi ayları = Haziran - Temmuz - Ağustos");
                    break;
                case "sonbahar":
                    Console.WriteLine("Sonbahar mevsimi ayları = Eylül - Ekim - Kasım");
                    break;
                case "kış":
                    Console.WriteLine("Kış mevsimi ayları = Aralık - Ocak - Şubat");
                    break;
                case "ilkbahar":
                    Console.WriteLine("İlkbahar mevsimi ayları = Mart - Nisan - Mayıs");
                    break;
                default:
                    Console.WriteLine("Hatalı Mevsim Girişi!");
                    break;
            }
            Console.ReadLine();
        }
    }
}

```

# Döngüler 1
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Donguler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hello World");
            }
            Console.ReadLine();
            */


            /*
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */



            /*
            int i;
            for (i = 1; i <= 10; i+=3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            //Output = 1 4 7 10
            */


            /*
            int i;
            int toplam = 0;

            for (i = 1; i <= 10; i++)
            {
                toplam += i;
            }
            Console.WriteLine("Toplam = " + toplam);
            Console.ReadLine();
            //Output = 55
            */


            int i;
            int toplam = 0;

            for (i = 1; i <= 10; i+=2)
            {
                toplam += i;
            }
            Console.WriteLine("Toplam = " + toplam);
            Console.ReadLine();
            //Output = 25



        }
    }
}

```

# Döngüler 2
```c#
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

```

# While Döngüsü
```c#
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

```

# Diziler -1
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Diziler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] sayilar = { 10, 45, 21, 33, 54, 66, 77, 99 };
            Console.WriteLine(sayilar[3]);
            Console.Read();
            //Output = 33
            */


            /*
            string[] isimler = { "ali", "ahmet", "emel", "ayşe", "mehmet", "baran" };
            Console.WriteLine(isimler[0]);
            Console.Read();
            //Output = ali
            */


            
            //Yazılan şehir isimlerini diziye aktarma
            string[] sehirler = new string[3];
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Şehir: ");
                sehirler[i] = Console.ReadLine();
            }
            Console.WriteLine("*** Şehirler Listesi ***");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.Read();
            
        }
    }
}

```

# Diziler -2
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Diziler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] sayilar = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.Write((i + 1).ToString() + ". sayıyı girin: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int enbuyuk;
            enbuyuk = sayilar[0];

            for(int i = 1; i < 5; i++)
            {
                if (enbuyuk < sayilar[i])
                {
                    enbuyuk = sayilar[i];
                }
            }

            Console.WriteLine(enbuyuk);

            Console.Read();
            */



            string[] isim = new string[3];
            int[] s1 = new int[3];
            int[] s2 = new int[3];
            int[] ort = new int[3];

            for(int i = 0; i < 3; i++)
            {
                Console.Clear();

                Console.Write((i + 1) + ". Öğrencinin Adı: ");
                isim[i] = Console.ReadLine();

                Console.Write("Sınav 1: ");
                s1[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sınav 2: ");
                s2[i] = Convert.ToInt32(Console.ReadLine());

                ort[i] = (s1[i] + s2[i]) / 2;
            }

            Console.Write("Öğrenci Sınav1 Sınav2 Ortalama");
            Console.WriteLine();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(isim[i] + " " + s1[i] + " " + s2[i] + " " + ort[i]);
            }
            Console.ReadLine();
        }
    }
}

```

# Diziler -3 (For each Döngüsü)
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Diziler_3_Foreach_Dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] sehirler = { "Mersin", "İzmir", "Kocaeli", "Artvin", "Ankara", "Erzurum", "Şanlıurfa" };

            foreach(string i in sehirler)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */


            /*
            int[] sayilar = { 1, 4, 8, 9, 10 };
            int toplam = 0;
            foreach(int i in sayilar)
            {
                toplam += i;
            }
            Console.Write("Toplam= " + toplam);
            Console.ReadLine();
            //Output = 32
            */


            /*
            int[] rakamlar = { 1, 7, 5, 4, 8, 6, 9, 3 };
            foreach(int sayi in rakamlar)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }
            Console.ReadLine();
            */



            int[] degerler = { 1, 2, 3, 4, 5, 6 };
            int sonuc = 1;
            foreach(int i in degerler)
            {
                sonuc *= i;
            }
            Console.WriteLine("6 Sayısının faktöriyeli: " + sonuc);
            Console.ReadLine();
        }
    }
}

```

# Diziler -4
```c#
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

```

# Random Komutu
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Random_Komutu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random rastgele = new Random();
            int a, b;
            a = rastgele.Next(0, 10);
            b = rastgele.Next(0, 10);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.Read();
            */


            Random rastgele = new Random();
            Console.WriteLine("*** Şehir Atma Programı ***");
            string[] sehirler = { "Adana", "Eskişehir", "Antalya", "İzmir", "Ankara", "İstanbul", "Gaziantep" };
            int i;
            i = rastgele.Next(0, sehirler.Length);
            Console.WriteLine(i);
            Console.WriteLine(sehirler[i]);
            Console.ReadLine();

        }
    }
}

```

# Char Değişkeni
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Char_Degiskeni
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char harf;
            harf = 'n'; //Char türü yalnızca 1 harf tutar ve tek tırnaklar arasında gösterilir
            Console.WriteLine(harf);
            Console.ReadLine();
            */


            /*
            char cinsiyet;
            Console.Write("Cinsiyetinizi Girin: ");
            cinsiyet = Convert.ToChar(Console.ReadLine());
            if (cinsiyet == 'e' || cinsiyet=='E')
            {
                Console.WriteLine("Cinsiyetiniz Erkektir");
            }
            else
            {
                Console.WriteLine("Cinsiyetiniz Kadındır");
            }
            Console.ReadLine();
            */


            char ders;
            Console.WriteLine("**** YGS Dersleri Menüsü ****\n");
            Console.WriteLine("Türkçe");
            Console.WriteLine("Matematik");
            Console.WriteLine("Sosyal Bilgisi");
            Console.WriteLine("Fen Bilgisi\n");
            Console.Write("Hangi dersin bilgilerini görmek istersiniz?: ");

            ders = Convert.ToChar(Console.ReadLine());
            if(ders=='t' || ders == 'T')
            {
                Console.Write("Türkçe dersi paragraf ağırlıklı olup dil bilgisi soruları da içerir.");
            }
            else if (ders == 'm' || ders == 'M')
            {
                Console.Write("Matematik dersi temel mat1 konuları ve 8-9 tane geometri sorusu içerir.");
            }
            else if (ders == 's' || ders == 'S')
            {
                Console.Write("Sosyal Bilgiler dersi tarih ve coğrafya konularını içerir.");
            }
            else
            {
                Console.Write("Fen Bilgisi fizik, kimya ve biyoloji konularını içerir.");
            }
            Console.ReadLine();
        }
    }
}

```

# Float Değişkeni
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Float_Degiskeni
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            float sayi;
            sayi = 123;
            Console.WriteLine("Sayı: " + sayi);
            Console.ReadLine();
            */


            /*
            float s1, s2, toplam;
            s1 = 25;
            s2 = 45;
            toplam = s1 + s2;
            Console.WriteLine("Toplam: " + toplam);
            Console.ReadLine();
            */


            /*
            float deger;
            deger = 1234567; //Float hassasiyet değeri 7 basamaklı sayılar kadardır
            Console.WriteLine(deger);
            Console.Read();
            //Output = 1234567
            */


            /*
            float sayi;
            sayi = 2.123456f;
            Console.WriteLine(sayi);
            Console.Read();
            */



            int x = 3;
            float y = 2.5f;
            int z = 4;
            float toplam;
            toplam = x + y + z;
            Console.WriteLine("Toplam: " + toplam);
            Console.Read();
            //Output = 9,5

        }
    }
}

```

# Decimal Değişkeni
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Decimal_Degiskeni
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            decimal sayi;
            sayi = 12.453m;
            Console.WriteLine(sayi);
            Console.Read();
            */


            /*
            decimal s1;
            int s2;
            s1 = 2.45M;
            s2 = 4;
            decimal toplam;
            toplam = s1 + s2;
            Console.WriteLine("Toplam: " + toplam);
            Console.Read();
            //Output = 6,45
            */


            /*
            decimal x = 0.996m;
            decimal y = 999999;
            Console.WriteLine("Para 1 {0:C}", x); //O:C sayıyı yuvarlar
            Console.WriteLine("Para 2 {0:C}", y);
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.Read();
            */




            decimal urun1, urun2, toplam;
            int s1, s2;
            urun1 = 14.85M;
            urun2 = 21.48m;
            Console.Write("1. Ürünün Satış Miktarı: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Ürünün Satış Miktarı: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = s1 * urun1 + s2 * urun2;
            Console.WriteLine("Gün sonunda kasada olması gereken tutar: " + toplam + " TL'dir");
            Console.ReadLine();

        }
    }
}

```

# Byte - Sbyte - Short - Ushort Değişkenleri
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Byte_Sbyte_Short_Ushort_Degiskenleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte sayi;
            sayi = 255; //Byte veri türü 0 / 255 arasında sayı alır
            Console.WriteLine(sayi);
            Console.ReadLine();
            //Output = 255
            */


            /*
            byte s1, s2;
            s1 = 20;
            s2 = 240;
            Console.WriteLine(s1 + s2);
            Console.ReadLine();
            //Output = 260;
            */



            /*
            Console.WriteLine("*** Doğu Anadolu Bölgesi Hava Durumu ***");
            Console.WriteLine("01 Ocak 2023 Hava Tahminleri");
            sbyte erzurum, malatya, elazig; //sbyte değişken türü -128 / +127 arasında değer alır
            erzurum = -35;
            malatya = 3;
            elazig = -7;

            Console.WriteLine("Erzurum Karlı: " + erzurum+" derecedir");
            Console.WriteLine("Malatya Çok Bulutlu: " + malatya+" derecedir");
            Console.WriteLine("Elazığ Karla Karışık Yağmurlu: " + elazig+" derecedir");
            Console.ReadLine();
            */



            /*
            short s1, s2, s3; //short değişkeni -32768 | +32767 arasında değer alır
            s1 = 32767;
            s2 = -32768;
            s3 = 40;
            Console.WriteLine(s1 + s2 + s3);
            Console.ReadLine();
            //Output = 39
            */



            ushort s1, s2; //ushort değişkeni 0 / +65535 arasında değer alır
            s1 = 0;
            s2 = 65535;
            Console.WriteLine(s1 + s2);
            Console.ReadLine();


        }
    }
}

```

# Bool Değişkeni
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Bool_Degiskeni
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int sayi;
            Console.Write("Sayıyı girin:");
            sayi = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sayi > 0;
            bool durum2 = sayi > 10;
            Console.WriteLine("Sayı Pozitif mi {0}", durum1);
            Console.WriteLine("Sayı 10'dan büyük mü {0}", durum2);
            Console.ReadLine();
            */



            Console.Write("Şifreyi Girin: ");
            int sifre;
            sifre = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sifre == 1234;
            Console.WriteLine("Şifre Doğrumu {0}", durum1);
            Console.ReadLine();

        }
    }
}

```
