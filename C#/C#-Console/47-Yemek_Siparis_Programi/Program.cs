using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47_Yemek_Siparis_Programi
{
    class Program
    {
        static void Main(string[] args)
        {

            double secim, adet, toplam = 0;
            double hesap = 0;

            Console.WriteLine("***************************************************************");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**          Yemekler          **          İçecekler          **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("**   1-Et Döner - 7.00 TL     **       7-Ayran - 1.00 TL     **");
            Console.WriteLine("**   2-Tavuk Döner - 5.00 TL  **       8-Kola - 3.00 TL      **");
            Console.WriteLine("**   3-Çorbalar - 4.00 TL     **       9-Su - 0.50 Krş       **");
            Console.WriteLine("**   4-Salatalar - 2.50 TL    **      10-Çay - 0.75 Krş      **");
            Console.WriteLine("**   5-Kuru/Pilav - 6.00 TL   **      11-Fanta - 2.00 TL     **");
            Console.WriteLine("**   6-Pide - 6.50 TL         **      12-Soda - 1.00 TL      **");
            Console.WriteLine("**                            **                             **");
            Console.WriteLine("***************************************************************");

            for(int i = 1; i < 100; i++)
            {
                Console.Write("\nAlacağınız Ürünün Numarası: ");
                secim = Convert.ToDouble(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("Kaç Porsiyon Et Döner: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7;
                    hesap += toplam;
                }
                else if (secim == 2)
                {
                    Console.Write("Kaç Tabak Tavuk Döner: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 5;
                    hesap += toplam;
                }
                else if (secim == 3)
                {
                    Console.Write("Kaç Kase Çorba: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 4;
                    hesap += toplam;
                }
                else if (secim == 4)
                {
                    Console.Write("Kaç Tabak Salata: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2.50;
                    hesap += toplam;
                }
                else if (secim == 5)
                {
                    Console.Write("Kaç Porsiyon Kuru/Pilav: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6;
                    hesap += toplam;
                }
                else if (secim == 6)
                {
                    Console.Write("Kaç Porsiyon Pide: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6.50;
                    hesap += toplam;
                }
                else if (secim == 7)
                {
                    Console.Write("Kaç Ayran: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap += toplam;
                }
                else if (secim == 8)
                {
                    Console.Write("Kaç Tane Kola: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 3;
                    hesap += toplam;
                }
                else if (secim == 9)
                {
                    Console.Write("Kaç Tane Su: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 0.50;
                    hesap += toplam;
                }
                else if (secim == 10)
                {
                    Console.Write("Kaç Tane Çay: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 0.75;
                    hesap += toplam;
                }
                else if (secim == 11)
                {
                    Console.Write("Kaç Tane Fanta: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 2;
                    hesap += toplam;
                }
                else if (secim == 12)
                {
                    Console.Write("Kaç Tane Soda: ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 1;
                    hesap += toplam;
                }
                else
                {
                    Console.WriteLine("Böyle bir seçim yok!\n");
                }
                Console.Write("Başka bir isteğiniz var mı?: ");
                string cevap = Console.ReadLine();
                if(cevap=="h" || cevap=="H" || cevap=="Hayır" || cevap=="HAYIR" || cevap == "hayır")
                {
                    break;
                }
            }
            Console.WriteLine("\nToplam tutar: " + hesap + " TL");
            Console.ReadLine();


        }
    }
}
