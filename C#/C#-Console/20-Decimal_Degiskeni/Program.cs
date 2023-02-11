using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Decimal_Degiskeni
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            decimal sayi;
            sayi = 12.453m;
            Console.WriteLine(sayi);
            Console.Read();
            */


            /*
            decimal s1;
            int s2;
            s1 = 2.45M;
            s2 = 4;
            decimal toplam;
            toplam = s1 + s2;
            Console.WriteLine("Toplam: " + toplam);
            Console.Read();
            //Output = 6,45
            */


            /*
            decimal x = 0.996m;
            decimal y = 999999;
            Console.WriteLine("Para 1 {0:C}", x); //O:C sayıyı yuvarlar
            Console.WriteLine("Para 2 {0:C}", y);
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.Read();
            */




            decimal urun1, urun2, toplam;
            int s1, s2;
            urun1 = 14.85M;
            urun2 = 21.48m;
            Console.Write("1. Ürünün Satış Miktarı: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Ürünün Satış Miktarı: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = s1 * urun1 + s2 * urun2;
            Console.WriteLine("Gün sonunda kasada olması gereken tutar: " + toplam + " TL'dir");
            Console.ReadLine();

        }
    }
}
