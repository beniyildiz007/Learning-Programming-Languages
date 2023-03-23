using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Sinif_Olusturma
{
    class Araba : ArabaDetay
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private string marka;

        public int YIL //Kapsülleme İşlemi
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }

        public string MARKA //Kapsülleme işlemi
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
    }
}
