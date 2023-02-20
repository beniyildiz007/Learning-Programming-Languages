using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_Bilgi_Yarismasi_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************************");
            Console.WriteLine("Yarışmaya Hoşgeldiniz!");
            Console.WriteLine("************************");
            Console.Title = "Bilgi Yarışması";
            string ad, soyad;
            Console.Write("Adınız: ");
            ad = Convert.ToString(Console.ReadLine());
            Console.Write("Soyadınız: ");
            soyad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Başlıyoruz, Enter Tuşuna Basın...");
            Console.WriteLine("Her yanıttan sonra ENTER tuşuna basmayı unutmayın!");
            Console.WriteLine("Cevapları BÜYÜK HARFLERLE Verin!");

            Console.ReadLine();

            int dogru=0, yanlis=0, para=0;

            Console.WriteLine("Soru 1- Cumhuriyet kaç yılında ilan edilmiştir?");
            Console.WriteLine(" A-1920\n B-1923\n C-1924\n D-1926\n Cevabınız:");
            string c1 = Convert.ToString(Console.ReadLine());
            if (c1 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }


            Console.WriteLine("Soru 2- Türkiye'nin başkenti hangi şehirdir?");
            Console.WriteLine(" A-İstanbul\n B-İzmir\n C-Ankara\n D-Konya\n Cevabınız:");
            string c2 = Convert.ToString(Console.ReadLine());
            if (c2 == "C")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 3- Maki, hangi bölgenin bitki örtüsüdür?");
            Console.WriteLine(" A-Akdeniz\n B-Ege\n C-Marmara\n D-Karadeniz\n Cevabınız:");
            string c3 = Convert.ToString(Console.ReadLine());
            if (c3 == "A")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 4- Hangisi İstanbul'da bulunan bir semt değildir?");
            Console.WriteLine(" A-Üsküdar\n B-Urla\n C-Sarıyer\n D-Kartal\n Cevabınız:");
            string c4 = Convert.ToString(Console.ReadLine());
            if (c4 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 5- Hangisi programlamanın temel renklerinden değildir?");
            Console.WriteLine(" A-Mavi\n B-Yeşil\n C-Kırmızı\n D-Sarı\n Cevabınız:");
            string c5 = Convert.ToString(Console.ReadLine());
            if (c5 == "D")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 6- Avrupa'nın kullandığı ortak para birimi hangisidir?");
            Console.WriteLine(" A-Dolar\n B-Euro\n C-Zloty\n D-Ruble\n Cevabınız:");
            string c6 = Convert.ToString(Console.ReadLine());
            if (c6 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 7- Hangi ilimiz Ege Bölgesi'nde değildir?");
            Console.WriteLine(" A-İzmir\n B-Muğla\n C-Edirne\n D-Aydın\n Cevabınız:");
            string c7 = Convert.ToString(Console.ReadLine());
            if (c7 == "C")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 8- Sefiller kitabının yazarı kimdir?");
            Console.WriteLine(" A-Jules Verne\n B-Gogol\n C-Tolstoy\n D-Victor Hugo\n Cevabınız:");
            string c8 = Convert.ToString(Console.ReadLine());
            if (c8 == "D")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 9- Mustafa Kemal Atatürk'ün nüfusa kayıtlı olduğu il hangisidir?");
            Console.WriteLine(" A-İstanbul\n B-İzmir\n C-Ankara\n D-Gaziantep\n Cevabınız:");
            string c9 = Convert.ToString(Console.ReadLine());
            if (c9 == "D")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Soru 10- İstiklal Marşı şairimiz kimdir?");
            Console.WriteLine(" A-Ziya Gökalp\n B-Mehmet Akif Ersoy\n C-Orhan Veli\n D-Reşat Nuri Güntekin\n Cevabınız:");
            string c10 = Convert.ToString(Console.ReadLine());
            if (c10 == "B")
            {
                dogru += 1;
                para += 1000;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Tebrikler cevap doğru, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }
            else
            {
                yanlis += 1;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Malesef cevap yanlış, bir sonraki soru için ENTER tuşuna basın.");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ReadLine();
            }

            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Doğru Sayısı: " + dogru);
            Console.WriteLine("Yanlış Sayısı: " + yanlis);
            Console.WriteLine("Toplam kazandığınız para: " + para + " TL");

            Console.Read();

        }
    }
}
