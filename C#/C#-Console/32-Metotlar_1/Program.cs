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
