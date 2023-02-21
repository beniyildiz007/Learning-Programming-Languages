using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_Rastgele_Lig_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Turkcell Super Lig Uygulaması";

            Console.WriteLine("Rastgele Lig Turnuvamıza Hoşgeldiniz!!!\n");
            Console.WriteLine("Katılan Tüm Takımlara Başarılar Dileriz...\n");

            int gs = 0;
            int fb = 0;
            int bjk = 0;
            int ts = 0;
            int sayac = 1;

            int gs1, gs2, gs3;
            int fb1, fb2, fb3;
            int bjk1, bjk2, bjk3;
            int ts1, ts2, ts3;

            Random rastgele = new Random();

            if (sayac == 1)
            {
                gs1 = rastgele.Next(0, 6);
                fb1 = rastgele.Next(0, 6);
                bjk1 = rastgele.Next(0, 6);
                ts1 = rastgele.Next(0, 6);

                Console.WriteLine("1. Hafta Skorları");
                Console.WriteLine("----------------------------");

                Console.WriteLine("Galatasaray " + gs1 + "-" + fb1 + " Fenerbahçe");
                if (gs1 > fb1) { gs += 3; }
                else if (gs1 < fb1) { fb += 3; }
                else { fb++; gs++; }
                Console.WriteLine("Beşiktaş " + bjk1 + "-" + ts1 + " Trabzonspor");
                if (bjk1 > ts1) { bjk += 3; }
                else if (ts1 > bjk1) { ts += 3; }
                else { ts++; bjk++; }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 2)
            {
                gs2 = rastgele.Next(0, 6);
                fb2 = rastgele.Next(0, 6);
                bjk2 = rastgele.Next(0, 6);
                ts2 = rastgele.Next(0, 6);

                Console.WriteLine("2. Hafta Skorları");
                Console.WriteLine("----------------------------");

                Console.WriteLine("Fenerbahçe " + fb2 + "-" + bjk2 + " Beşiktaş");
                if (bjk2 > fb2) { bjk += 3; }
                else if (fb2 > bjk2) { fb += 3; }
                else { fb++; bjk++; }
                Console.WriteLine("Trabzonspor " + ts2 + "-" + gs2 + " Galatasaray");
                if (gs2 > ts2) { gs += 3; }
                else if (ts2 > gs2) { ts += 3; }
                else { ts++; gs++; }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 3)
            {
                gs3 = rastgele.Next(0, 6);
                fb3 = rastgele.Next(0, 6);
                bjk3 = rastgele.Next(0, 6);
                ts3 = rastgele.Next(0, 6);

                Console.WriteLine("3. Hafta Skorları");
                Console.WriteLine("----------------------------");

                Console.WriteLine("Trabzonspor " + ts3 + "-" + fb3 + " Fenerbahçe");
                if (fb3 > ts3) { fb += 3; }
                else if (ts3 > fb3) { ts += 3; }
                else { ts++; fb++; }
                Console.WriteLine("Beşiktaş " + bjk3 + "-" + gs3 + " Galatasaray");
                if (bjk3 > gs3) { bjk += 3; }
                else if (gs3 > bjk3) { gs += 3; }
                else { gs++; bjk++; }
                sayac++;
                Console.ReadLine();
            }

            if (sayac == 4)
            {
                Console.WriteLine("Maçlar Tammalandı!");
                Console.WriteLine("Puan Tablosu");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Galatasaray: " + gs);
                Console.WriteLine("Fenerbahçe: " + fb);
                Console.WriteLine("Beşiktaş: " + bjk);
                Console.WriteLine("Trabzonspor: " + ts);
            }

            Console.ReadLine();
        }
    }
}
