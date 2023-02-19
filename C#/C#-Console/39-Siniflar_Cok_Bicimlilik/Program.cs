using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Siniflar_Cok_Bicimlilik
{

    class insan
    {
        public virtual void selamver()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "Selamlaşma Uygulaması";
            Console.WriteLine("Merhaba Şubat 2023'ten Selamlar");
        }
    }

    class Türk : insan
    {
        public override void selamver()
        {
            Console.WriteLine("Esenlikler");
        }
    }

    class Fransız : insan
    {
        public override void selamver()
        {
            Console.WriteLine("Bonjour");
        }
    }

    class İngiliz : insan
    {
        public override void selamver()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            insan ins = new insan();
            ins.selamver();
            Console.Read();
            */



            /*
            Türk trk = new Türk();
            trk.selamver();
            Console.Read();
            */


            /*
            Fransız fr = new Fransız();
            fr.selamver();
            Console.Read();
            */



            İngiliz ing = new İngiliz();
            ing.selamver();
            Console.Read();







        }
    }
}
