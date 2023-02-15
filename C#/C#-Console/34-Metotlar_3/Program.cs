using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_Metotlar_3
{
    class Metotlar //Başlangıçta Program olan gelen class adını değiştirdik
    {

        int topla(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Metotlar mtr = new Metotlar(); //Önce mtr adında Metotlar sınıfından bir nesne türettik
            int toplam = mtr.topla(1, 3); //Daha sonra ise bu nesneyi kullanarak topla() metodunu kullandık
            Console.WriteLine("Toplam: " + toplam);
            Console.ReadLine();
            //Output = Toplam: 4
            
        }
    }
}
