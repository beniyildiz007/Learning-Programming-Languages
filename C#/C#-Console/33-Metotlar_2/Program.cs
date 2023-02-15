using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_Metotlar_2
{
    class Program
    {

        private static void yazdir(string bilgi) //İÇerisine herhangi bir değişken almayan metotlar void ile tanımlanır
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bilgi);
            }
        }

        private static int Topla(int s1, int s2) //Toplama metodu
        {
            int t = s1 + s2;
            return t;
        }

        private static int Kup(int s1) //Küp alma metodu
        {
            int kup = s1 * s1 * s1;
            return kup;
        }

        static void Main(string[] args)
        {
            /*
            //Girilen metni 10 kere yazdır
            Console.Write("Metni Girin: ");
            string blg = Console.ReadLine();
            yazdir(blg);
            Console.Read();
            */



            /*
            //Kullanıcının girdiği 2 tane sayıyı topla
            Console.Write("Toplamak istediğiniz 1. sayıyı girin: ");
            int sy1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Toplamak istediğiniz 2. sayıyı girin: ");
            int sy2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam: " + Topla(sy1, sy2));
            Console.ReadLine();
            */




            //Kullanıcının girdiği bir sayının küpünü yazdıran program
            Console.Write("Kübünü almak istediğiniz sayıyı giriniz: ");
            int ks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğiniz sayının kübü: " + Kup(ks));
            Console.Read();

        }
    }
}
