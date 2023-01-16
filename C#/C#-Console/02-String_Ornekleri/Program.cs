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
