using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Bool_Degiskeni
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int sayi;
            Console.Write("Sayıyı girin:");
            sayi = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sayi > 0;
            bool durum2 = sayi > 10;
            Console.WriteLine("Sayı Pozitif mi {0}", durum1);
            Console.WriteLine("Sayı 10'dan büyük mü {0}", durum2);
            Console.ReadLine();
            */



            Console.Write("Şifreyi Girin: ");
            int sifre;
            sifre = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sifre == 1234;
            Console.WriteLine("Şifre Doğrumu {0}", durum1);
            Console.ReadLine();

        }
    }
}
