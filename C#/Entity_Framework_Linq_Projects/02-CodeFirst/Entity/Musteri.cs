using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst.Entity
{
    public class Musteri
    {
        [Key]
        public int MUSTERIID { get; set; }

        public string MUSTERIAD { get; set; }

        public string MUSTERIUNVAN { get; set; }

        public string MUSTERISEHIR { get; set; }
    }
}
