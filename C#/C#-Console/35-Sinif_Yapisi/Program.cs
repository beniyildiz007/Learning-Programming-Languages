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
