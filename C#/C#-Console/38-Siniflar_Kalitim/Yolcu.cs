using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Siniflar_Kalitim
{
    class Yolcu
    {

        private string ad;
        private string soyad;
        private int yas;
        private string cinsiyet;

        public string ADI
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }

        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }

        public int YASI
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public string CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value.ToLower(); }
        }
    }
}
