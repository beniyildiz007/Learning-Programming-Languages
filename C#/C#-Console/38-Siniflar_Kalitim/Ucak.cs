using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Siniflar_Kalitim
{
    class Ucak:Yolcu
    {

        private string marka;
        private string kalkis;
        private string varis;

        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }

        public string KALKIS
        {
            get { return kalkis; }
            set { kalkis = value.ToLower(); }
        }

        public string VARIS
        {
            get { return varis; }
            set { varis = value.ToUpper(); }
        }
    }
}
