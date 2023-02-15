using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_Yildizlarla_Sekil_Cizme_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Büyüklüğü girilen baklava dilimin çizdirmek
            Console.Write("Baklava Dilimi Büyüklüğü: ");
            int dilim = Convert.ToInt32(Console.ReadLine());

            //Üst kısım
            for (int i = 1; i <= dilim; i++)
            {
                for (int j = dilim; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Alt kısım
            for (int i = 1; i <= dilim; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = dilim; k > i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
