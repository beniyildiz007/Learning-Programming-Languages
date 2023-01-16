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
