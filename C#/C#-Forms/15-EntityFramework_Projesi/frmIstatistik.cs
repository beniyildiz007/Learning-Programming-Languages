using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_EntityFramework_Projesi
{
    public partial class frmIstatistik : Form
    {
        public frmIstatistik()
        {
            InitializeComponent();
        }

        DBEntityUrunEntities db = new DBEntityUrunEntities();

        private void frmIstatistik_Load(object sender, EventArgs e)
        {
            lblToplamKategori.Text = db.TBLKATEGORI.Count().ToString();
            lblToplamUrun.Text = db.TBLURUN.Count().ToString();
            lblAktifMusteri.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            lblPasifMusteri.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            lblToplamStok.Text = db.TBLURUN.Sum(y => y.STOK).ToString();
            lblKasadakiTutar.Text = db.TBLSATIS.Sum(z => z.FIYAT).ToString()+" TL";
            lblEnYuksekFiyat.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            lblEnDusukFiyat.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            lblBeyazEsya.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            lblSehirSayisi.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();
            lblEnFazlaUrunluMarka.Text = db.MARKAGETIR().FirstOrDefault();
        }
    }
}
