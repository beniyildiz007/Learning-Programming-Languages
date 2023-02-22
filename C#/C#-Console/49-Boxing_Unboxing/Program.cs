using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49_Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boxing: Küçük veri türünü büyüğe koymak
            int i = 5;
            object o1 = i;
            Console.WriteLine(o1);
            //Output = 5



            //Unboxing: Büyük veri türünü küçüğe sığdırmaya çalışmak
            object o2 = 11;
            //int k = o2; //Bu şekilde direkt olarak eşitleme yapılamaz
            int k = Convert.ToInt32(o2);
            Console.WriteLine(o2);
            //Output = 11



            Console.ReadLine();
        }
    }
}
