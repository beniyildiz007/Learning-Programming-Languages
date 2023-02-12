using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_Cok_Boyutlu_Diziler_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*** Matrislerde Toplama İşlemi ***");

            int[,] matris1 = { { 10, 12, 14, 18 }, { 20, 14, 16, 13 }, { 25, 14, 41, 21 }, { 32, 36, 41, 57 } };
            int[,] matris2 = { { 40, 30, 20, 10 }, { 7, 9, 8, 6 }, { 21, 22, 23, 24 }, { 56, 54, 51, 44 } };

            int[,] toplam = new int[4, 4];

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    toplam[i, j] = matris1[i, j] + matris2[i, j];
                }
            }

            for(int k = 0; k < 4; k++)
            {
                Console.WriteLine();
                for(int m = 0; m < 4; m++)
                {
                    Console.Write(toplam[k, m] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
