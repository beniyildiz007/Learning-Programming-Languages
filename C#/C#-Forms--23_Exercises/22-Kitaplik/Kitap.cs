using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Kitaplik
{
    class Kitap
    {
        int id;
        string ad;
        string yazar;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string ADI
        {
            get { return ad; }
            set { ad = value; }
        }

        public string YAZARI
        {
            get { return yazar; }
            set { yazar = value; }
        }
    }
}
