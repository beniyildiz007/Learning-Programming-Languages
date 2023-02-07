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
