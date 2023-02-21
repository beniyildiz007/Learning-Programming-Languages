using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media; //Müzik dosyasını oynatmak için öncelikle gerekli olan media kütüphanemizi ekliyoruz

namespace _44_Muzik_Oynatma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Arkaplanda .wav uzantılı ses dosyalarının çalıştırılması için:
            SoundPlayer ses = new SoundPlayer();
            string yol = @"C:\Users\nihat\OneDrive\Belgeler\GitHub\Learning-Programming-Languages\C#\C#-Console\44-Muzik_Oynatma\Sainte Vie - Darko.wav";
            ses.SoundLocation = yol;
            ses.Play();
            Console.Read();
            */



            //Windows Media Player açılarak ses dosyasının çalınması için:
            System.Diagnostics.Process.Start("C:\\Users\\nihat\\OneDrive\\Belgeler\\GitHub\\Learning-Programming-Languages\\C#\\C#-Console\\44-Muzik_Oynatma\\Sainte Vie - Darko.mp3");
            //Dosya yolunu belli etmek için ya başına @ işareti konulmalı ya da ters slash (\) işaretleri 2 kere yazılmalıdır.
        }
    }
}
