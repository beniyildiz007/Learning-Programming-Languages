using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_If_Else_Yapisi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string mevsim;
            Console.Write("Lütfen bir mevsim giriniz: ");
            mevsim = Console.ReadLine();

            if (mevsim == "kış")
            {
                Console.Write("Kış mevsimi ayları: Aralık - Ocak - Şubat");
            }
            else if (mevsim == "ilkbahar")
            {
                Console.Write("İlkbahar mevsimi ayları: Mart - Nisan - Mayıs");
            }
            else if (mevsim == "yaz")
            {
                Console.Write("Yaz mevsimi ayları: Haziran - Temmuz - Ağustos");
            }
            else if (mevsim == "sonbahar")
            {
                Console.Write("Sonbahar mevsimi ayları: Eylül - Ekim - Kasım");
            }

            Console.ReadLine();
            */


            Console.WriteLine("*** Ali Amcanın Kitapçı Dükkanı ***");

            double x, indirim, odenecek;
            Console.Write("Alışveriş Tutarını Girin: ");
            x = Convert.ToDouble(Console.ReadLine());

            if (x < 100)
            {
                indirim = x * 10 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Uygulanacak İndirim= " + indirim);
                Console.Write("Toplam Miktar= " + odenecek);
            }
            if (x >= 100 && x < 150)
            {
                indirim = x * 15 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Uygulanacak İndirim= " + indirim);
                Console.Write("Toplam Miktar= " + odenecek);
            }
            if (x >= 150 && x < 200)
            {
                indirim = x * 20 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Uygulanacak İndirim= " + indirim);
                Console.Write("Toplam Miktar= " + odenecek);
            }
            if (x >= 200)
            {
                indirim = x * 30 / 100;
                odenecek = x - indirim;
                Console.WriteLine("Uygulanacak İndirim= " + indirim);
                Console.Write("Toplam Miktar= " + odenecek);
            }

            Console.Read();

        }
    }
}
