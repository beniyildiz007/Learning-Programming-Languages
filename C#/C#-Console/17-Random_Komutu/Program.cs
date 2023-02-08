using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Random_Komutu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random rastgele = new Random();
            int a, b;
            a = rastgele.Next(0, 10);
            b = rastgele.Next(0, 10);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.Read();
            */


            Random rastgele = new Random();
            Console.WriteLine("*** Şehir Atma Programı ***");
            string[] sehirler = { "Adana", "Eskişehir", "Antalya", "İzmir", "Ankara", "İstanbul", "Gaziantep" };
            int i;
            i = rastgele.Next(0, sehirler.Length);
            Console.WriteLine(i);
            Console.WriteLine(sehirler[i]);
            Console.ReadLine();

        }
    }
}
