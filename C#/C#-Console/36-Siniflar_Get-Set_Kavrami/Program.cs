using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Siniflar_Get_Set_Kavrami
{
    class Program
    {
        static void Main(string[] args)
        {

            Ogrenci ogr = new Ogrenci();
            ogr.ADI = "Berkan Nihat";
            ogr.SOYADI = "Yıldız";
            ogr.ALANI = "Mateamtik-Fen";
            ogr.YASI = 15; //Yaş otomatik olarak 18 gelecektir

            Console.WriteLine("Adı: " + ogr.ADI);
            Console.WriteLine("Soyadı: " + ogr.SOYADI);
            Console.WriteLine("Alanı: " + ogr.ALANI);
            Console.WriteLine("Yaşı: " + ogr.YASI);

            Console.ReadLine();
        }
    }
}
