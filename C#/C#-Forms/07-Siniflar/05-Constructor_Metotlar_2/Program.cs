using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Constructor_Metotlar_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Kimlik kml = new Kimlik();

            kml.AD = "Berkan Nihat";
            kml.SOYAD = "Yıldız";
            kml.MEMLEKET = "Antalya";

            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);

            //Yaş ve Cinsiyet değerlerini belirtmediğimiz için 18 ve Antalya olarak getirildi

            Console.ReadKey();


        }
    }
}
