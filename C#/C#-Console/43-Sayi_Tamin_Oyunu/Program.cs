using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_Sayi_Tamin_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {

            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random rastgele = new Random();
            hafiza = rastgele.Next(1, 1000);
            while (tahmin != hafiza)
            {
                sayac++;
                Console.Write("Sayı Girin: ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > hafiza)
                {
                    Console.WriteLine("Daha küçük sayı girin!");
                }
                else if (tahmin < hafiza)
                {
                    Console.WriteLine("Daha büyük sayı girin!");
                }
            }
            Console.WriteLine("Tebriklerrr...!!!");
            Console.WriteLine("{0}. denemede buldunuz!", sayac);
            Console.ReadLine();
        }
    }
}
