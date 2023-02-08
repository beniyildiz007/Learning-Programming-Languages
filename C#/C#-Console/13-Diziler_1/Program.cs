using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Diziler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] sayilar = { 10, 45, 21, 33, 54, 66, 77, 99 };
            Console.WriteLine(sayilar[3]);
            Console.Read();
            //Output = 33
            */


            /*
            string[] isimler = { "ali", "ahmet", "emel", "ayşe", "mehmet", "baran" };
            Console.WriteLine(isimler[0]);
            Console.Read();
            //Output = ali
            */


            
            //Yazılan şehir isimlerini diziye aktarma
            string[] sehirler = new string[3];
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Şehir: ");
                sehirler[i] = Console.ReadLine();
            }
            Console.WriteLine("*** Şehirler Listesi ***");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(sehirler[i]);
            }
            Console.Read();
            
        }
    }
}
