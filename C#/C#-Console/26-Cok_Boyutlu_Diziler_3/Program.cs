using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Cok_Boyutlu_Diziler_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int satir, sutun;

            Console.Write("Satır sayısını girin: ");
            satir = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sütun sayısını girin: ");
            sutun = Convert.ToInt32(Console.ReadLine());

            int[,] matris = new int[satir, sutun];

            for(int i = 0; i < satir; i++)
            {
                for(int j = 0; j < sutun; j++)
                {
                    Console.Write("Matrisin {0} x {1} Değeri: ", i + 1, j + 1);
                    matris[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int k = 0; k < satir; k++)
            {
                for (int n = 0; n < sutun; n++)
                {
                    Console.Write(matris[k, n] + " ");
                }
                Console.WriteLine();
            }

            //Matrisi Transpoze Etmek:
            Console.WriteLine("\nMatrisi Transpoze Etmek:");
            for (int x = 0; x < satir; x++)
            {
                for (int y = 0; y < sutun; y++)
                {
                    Console.Write(matris[y, x] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();


            //Matrisi 5 Katsayısı ile Çarpmak:
            Console.WriteLine("Matrisin 5 ile çarpımı:");
            for (int s = 0; s < satir; s++)
            {
                for(int p = 0; p < sutun; p++)
                {
                    Console.Write(matris[s, p]*5 + " ");
                }
                Console.WriteLine();
            }

            //Matrisi kullanıcının girdiği bir katsayı ile çarpmak:
            Console.WriteLine();
            Console.Write("\nMatrisi kaç ile çarpmak istiyorsunuz?: ");
            int katsayi = Convert.ToInt32(Console.ReadLine());

            for (int a = 0; a < satir; a++)
            {
                for (int b = 0; b < sutun; b++)
                {
                    Console.Write(matris[a, b] * katsayi + " ");
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
