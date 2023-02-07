using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Switch_Case_Yapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int sayi;
            Console.WriteLine("1 ile 7 arasında bir sayı giriniz:");
            sayi = Convert.ToInt16(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                    Console.WriteLine("Gün = Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Gün = Salı");
                    break;
                case 3:
                    Console.WriteLine("Gün = Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Gün = Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Gün = Cuma");
                    break;
                case 6:
                    Console.WriteLine("Gün = Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Gün = Pazar");
                    break;
                default:
                    Console.WriteLine("Hatalı Gün Girişi!");
                    break;
            }

            Console.ReadLine();
            */


            string mevsim;
            Console.WriteLine("Lütfen mevsimi küçük harflerle giriniz: ");
            mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "yaz":
                    Console.WriteLine("Yaz mevsimi ayları = Haziran - Temmuz - Ağustos");
                    break;
                case "sonbahar":
                    Console.WriteLine("Sonbahar mevsimi ayları = Eylül - Ekim - Kasım");
                    break;
                case "kış":
                    Console.WriteLine("Kış mevsimi ayları = Aralık - Ocak - Şubat");
                    break;
                case "ilkbahar":
                    Console.WriteLine("İlkbahar mevsimi ayları = Mart - Nisan - Mayıs");
                    break;
                default:
                    Console.WriteLine("Hatalı Mevsim Girişi!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
