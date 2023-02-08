using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Char_Degiskeni
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char harf;
            harf = 'n'; //Char türü yalnızca 1 harf tutar ve tek tırnaklar arasında gösterilir
            Console.WriteLine(harf);
            Console.ReadLine();
            */


            /*
            char cinsiyet;
            Console.Write("Cinsiyetinizi Girin: ");
            cinsiyet = Convert.ToChar(Console.ReadLine());
            if (cinsiyet == 'e' || cinsiyet=='E')
            {
                Console.WriteLine("Cinsiyetiniz Erkektir");
            }
            else
            {
                Console.WriteLine("Cinsiyetiniz Kadındır");
            }
            Console.ReadLine();
            */


            char ders;
            Console.WriteLine("**** YGS Dersleri Menüsü ****\n");
            Console.WriteLine("Türkçe");
            Console.WriteLine("Matematik");
            Console.WriteLine("Sosyal Bilgisi");
            Console.WriteLine("Fen Bilgisi\n");
            Console.Write("Hangi dersin bilgilerini görmek istersiniz?: ");

            ders = Convert.ToChar(Console.ReadLine());
            if(ders=='t' || ders == 'T')
            {
                Console.Write("Türkçe dersi paragraf ağırlıklı olup dil bilgisi soruları da içerir.");
            }
            else if (ders == 'm' || ders == 'M')
            {
                Console.Write("Matematik dersi temel mat1 konuları ve 8-9 tane geometri sorusu içerir.");
            }
            else if (ders == 's' || ders == 'S')
            {
                Console.Write("Sosyal Bilgiler dersi tarih ve coğrafya konularını içerir.");
            }
            else
            {
                Console.Write("Fen Bilgisi fizik, kimya ve biyoloji konularını içerir.");
            }
            Console.ReadLine();
        }
    }
}
