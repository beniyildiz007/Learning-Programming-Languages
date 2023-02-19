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
