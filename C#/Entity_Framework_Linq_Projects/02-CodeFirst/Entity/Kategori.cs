﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CodeFirst.Entity
{
    public class Kategori
    {
        [Key]
        public int KATEGORIID { get; set; }

        public string KATEGORIADI { get; set; }
        public ICollection<Urunler> Urunlers { get; set; }
    }
}
