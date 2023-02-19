using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Ref_Out
{
    class Program
    {

        static void arttir(ref int s)
        {
            s++;
        }

        static void azalt(out int n)
        {
            n = 12;
            n--;
        }

        static void Main(string[] args)
        {

            int a = 9;
            arttir(ref a); //ref kullanmazsak a=10 olmayacak, a=9 olarak kalacaktı.
            Console.WriteLine(a);

            int x; //Değişkenin değerini metodun içerisinde tanımlamıştık
            azalt(out x);
            Console.WriteLine(x);
            Console.Read();
        }
    }
}
