using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Diziler_3_Foreach_Dongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] sehirler = { "Mersin", "İzmir", "Kocaeli", "Artvin", "Ankara", "Erzurum", "Şanlıurfa" };

            foreach(string i in sehirler)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */


            /*
            int[] sayilar = { 1, 4, 8, 9, 10 };
            int toplam = 0;
            foreach(int i in sayilar)
            {
                toplam += i;
            }
            Console.Write("Toplam= " + toplam);
            Console.ReadLine();
            //Output = 32
            */


            /*
            int[] rakamlar = { 1, 7, 5, 4, 8, 6, 9, 3 };
            foreach(int sayi in rakamlar)
            {
                if (sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
            }
            Console.ReadLine();
            */



            int[] degerler = { 1, 2, 3, 4, 5, 6 };
            int sonuc = 1;
            foreach(int i in degerler)
            {
                sonuc *= i;
            }
            Console.WriteLine("6 Sayısının faktöriyeli: " + sonuc);
            Console.ReadLine();
        }
    }
}
