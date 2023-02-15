using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Yildizlarla_Sekil_Cizme_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //10x10 dik üçgen çizdirmek v1:
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(new String('*',i)); //new String parametresi içerisinde önce yazdırmak istediğimiz değeri sonra da adedini giriyoruz
            }
            Console.ReadLine();
            */



            /*
            //10x10 dik üçgen çizdirmek v2:
            for (int i = 1; i <= 10; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */




            //10x10 dik üçgen tersten çizdirmek:
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 10; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();



        }
    }
}
