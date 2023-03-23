using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_GeriyeDeger_Dondurmeyen_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mesaj msj = new Mesaj();
            //msj.metin();
            //Console.Read();

            Kisiler ks = new Kisiler();
            Console.WriteLine("Adınızı giriniz: ");
            string ads = Console.ReadLine();
            ks.kisilistesi(ads);
            Console.Read();
        }
    }
}
