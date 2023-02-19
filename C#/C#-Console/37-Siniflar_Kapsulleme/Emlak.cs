using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_Siniflar_Kapsulleme
{
    class Emlak
    {

        private string semt;
        private string renk;
        private int odasayisi;
        private int katnumara;
        private double alan;

        public string SEMT
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
        }
        
        public string RENK
        {
            get { return renk; }
            set { renk = value.ToLower(); }
        }

        public int ODASAYISI
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); }
        }

        public int KATNUMARA
        {
            get { return katnumara; }
            set { katnumara = Math.Abs(value); }
        }

        public double ALAN
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }
}
