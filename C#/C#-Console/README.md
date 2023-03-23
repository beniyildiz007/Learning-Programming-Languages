>_Büyük fikirler büyük başarılar getirmez, küçük başarılar büyük başarıları inşa eder._



## İçindekiler (Contents)
1. [Merhaba Dünya](#p1)
2. [String Örnekleri](#p2)
3. [Integer (int) Değişkenler](#p3)
4. [Aritmetik İşlem Uygulaması](#p4)
5. [Double Değişkenler](#p5)
6. [if-else Yapısı 1](#p6)
7. [if-else Yapısı 2](#p7)
8. [if-else Yapısı 3](#p8)
9. [Switch-Case Yapısı](#p9)
10. [For Döngüsü 1](#p10)
11. [For Döngüsü 2](#p11)
12. [While Döngüsü](#p12)
13. [Diziler 1](#p13)
14. [Diziler 2](#p14)
15. [Diziler 3](#p15)
16. [Diziler 4](#p16)
17. [Random Komutu](#p17)
18. [Char Değişkeni](#p18)
19. [Float Değişkeni](#p19)
20. [Decimal Değişkeni](#20)
21. [Byte - Sbyte - Short - Ushort Değişkenleri](#p21)
22. [Bool Değişkeni](#p22)
23. [Arka Plan Rengi Değiştirme](#p23)
24. [Çok Boyutlu Diziler 1](#p24)
25. [Çok Boyutlu Diziler 2](#p25)
26. [Çok Boyutlu Diziler 3](#p26)
27. [Matematiksel Fonksiyonlar](#p27)
28. [Zaman Fonksiyonları](#p28)
29. [Yıldızlarla Şekil Çizme 1](#p29)
30. [Yıldızlarla Şekil Çizme 2](#p30)
31. [Yıldızlarla Şekil Çizme 2](#p31)
32. [Metotlar -1](#p32)
33. [Metotlar -2](#p33)
34. [Metotlar -3](#p34)
35. [Sınıf Yapısı](#p35)
36. [Sınıflarda Get-Set Kavramları](#p36)
37. [Sınıflarda Kapsülleme](#p37)
38. [Sınıflarda Kalıtım](#p38)
39. [Sınıflarda Çok Biçimlilik](#p39)
40. [Ref Out](#p40)
41. [Bilgi Yarışması Oyunu](#p41)
42. [Matematik Menüsü Uygulaması](#p42)
43. [Sayı Tahmin Oyunu](#p43)
44. [Müzik Çalar Uygulaması](#p44)
45. [Futbol Lig Uygulaması](#p45)
46. [Yemek Sipariş Uygulaması](#p46)
47. [Metin Belgesi Kayıt Uygulaması](#p47)
48. [Boxing - Unboxing](#p48)



# Merhaba Dünya <a name="p1"></a>
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

# String Örnekleri <a name="p2"></a>
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

# Int Değişkenleri <a name="p3"></a>
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

# Aritmetik İşlem Uygulaması <a name="p4"></a>
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

# Double Değişkenler <a name="p5"></a>
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

# IF - ELSE Yapısı 1 <a name="p6"></a>
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

# IF - ELSE Yapısı 2 <a name="p7"></a>
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

# IF - ELSE Yapısı 3 <a name="p8"></a>
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

# Switch - Case Yapısı <a name="p9"></a>
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

# Döngüler 1 <a name="p10"></a>
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

# Döngüler 2 <a name="p11"></a>
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

# While Döngüsü <a name="p12"></a>
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

# Diziler -1 <a name="p13"></a>
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

# Diziler -2 <a name="p14"></a>
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

# Diziler -3 (For each Döngüsü) <a name="p15"></a>
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

# Diziler -4 <a name="p16"></a>
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

# Random Komutu <a name="p17"></a>
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

# Char Değişkeni <a name="p18"></a>
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

# Float Değişkeni <a name="p19"></a>
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

# Decimal Değişkeni <a name="p20"></a>
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

# Byte - Sbyte - Short - Ushort Değişkenleri <a name="p21"></a>
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

# Bool Değişkeni <a name="p22"></a>
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

# Arka Plan Rengini Değiştirme <a name="p23"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Arka_Plan_Rengi_Degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.BackgroundColor = ConsoleColor.Blue; //Arkaplan rengimizi Mavi yaptık
            Console.ForegroundColor = ConsoleColor.Black; //Yazımızın rengini siyah yaptık
            Console.Title = "Çanakkale Zaferi"; //Console penceremizin başlığını değiştirdik
            Console.Clear();
            Console.WriteLine("18 Mart Çanakkale Şehitlerini Anma Günü");
            Console.ReadLine();
            */




            Console.Write("Lütfen bir sayı girin: ");
            ConsoleColor renk = (ConsoleColor)Convert.ToInt32(Console.ReadLine());
            Console.BackgroundColor = renk;            
            Console.Clear();
            Console.ReadLine();
            //0-15 arasında bir sayı girilmeli çünkü 16 tane renk paleti tanımlanmış durumda


        }
    }
}
```

# Çok Boyutlu Diziler 1 <a name="p24"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Cok_Boyutlu_Dizi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[,] dizi = new int[2, 2];
            dizi[0, 0] = 25;
            dizi[0, 1] = 35;
            dizi[1, 0] = 17;
            dizi[1, 1] = 16;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" {0} ", dizi[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();
            */



            int[,] dizi = new int[2, 3];
            dizi[0, 0] = 10;
            dizi[0, 1] = 20;
            dizi[0, 2] = 30;
            dizi[1, 0] = 40;
            dizi[1, 1] = 50;
            dizi[1, 2] = 60;

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", dizi[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
```

# Çok Boyutlu Diziler 2 <a name="p25"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Cok_Boyutlu_Diziler_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*** Matrislerde Toplama İşlemi ***");

            int[,] matris1 = { { 10, 12, 14, 18 }, { 20, 14, 16, 13 }, { 25, 14, 41, 21 }, { 32, 36, 41, 57 } };
            int[,] matris2 = { { 40, 30, 20, 10 }, { 7, 9, 8, 6 }, { 21, 22, 23, 24 }, { 56, 54, 51, 44 } };

            int[,] toplam = new int[4, 4];

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    toplam[i, j] = matris1[i, j] + matris2[i, j];
                }
            }

            for(int k = 0; k < 4; k++)
            {
                Console.WriteLine();
                for(int m = 0; m < 4; m++)
                {
                    Console.Write(toplam[k, m] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
```

# Çok Boyutlu Diziler 3 <a name="p26"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Cok_Boyutlu_Diziler_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int satir, sutun;

            Console.Write("Satır sayısını girin: ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısını girin: ");
            sutun = Convert.ToInt32(Console.ReadLine());

            int[,] matris = new int[satir, sutun];

            for(int i = 0; i < satir; i++)
            {
                for(int j = 0; j < sutun; j++)
                {
                    Console.Write("Matrisin {0} x {1} Değeri: ", i + 1, j + 1);
                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int k = 0; k < satir; k++)
            {
                for (int n = 0; n < sutun; n++)
                {
                    Console.Write(matris[k, n] + " ");
                }
                Console.WriteLine();
            }

            //Matrisi Transpoze Etmek:
            Console.WriteLine("\nMatrisi Transpoze Etmek:");
            for (int x = 0; x < satir; x++)
            {
                for (int y = 0; y < sutun; y++)
                {
                    Console.Write(matris[y, x] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            //Matrisi 5 Katsayısı ile Çarpmak:
            Console.WriteLine("Matrisin 5 ile çarpımı:");
            for (int s = 0; s < satir; s++)
            {
                for(int p = 0; p < sutun; p++)
                {
                    Console.Write(matris[s, p]*5 + " ");
                }
                Console.WriteLine();
            }

            //Matrisi kullanıcının girdiği bir katsayı ile çarpmak:
            Console.WriteLine();
            Console.Write("\nMatrisi kaç ile çarpmak istiyorsunuz?: ");
            int katsayi = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a < satir; a++)
            {
                for (int b = 0; b < sutun; b++)
                {
                    Console.Write(matris[a, b] * katsayi + " ");
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
```

# Matematiksel Fonksiyonlar <a name="p27"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Matematiksel_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int sayi;
            Console.Write("Sayıyı girin: ");
            sayi = Convert.ToInt16(Console.ReadLine());
            Console.Write("Mutlak Değerli Hali: " + Math.Abs(sayi));
            Console.ReadLine();
            */


            /*
            double sayi;
            Console.Write("Sayıyı Girin: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayının Üste Yuvarlanmış Hali: " + Math.Ceiling(sayi));
            Console.ReadLine();
            */



            /*
            double sayi;
            Console.Write("Sayıyı Girin: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayının Alta Yuvarlanmış Hali: " + Math.Floor(sayi));
            Console.ReadLine();
            */



            /*
            //Girilen sayının 5. kuvvetini almak
            double sayi;
            Console.Write("Sayıyı Girin: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sonuç: " + Math.Pow(sayi, 5));
            Console.ReadLine();
            */




            //Girilen sayının karekökünü bulmak
            double sayi;
            Console.Write("Sayıyı Girin: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sonuç: " + Math.Sqrt(sayi));
            Console.ReadLine();



        }
    }
}
```

# Zaman Fonksiyonları <a name="p28"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Zaman_Fonksiyonlari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Tarih ve saat gösteriminin en ham hali
            DateTime zaman;
            zaman = DateTime.Now;
            Console.Write("Tarih ve Saat: {0}", zaman);
            Console.Read();
            */



            /*
            DateTime zaman;
            zaman = DateTime.Now;
            int ay = zaman.Month;
            int gun = zaman.Day;
            int yil = zaman.Year;
            DayOfWeek haftaningunu = zaman.DayOfWeek;
            Console.WriteLine("Gün: {0}", gun);
            Console.WriteLine("Ay: {0}", ay);
            Console.WriteLine("Yıl: {0}", yil);
            Console.WriteLine("Haftanın Günü: {0}", haftaningunu);
            Console.Read();
            */




            DateTime zaman;
            zaman = DateTime.Now;

            Console.WriteLine("*** C# Dersleri Tarih ve Saat Fonksiyonları ***\n");
            Console.WriteLine("Kısa Tarih: {0:d}", zaman);
            Console.WriteLine("Uzun Tarih: {0:D}", zaman);
            Console.WriteLine("Tam Tarih: {0:f}", zaman);
            Console.WriteLine("Tam Tarih2: {0:F}", zaman);
            Console.WriteLine("Sayısal Tarih Formatı: {0:g}", zaman);
            Console.WriteLine("Sayısal Tarih Formatı2: {0:G}", zaman);
            Console.WriteLine("Ay: {0:m}", zaman);
            Console.WriteLine("Biçim: {0:r}", zaman);
            Console.WriteLine("Biçim2: {0:s}", zaman);
            Console.WriteLine("Saat: {0:t}", zaman);
            Console.WriteLine("Saat2: {0:T}", zaman);
            Console.WriteLine("Yıl: {0:Y}", zaman);

            Console.Read();


        }
    }
}
```

# Yıldızlarla Şekil Çizme 1 <a name="p29"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Yildizlarla_Sekil_Cizme_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //10x10 dik üçgen çizdirmek v1:
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(new String('*',i)); //new String parametresi içerisinde önce yazdırmak istediğimiz değeri sonra da adedini giriyoruz
            }
            Console.ReadLine();
            */



            /*
            //10x10 dik üçgen çizdirmek v2:
            for (int i = 1; i <= 10; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */




            //10x10 dik üçgen tersten çizdirmek:
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();



        }
    }
}
```

# Yıldızlarla Şekil Çizme 2 <a name="p30"></a>
```c#
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
```

# Yıldızlarla Şekil Çizme 3 <a name="p31"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Yildizlarla_Sekil_Cizme_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Büyüklüğü girilen baklava dilimin çizdirmek
            Console.Write("Baklava Dilimi Büyüklüğü: ");
            int dilim = Convert.ToInt32(Console.ReadLine());

            //Üst kısım
            for (int i = 1; i <= dilim; i++)
            {
                for (int j = dilim; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Alt kısım
            for (int i = 1; i <= dilim; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = dilim; k > i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
```

# Metotlar 1 <a name="p32"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Metotlar_1
{
    class Program
    {

        private static void veriler()
        {
            Console.WriteLine("Müdür: Berkan Nihat Yıldız");
            Console.WriteLine("Öğretmen: Ecmel Yıldız");
            Console.WriteLine("Okul: Atatürk Ortaokulu");
            Console.WriteLine("Eğitsel Kol: Kütüphanecilik");
            Console.WriteLine("Şehir: Antalya");
            Console.WriteLine(DateTime.Now.ToLongDateString());
        }
        static void Main(string[] args)
        {
            veriler();
            Console.Read();
        }
    }
}
```

# Metotlar 2 <a name="p33"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Metotlar_2
{
    class Program
    {

        private static void yazdir(string bilgi) //İÇerisine herhangi bir değişken almayan metotlar void ile tanımlanır
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bilgi);
            }
        }

        private static int Topla(int s1, int s2) //Toplama metodu
        {
            int t = s1 + s2;
            return t;
        }

        private static int Kup(int s1) //Küp alma metodu
        {
            int kup = s1 * s1 * s1;
            return kup;
        }

        static void Main(string[] args)
        {
            /*
            //Girilen metni 10 kere yazdır
            Console.Write("Metni Girin: ");
            string blg = Console.ReadLine();
            yazdir(blg);
            Console.Read();
            */



            /*
            //Kullanıcının girdiği 2 tane sayıyı topla
            Console.Write("Toplamak istediğiniz 1. sayıyı girin: ");
            int sy1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Toplamak istediğiniz 2. sayıyı girin: ");
            int sy2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam: " + Topla(sy1, sy2));
            Console.ReadLine();
            */




            //Kullanıcının girdiği bir sayının küpünü yazdıran program
            Console.Write("Kübünü almak istediğiniz sayıyı giriniz: ");
            int ks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayının kübü: " + Kup(ks));
            Console.Read();

        }
    }
}
```

# Metotlar 3 <a name="p34"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Metotlar_3
{
    class Metotlar //Başlangıçta Program olan gelen class adını değiştirdik
    {

        int topla(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Metotlar mtr = new Metotlar(); //Önce mtr adında Metotlar sınıfından bir nesne türettik
            int toplam = mtr.topla(1, 3); //Daha sonra ise bu nesneyi kullanarak topla() metodunu kullandık
            Console.WriteLine("Toplam: " + toplam);
            Console.ReadLine();
            //Output = Toplam: 4
            
        }
    }
}
```

# Sınıf Yapısı <a name="p35"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Sinif_Yapisi
{
    class Program
    {
        private static int topla(int s1, int s2)
        {
            return s1 + s2;
        }

        static void Main(string[] args)
        {

            //Private örneği:
            Console.WriteLine(_35_Sinif_Yapisi.Program.topla(3, 4));



            //Sınıflar:
            Araba arabasinif = new Araba(); //arabasinif adında Araba() sınıfından bir nesne türettik

            arabasinif.renk = "Siyah";
            arabasinif.fiyat = 150000;
            arabasinif.model = "2016";
            arabasinif.vites = "Otomatik";
            arabasinif.plaka = "34-İstanbul";

            Console.WriteLine("Araba Rengi: " + arabasinif.renk);
            Console.WriteLine("Araba Fiyatı: " + arabasinif.fiyat);
            Console.WriteLine("Araba Model Yılı: " + arabasinif.model);
            Console.WriteLine("Araba Vites Türü: " + arabasinif.vites);
            Console.WriteLine("Araba Plakası: " + arabasinif.plaka);
            Console.WriteLine();



            arabasinif.renk = "Beyaz";
            arabasinif.fiyat = 140000;
            arabasinif.model = "2023";
            arabasinif.vites = "Otomatik";
            arabasinif.plaka = "07-Antalya";

            Console.WriteLine("Araba Rengi: " + arabasinif.renk);
            Console.WriteLine("Araba Fiyatı: " + arabasinif.fiyat);
            Console.WriteLine("Araba Model Yılı: " + arabasinif.model);
            Console.WriteLine("Araba Vites Türü: " + arabasinif.vites);
            Console.WriteLine("Araba Plakası: " + arabasinif.plaka);

            Console.ReadLine();
        }
    }
}
```

# Sınıflarda Get-Set Kavramları <a name="p36"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Siniflar_Get_Set_Kavrami
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogr = new Ogrenci();
            ogr.ADI = "Berkan Nihat";
            ogr.SOYADI = "Yıldız";
            ogr.ALANI = "Mateamtik-Fen";
            ogr.YASI = 15; //Yaş otomatik olarak 18 gelecektir

            Console.WriteLine("Adı: " + ogr.ADI);
            Console.WriteLine("Soyadı: " + ogr.SOYADI);
            Console.WriteLine("Alanı: " + ogr.ALANI);
            Console.WriteLine("Yaşı: " + ogr.YASI);

            Console.ReadLine();
        }
    }
}
```

# Sınıflarda Kapsülleme <a name="p37"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Siniflar_Kapsulleme
{
    class Program
    {
        static void Main(string[] args)
        {

            Emlak eml = new Emlak();

            eml.SEMT = "Pendik"; //Büyük harflerle gelecek
            eml.RENK = "Mavi"; //Küçük harflerle gelecek
            eml.ODASAYISI = -4; //Math.Abs() metodu sayesinde 4 olacak
            eml.KATNUMARA = 8;
            eml.ALAN = -90; //Math.Abs() metodu sayesinde 90 olacak

            Console.WriteLine("Evin bulunduğu semt: " + eml.SEMT);
            Console.WriteLine("Evin oda renkleri: " + eml.RENK);
            Console.WriteLine("Evin toplam oda sayısı: " + eml.ODASAYISI);
            Console.WriteLine("Evin bulunduğu kat: " + eml.KATNUMARA);
            Console.WriteLine("Evin toplam alanı: " + eml.ALAN+" Metrekare");

            Console.ReadLine();
        }
    }
}
```

# Sınıflarda Kalıtım <a name="p38"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Siniflar_Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {

            Ucak uck = new Ucak();

            uck.MARKA = "Türk Hava Yolları";
            uck.KALKIS = "adana-Şakirpaşa";
            uck.VARIS = "İstanbul-sabiha gökçen";
            uck.ADI = "Berkan Nihat";
            uck.SOYADI = "Yıldız";
            uck.YASI = 27;
            uck.CINSIYET = "Erkek";


            Console.WriteLine("Hava Yolu: " + uck.MARKA);
            Console.WriteLine("Kalkış Noktası: " + uck.KALKIS);
            Console.WriteLine("Varış Noktası: " + uck.VARIS);
            Console.WriteLine("Yolcu Ad: " + uck.ADI);
            Console.WriteLine("Yolcu Soyad: " + uck.SOYADI);
            Console.WriteLine("Yolcu Yaşı: " + uck.YASI);
            Console.WriteLine("Cinsiyet: " + uck.CINSIYET);


            Console.ReadLine();
        }
    }
}
```

# Sınıflarda Çok Biçimlilik <a name="p39"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Siniflar_Cok_Bicimlilik
{

    class insan
    {
        public virtual void selamver()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "Selamlaşma Uygulaması";
            Console.WriteLine("Merhaba Şubat 2023'ten Selamlar");
        }
    }

    class Türk : insan
    {
        public override void selamver()
        {
            Console.WriteLine("Esenlikler");
        }
    }

    class Fransız : insan
    {
        public override void selamver()
        {
            Console.WriteLine("Bonjour");
        }
    }

    class İngiliz : insan
    {
        public override void selamver()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            insan ins = new insan();
            ins.selamver();
            Console.Read();
            */



            /*
            Türk trk = new Türk();
            trk.selamver();
            Console.Read();
            */


            /*
            Fransız fr = new Fransız();
            fr.selamver();
            Console.Read();
            */



            İngiliz ing = new İngiliz();
            ing.selamver();
            Console.Read();







        }
    }
}
```

# Ref-Out <a name="p40"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Ref_Out
{
    class Program
    {

        static void arttir(ref int s)
        {
            s++;
        }

        static void azalt(out int n)
        {
            n = 12;
            n--;
        }

        static void Main(string[] args)
        {

            int a = 9;
            arttir(ref a); //ref kullanmazsak a=10 olmayacak, a=9 olarak kalacaktı.
            Console.WriteLine(a);

            int x; //Değişkenin değerini metodun içerisinde tanımlamıştık
            azalt(out x);
            Console.WriteLine(x);
            Console.Read();
        }
    }
}
```

# Bilgi Yarışması Oyunu <a name="p41"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Bilgi_Yarismasi_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************************");
            Console.WriteLine("Yarışmaya Hoşgeldiniz!");
            Console.WriteLine("************************");
            Console.Title = "Bilgi Yarışması";
            string ad, soyad;
            Console.Write("Adınız: ");
            ad = Convert.ToString(Console.ReadLine());
            Console.Write("Soyadınız: ");
            soyad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Başlıyoruz, Enter Tuşuna Basın...");
            Console.WriteLine("Her yanıttan sonra ENTER tuşuna basmayı unutmayın!");
            Console.WriteLine("Cevapları BÜYÜK HARFLERLE Verin!");

            Console.ReadLine();

            int dogru=0, yanlis=0, para=0;

            Console.WriteLine("Soru 1- Cumhuriyet kaç yılında ilan edilmiştir?");
            Console.WriteLine(" A-1920\n B-1923\n C-1924\n D-1926\n Cevabınız:");
            string c1 = Convert.ToString(Console.ReadLine());
            if (c1 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }


            Console.WriteLine("Soru 2- Türkiye'nin başkenti hangi şehirdir?");
            Console.WriteLine(" A-İstanbul\n B-İzmir\n C-Ankara\n D-Konya\n Cevabınız:");
            string c2 = Convert.ToString(Console.ReadLine());
            if (c2 == "C")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 3- Maki, hangi bölgenin bitki örtüsüdür?");
            Console.WriteLine(" A-Akdeniz\n B-Ege\n C-Marmara\n D-Karadeniz\n Cevabınız:");
            string c3 = Convert.ToString(Console.ReadLine());
            if (c3 == "A")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 4- Hangisi İstanbul'da bulunan bir semt değildir?");
            Console.WriteLine(" A-Üsküdar\n B-Urla\n C-Sarıyer\n D-Kartal\n Cevabınız:");
            string c4 = Convert.ToString(Console.ReadLine());
            if (c4 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 5- Hangisi programlamanın temel renklerinden değildir?");
            Console.WriteLine(" A-Mavi\n B-Yeşil\n C-Kırmızı\n D-Sarı\n Cevabınız:");
            string c5 = Convert.ToString(Console.ReadLine());
            if (c5 == "D")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 6- Avrupa'nın kullandığı ortak para birimi hangisidir?");
            Console.WriteLine(" A-Dolar\n B-Euro\n C-Zloty\n D-Ruble\n Cevabınız:");
            string c6 = Convert.ToString(Console.ReadLine());
            if (c6 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 7- Hangi ilimiz Ege Bölgesi'nde değildir?");
            Console.WriteLine(" A-İzmir\n B-Muğla\n C-Edirne\n D-Aydın\n Cevabınız:");
            string c7 = Convert.ToString(Console.ReadLine());
            if (c7 == "C")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 8- Sefiller kitabının yazarı kimdir?");
            Console.WriteLine(" A-Jules Verne\n B-Gogol\n C-Tolstoy\n D-Victor Hugo\n Cevabınız:");
            string c8 = Convert.ToString(Console.ReadLine());
            if (c8 == "D")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 9- Mustafa Kemal Atatürk'ün nüfusa kayıtlı olduğu il hangisidir?");
            Console.WriteLine(" A-İstanbul\n B-İzmir\n C-Ankara\n D-Gaziantep\n Cevabınız:");
            string c9 = Convert.ToString(Console.ReadLine());
            if (c9 == "D")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 10- İstiklal Marşı şairimiz kimdir?");
            Console.WriteLine(" A-Ziya Gökalp\n B-Mehmet Akif Ersoy\n C-Orhan Veli\n D-Reşat Nuri Güntekin\n Cevabınız:");
            string c10 = Convert.ToString(Console.ReadLine());
            if (c10 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Doğru Sayısı: " + dogru);
            Console.WriteLine("Yanlış Sayısı: " + yanlis);
            Console.WriteLine("Toplam kazandığınız para: " + para + " TL");

            Console.Read();

        }
    }
}
```

# Matematik Menüsü Uygulaması <a name="p42"></a>
```c#
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
```

# Sayı Tahmin Oyunu <a name="p43"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Sayi_Tamin_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {

            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random rastgele = new Random();
            hafiza = rastgele.Next(1, 1000);
            while (tahmin != hafiza)
            {
                sayac++;
                Console.Write("Sayı Girin: ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > hafiza)
                {
                    Console.WriteLine("Daha küçük sayı girin!");
                }
                else if (tahmin < hafiza)
                {
                    Console.WriteLine("Daha büyük sayı girin!");
                }
            }
            Console.WriteLine("Tebriklerrr...!!!");
            Console.WriteLine("{0}. denemede buldunuz!", sayac);
            Console.ReadLine();
        }
    }
}
```

# Müzik Çalar Uygulaması <a name="p44"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media; //Müzik dosyasını oynatmak için öncelikle gerekli olan media kütüphanemizi ekliyoruz

namespace _44_Muzik_Oynatma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Arkaplanda .wav uzantılı ses dosyalarının çalıştırılması için:
            SoundPlayer ses = new SoundPlayer();
            string yol = @"C:\Users\nihat\OneDrive\Belgeler\GitHub\Learning-Programming-Languages\C#\C#-Console\44-Muzik_Oynatma\Sainte Vie - Darko.wav";
            ses.SoundLocation = yol;
            ses.Play();
            Console.Read();
            */



            //Windows Media Player açılarak ses dosyasının çalınması için:
            System.Diagnostics.Process.Start("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C#\\C#-Console\\44-Muzik_Oynatma\\Sainte Vie - Darko.mp3");
            //Dosya yolunu belli etmek için ya başına @ işareti konulmalı ya da ters slash (\) işaretleri 2 kere yazılmalıdır.
        }
    }
}
```

# Futbol Lig Uygulaması <a name="p45"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Rastgele_Lig_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Turkcell Super Lig Uygulaması";

            Console.WriteLine("Rastgele Lig Turnuvamıza Hoşgeldiniz!!!\n");
            Console.WriteLine("Katılan Tüm Takımlara Başarılar Dileriz...\n");

            int gs = 0;
            int fb = 0;
            int bjk = 0;
            int ts = 0;
            int sayac = 1;

            int gs1, gs2, gs3;
            int fb1, fb2, fb3;
            int bjk1, bjk2, bjk3;
            int ts1, ts2, ts3;

            Random rastgele = new Random();

            if (sayac == 1)
            {
                gs1 = rastgele.Next(0, 6);
                fb1 = rastgele.Next(0, 6);
                bjk1 = rastgele.Next(0, 6);
                ts1 = rastgele.Next(0, 6);

                Console.WriteLine("1. Hafta Skorları");
                Console.WriteLine("----------------------------");

                Console.WriteLine("Galatasaray " + gs1 + "-" + fb1 + " Fenerbahçe");
                if (gs1 > fb1) { gs += 3; }
                else if (gs1 < fb1) { fb += 3; }
                else { fb++; gs++; }
                Console.WriteLine("Beşiktaş " + bjk1 + "-" + ts1 + " Trabzonspor");
                if (bjk1 > ts1) { bjk += 3; }
                else if (ts1 > bjk1) { ts += 3; }
                else { ts++; bjk++; }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 2)
            {
                gs2 = rastgele.Next(0, 6);
                fb2 = rastgele.Next(0, 6);
                bjk2 = rastgele.Next(0, 6);
                ts2 = rastgele.Next(0, 6);

                Console.WriteLine("2. Hafta Skorları");
                Console.WriteLine("----------------------------");

                Console.WriteLine("Fenerbahçe " + fb2 + "-" + bjk2 + " Beşiktaş");
                if (bjk2 > fb2) { bjk += 3; }
                else if (fb2 > bjk2) { fb += 3; }
                else { fb++; bjk++; }
                Console.WriteLine("Trabzonspor " + ts2 + "-" + gs2 + " Galatasaray");
                if (gs2 > ts2) { gs += 3; }
                else if (ts2 > gs2) { ts += 3; }
                else { ts++; gs++; }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 3)
            {
                gs3 = rastgele.Next(0, 6);
                fb3 = rastgele.Next(0, 6);
                bjk3 = rastgele.Next(0, 6);
                ts3 = rastgele.Next(0, 6);

                Console.WriteLine("3. Hafta Skorları");
                Console.WriteLine("----------------------------");

                Console.WriteLine("Trabzonspor " + ts3 + "-" + fb3 + " Fenerbahçe");
                if (fb3 > ts3) { fb += 3; }
                else if (ts3 > fb3) { ts += 3; }
                else { ts++; fb++; }
                Console.WriteLine("Beşiktaş " + bjk3 + "-" + gs3 + " Galatasaray");
                if (bjk3 > gs3) { bjk += 3; }
                else if (gs3 > bjk3) { gs += 3; }
                else { gs++; bjk++; }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 4)
            {
                Console.WriteLine("Maçlar Tammalandı!");
                Console.WriteLine("Puan Tablosu");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Galatasaray: " + gs);
                Console.WriteLine("Fenerbahçe: " + fb);
                Console.WriteLine("Beşiktaş: " + bjk);
                Console.WriteLine("Trabzonspor: " + ts);
            }

            Console.ReadLine();
        }
    }
}
```

# Yemek Sipariş Uygulaması <a name="p46"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_Yemek_Siparis_Programi
{
    class Program
    {
        static void Main(string[] args)
        {

            double secim, adet, toplam = 0;
            double hesap = 0;

            Console.WriteLine("***************************************************************");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**          Yemekler          **          İçecekler          **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**   1-Et Döner - 7.00 TL     **       7-Ayran - 1.00 TL     **");
            Console.WriteLine("**   2-Tavuk Döner - 5.00 TL  **       8-Kola - 3.00 TL      **");
            Console.WriteLine("**   3-Çorbalar - 4.00 TL     **       9-Su - 0.50 Krş       **");
            Console.WriteLine("**   4-Salatalar - 2.50 TL    **      10-Çay - 0.75 Krş      **");
            Console.WriteLine("**   5-Kuru/Pilav - 6.00 TL   **      11-Fanta - 2.00 TL     **");
            Console.WriteLine("**   6-Pide - 6.50 TL         **      12-Soda - 1.00 TL      **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("***************************************************************");

            for(int i = 1; i < 100; i++)
            {
                Console.Write("\nAlacağınız Ürünün Numarası: ");
                secim = Convert.ToDouble(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("Kaç Porsiyon Et Döner: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7;
                    hesap += toplam;
                }
                else if (secim == 2)
                {
                    Console.Write("Kaç Tabak Tavuk Döner: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap += toplam;
                }
                else if (secim == 3)
                {
                    Console.Write("Kaç Kase Çorba: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 4;
                    hesap += toplam;
                }
                else if (secim == 4)
                {
                    Console.Write("Kaç Tabak Salata: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2.50;
                    hesap += toplam;
                }
                else if (secim == 5)
                {
                    Console.Write("Kaç Porsiyon Kuru/Pilav: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6;
                    hesap += toplam;
                }
                else if (secim == 6)
                {
                    Console.Write("Kaç Porsiyon Pide: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6.50;
                    hesap += toplam;
                }
                else if (secim == 7)
                {
                    Console.Write("Kaç Ayran: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap += toplam;
                }
                else if (secim == 8)
                {
                    Console.Write("Kaç Tane Kola: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 3;
                    hesap += toplam;
                }
                else if (secim == 9)
                {
                    Console.Write("Kaç Tane Su: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 0.50;
                    hesap += toplam;
                }
                else if (secim == 10)
                {
                    Console.Write("Kaç Tane Çay: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 0.75;
                    hesap += toplam;
                }
                else if (secim == 11)
                {
                    Console.Write("Kaç Tane Fanta: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2;
                    hesap += toplam;
                }
                else if (secim == 12)
                {
                    Console.Write("Kaç Tane Soda: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap += toplam;
                }
                else
                {
                    Console.WriteLine("Böyle bir seçim yok!\n");
                }
                Console.Write("Başka bir isteğiniz var mı?: ");
                string cevap = Console.ReadLine();
                if(cevap=="h" || cevap=="H" || cevap=="Hayır" || cevap=="HAYIR" || cevap == "hayır")
                {
                    break;
                }
            }
            Console.WriteLine("\nToplam tutar: " + hesap + " TL");
            Console.ReadLine();


        }
    }
}
```

# Metin Belgesi Kayıt Programı <a name="p47"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Input/Output kütüphanesini entegre ediyoruz

namespace _48_Metin_Belgesi_Kayit_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dosya adı ne olsun?: ");
            string dadi = Console.ReadLine();
            StreamWriter dosya = new StreamWriter(@"C:\Users\nihat\OneDrive\Belgeler\GitHub\Learning-Programming-Languages\C#\C#-Console\48-Metin_Belgesi_Kayit_Uygulamasi\gunluk\" + dadi + ".txt");
            Console.WriteLine("Buraya notunuzu yazın: ");
            string veri = Console.ReadLine();
            dosya.WriteLine(veri);
            dosya.Close();
        }
    }
}
```

# Boxing - Unboxing <a name="p48"></a>
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing: Küçük veri türünü büyüğe koymak
            int i = 5;
            object o1 = i;
            Console.WriteLine(o1);
            //Output = 5



            //Unboxing: Büyük veri türünü küçüğe sığdırmaya çalışmak
            object o2 = 11;
            //int k = o2; //Bu şekilde direkt olarak eşitleme yapılamaz
            int k = Convert.ToInt32(o2);
            Console.WriteLine(o2);
            //Output = 11



            Console.ReadLine();
        }
    }
}
```
