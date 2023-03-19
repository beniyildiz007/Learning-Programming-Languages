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

namespace _17_Yolcu_Bilet_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HKL3D7O\SQLEXPRESS;Initial Catalog=dbYolcuBilet;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLYOLCUBILGI (AD,SOYAD,TELEFON,TC,CINSIYET,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtYolcuAd.Text);
            komut.Parameters.AddWithValue("@p2", txtYolcuSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskYolcuTelefon.Text);
            komut.Parameters.AddWithValue("@p4", mskYolcuTC.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", txtYolcuMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yolcu Bilgisi Sisteme Kaydedildi!");
        }

        private void btnKaptan_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKAPTAN (KAPTANNO,ADSOYAD,TELEFON) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKaptanNo.Text);
            komut.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskKaptanTelefon.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaptan Bilgisi Sisteme Kaydedildi!");
        }

        private void btnSeferOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLSEFERBILGI (KALKIS,VARIS,TARIH,SAAT,KAPTAN,FIYAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKalkis.Text);
            komut.Parameters.AddWithValue("@p2", txtVaris.Text);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", mskKaptan.Text);
            komut.Parameters.AddWithValue("@p6", txtFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sefer Bilgisi Sisteme Kaydedildi!");
            seferlistesi();
        }

        void seferlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLSEFERBILGI", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferlistesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtRezNo.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "9";

        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {

        }
    }
}
