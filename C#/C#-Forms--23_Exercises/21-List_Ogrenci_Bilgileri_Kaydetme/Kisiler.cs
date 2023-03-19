using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_List_Ogrenci_Bilgileri_Kaydetme
{
    class Kisiler
    {
        string ad;
        string soyad;
        string meslek;

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

        public string MESLEGI
        {
            get { return meslek; }
            set { meslek = value; }
        }
    }
}
