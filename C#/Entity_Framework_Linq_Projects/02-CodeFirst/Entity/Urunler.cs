using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst.Entity
{
    public class Urunler
    {
        [Key]
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public string URUNMARKA { get; set; }
        public string URUNKATEGORI { get; set; }
        public int URUNSTOK { get; set; }
        //public string ACIKLAMA { get; set; }
        public Kategori Kategori { get; set; }
    }
}
