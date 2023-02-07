using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Donguler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Hello World");
            }
            Console.ReadLine();
            */


            /*
            int i;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */



            /*
            int i;
            for (i = 1; i <= 10; i+=3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            //Output = 1 4 7 10
            */


            /*
            int i;
            int toplam = 0;

            for (i = 1; i <= 10; i++)
            {
                toplam += i;
            }
            Console.WriteLine("Toplam = " + toplam);
            Console.ReadLine();
            //Output = 55
            */


            int i;
            int toplam = 0;

            for (i = 1; i <= 10; i+=2)
            {
                toplam += i;
            }
            Console.WriteLine("Toplam = " + toplam);
            Console.ReadLine();
            //Output = 25



        }
    }
}
