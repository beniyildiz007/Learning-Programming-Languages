using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Cok_Boyutlu_Dizi_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[,] dizi = new int[2, 2];
            dizi[0, 0] = 25;
            dizi[0, 1] = 35;
            dizi[1, 0] = 17;
            dizi[1, 1] = 16;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" {0} ", dizi[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();
            */



            int[,] dizi = new int[2, 3];
            dizi[0, 0] = 10;
            dizi[0, 1] = 20;
            dizi[0, 2] = 30;
            dizi[1, 0] = 40;
            dizi[1, 1] = 50;
            dizi[1, 2] = 60;

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(" {0} ", dizi[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
