using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //SQL Komutlarını kullanmak için gerekli olan kütüphane

namespace _10_VeriTabani_SQL_Projesi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HKL3D7O\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        void temizle()
        {
            txtAd.Text = "";
            txtID.Text = "";
            txtMeslek.Text = "";
            txtSoyad.Text = "";
            cmbSehir.Text = "";
            mskMaas.Text = "";
            rdbBekar.Checked = false;
            rdbEvli.Checked = false;
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet.TBL_Personel' table. You can move, or remove it, as needed.
            this.tBL_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.TBL_Personel);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tBL_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.TBL_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into TBL_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Personel Bilgileri Eklendi!");
        }

        private void rdbEvli_CheckedChanged(object sender, EventArgs e)
        {
            if(label8.Text == "True")
            {
                rdbEvli.Checked = true;
            }
        }

        private void rdbBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (label8.Text == "False")
            {
                rdbBekar.Checked = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                rdbEvli.Checked = true;
            }
            if (label8.Text == "False")
            {
                rdbBekar.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutsil = new SqlCommand("Delete From TBL_Personel where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", txtID.Text);
            komutsil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt Silme İşlemi Başarıyla Tamamlandı!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutguncelle = new SqlCommand("Update TBL_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@a2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", cmbSehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", mskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", txtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", txtID.Text);
            komutguncelle.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Bilgiler Başarıyla Güncellendi!");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frg = new FrmGrafikler();
            frg.Show();
        }
    }
}
