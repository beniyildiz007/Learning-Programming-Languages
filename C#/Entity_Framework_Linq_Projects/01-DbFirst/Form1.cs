using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _04_Entitiy_Framework_Linq_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HKL3D7O\SQLEXPRESS;Initial Catalog=dbSinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from TBLDERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();
        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnNotListesi_Click(object sender, EventArgs e)
        {
            var query = from item in db.TBLNOTLAR
                        select new
                        {
                            item.NOTID,
                            item.TBLOGRENCI.AD,
                            item.TBLOGRENCI.SOYAD,
                            item.TBLDERSLER.DERSAD,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtOgrAd.Text != "" && txtSoyad.Text != "")
            {
                TBLOGRENCI t = new TBLOGRENCI();
                t.AD = txtOgrAd.Text;
                t.SOYAD = txtSoyad.Text;
                db.TBLOGRENCI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Öğrenci Listeye Eklenmiştir.");
            }
            else if (txtDerslerAd.Text != "")
            {
                TBLDERSLER d = new TBLDERSLER();
                d.DERSAD = txtDerslerAd.Text;
                db.TBLDERSLER.Add(d);
                db.SaveChanges();
                MessageBox.Show("Ders Listeye Eklenmiştir!");
            }
            else
            {
                MessageBox.Show("Beklemedeyiz.");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrID.Text);
            var x = db.TBLOGRENCI.Find(id);
            db.TBLOGRENCI.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Sistemden Silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrID.Text);
            var x = db.TBLOGRENCI.Find(id);
            x.AD = txtOgrAd.Text;
            x.SOYAD = txtSoyad.Text;
            x.FOTOGRAF = txtFotograf.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Başarıyla Güncellendi!");

        }

        private void btnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.NOTLISTESI();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLOGRENCI.Where(deger => deger.AD == txtOgrAd.Text | deger.SOYAD == txtSoyad.Text).ToList();
        }

        private void txtOgrAd_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtOgrAd.Text;
            var sorgu = from s in db.TBLOGRENCI
                        where s.AD.Contains(aranan)
                        select s;
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void btnLinqEntity_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                //ASC - Ascending Sıralama
                List<TBLOGRENCI> liste1 = db.TBLOGRENCI.OrderBy(p => p.AD).ToList();
                dataGridView1.DataSource = liste1;
            }
            else if (radioButton2.Checked == true)
            {
                //DESC - Descending Sıralama
                List<TBLOGRENCI> liste2 = db.TBLOGRENCI.OrderByDescending(p => p.AD).ToList();
                dataGridView1.DataSource = liste2;
            }
            else if (radioButton3.Checked == true)
            {
                List<TBLOGRENCI> liste3 = db.TBLOGRENCI.Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            else if (radioButton5.Checked == true)
            {
                List<TBLOGRENCI> liste5 = db.TBLOGRENCI.Where(p => p.AD.StartsWith("a")).ToList();
                dataGridView1.DataSource = liste5;
            }
            else if (radioButton4.Checked == true)
            {
                List<TBLOGRENCI> liste4 = db.TBLOGRENCI.Where(p => p.AD.EndsWith("a")).ToList();
                dataGridView1.DataSource = liste4;
            }
            else if (radioButton6.Checked == true)
            {
                int toplam = db.TBLOGRENCI.Count();
                MessageBox.Show("Toplam öğrenci sayısı: " + toplam.ToString(), "Toplam öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton7.Checked == true)
            {
                var toplam = db.TBLNOTLAR.Sum(p => p.SINAV1);
                MessageBox.Show("1. Sınavda alınan toplam puan: " + toplam.ToString(), "Sınav 1 Toplam Puan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton8.Checked == true)
            {
                var toplam = db.TBLNOTLAR.Average(p => p.SINAV1);
                MessageBox.Show("1. Sınavda alınan ortalama puan: " + toplam.ToString(), "Sınav 1 Ortalama Puan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton9.Checked == true)
            {
                var enyuksek = db.TBLNOTLAR.Max(p => p.SINAV1);
                MessageBox.Show("1. Sınavda alınan en yüksek puan: " + enyuksek.ToString(), "Sınav 1 En Yüksek Puan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton10.Checked == true)
            {
                var endusuk = db.TBLNOTLAR.Min(p => p.SINAV1);
                MessageBox.Show("1. Sınavda alınan en düşük puan: " + endusuk.ToString(), "Sınav 1 En Düşük Puan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSinavNotuGuncelle_Click(object sender, EventArgs e)
        {
            var sorgu = from d1 in db.TBLNOTLAR
                        join d2 in db.TBLOGRENCI
                        on d1.OGR equals d2.ID
                        //join d3 in db.TBLDERSLER
                        //on d1.DERS equals d3.DERSAD
                        select new
                        {
                            ÖĞRENCİ = d2.AD + " " + d2.SOYAD,
                            //DERS = d3.DERSAD,
                            SINAV1 = d1.SINAV1,
                            SINAV2 = d1.SINAV2,
                            SINAV3 = d1.SINAV3,
                            ORTALAMA = d1.ORTALAMA
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
