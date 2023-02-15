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
