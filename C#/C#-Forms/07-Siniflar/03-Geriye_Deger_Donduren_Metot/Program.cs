using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Geriye_Deger_Donduren_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            islem isl = new islem();
            isl.topla(7, 6);
            isl.topla(4, 6);

            Console.WriteLine("\n\n\n");

            isl.kare(6);
            Console.ReadLine();
        }
    }
}
