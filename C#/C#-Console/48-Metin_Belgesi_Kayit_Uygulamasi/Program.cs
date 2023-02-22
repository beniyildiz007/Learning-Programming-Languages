using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Input/Output kütüphanesini entegre ediyoruz

namespace _48_Metin_Belgesi_Kayit_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dosya adı ne olsun?: ");
            string dadi = Console.ReadLine();
            StreamWriter dosya = new StreamWriter(@"C:\Users\nihat\OneDrive\Belgeler\GitHub\Learning-Programming-Languages\C#\C#-Console\48-Metin_Belgesi_Kayit_Uygulamasi\gunluk\" + dadi + ".txt");
            Console.WriteLine("Buraya notunuzu yazın: ");
            string veri = Console.ReadLine();
            dosya.WriteLine(veri);
            dosya.Close();
        }
    }
}
