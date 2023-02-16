using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Siniflar_Get_Set_Kavrami
{
    class Ogrenci
    {

        private string ad;
        private string soyad;
        private int yas;
        private string alan;

        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string ALANI
        {
            get { return alan; }
            set { alan = value; }
        }
        public int YASI
        {
            get { return yas; }
            set
            {
                if (value < 18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }
        }
    }
}
