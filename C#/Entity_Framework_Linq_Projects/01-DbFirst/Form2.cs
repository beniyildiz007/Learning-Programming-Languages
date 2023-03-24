using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Entitiy_Framework_Linq_Projesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var degerler = db.TBLNOTLAR.Where(x => x.SINAV1 < 50);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton2.Checked)
            {
                var degerler = db.TBLOGRENCI.Where(x => x.AD == "ALİ");
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton3.Checked)
            {
                var degerler = db.TBLOGRENCI.Select(x => new { Soyadı = x.SOYAD });
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton4.Checked)
            {
                var degerler = db.TBLOGRENCI.Select(x => new { Adı = x.AD.ToUpper(), Soyadı = x.SOYAD.ToLower() });
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton5.Checked)
            {
                var degerler = db.TBLNOTLAR.Select(x =>
                new
                {
                    OgrenciAd = x.OGR,
                    Ortalamasi = x.ORTALAMA,
                    Durumu = x.DURUM == true ? "Geçti" : "Kaldı"
                });
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton6.Checked)
            {
                var degerler = db.TBLNOTLAR.SelectMany(x =>
                db.TBLOGRENCI.Where(y => y.ID == x.OGR),
                    (x, y) => new { y.AD, x.ORTALAMA });
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton7.Checked)
            {
                var degerler = db.TBLOGRENCI.OrderBy(x => x.ID).Take(3);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton8.Checked)
            {
                var degerler = db.TBLOGRENCI.OrderByDescending(x => x.ID).Take(3);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton9.Checked)
            {
                var degerler = db.TBLOGRENCI.OrderBy(x => x.AD);
                dataGridView1.DataSource = degerler.ToList();
            }
            if (radioButton10.Checked)
            {
                var degerler = db.TBLOGRENCI.OrderBy(x => x.ID).Skip(5);
                dataGridView1.DataSource = degerler.ToList();
            }

        }
    }
}
