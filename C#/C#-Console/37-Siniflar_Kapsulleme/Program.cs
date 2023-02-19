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
