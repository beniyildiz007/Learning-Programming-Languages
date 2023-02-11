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
