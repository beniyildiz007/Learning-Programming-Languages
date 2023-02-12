using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Arka_Plan_Rengi_Degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.BackgroundColor = ConsoleColor.Blue; //Arkaplan rengimizi Mavi yaptık
            Console.ForegroundColor = ConsoleColor.Black; //Yazımızın rengini siyah yaptık
            Console.Title = "Çanakkale Zaferi"; //Console penceremizin başlığını değiştirdik
            Console.Clear();
            Console.WriteLine("18 Mart Çanakkale Şehitlerini Anma Günü");

            Console.ReadLine();
            */




            Console.Write("Lütfen bir sayı girin: ");
            ConsoleColor renk = (ConsoleColor)Convert.ToInt32(Console.ReadLine());
            Console.BackgroundColor = renk;            
            Console.Clear();
            Console.ReadLine();
            //0-15 arasında bir sayı girilmeli çünkü 16 tane renk paleti tanımlanmış durumda


        }
    }
}
