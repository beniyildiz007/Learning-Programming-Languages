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

namespace _18_Benzin_Istasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HKL3D7O\SQLEXPRESS;Initial Catalog=dbBenzin;Integrated Security=True");

        void listele()
        {
            //Kurşunsuz95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLBENZIN where petroltur='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblKur95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                lblKur95Litre.Text = dr[4].ToString();
            }
            baglanti.Close();


            //Kurşunsuz97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBLBENZIN where petroltur='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblKur97.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                lblKur97Litre.Text = dr2[4].ToString();

            }
            baglanti.Close();


            //Euro Dizel 10
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBLBENZIN where petroltur='EuroDizel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblEuro10.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                lblEuroLitre.Text = dr3[4].ToString();

            }
            baglanti.Close();


            //Yeni Pro Dizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from TBLBENZIN where petroltur='YeniProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblPro.Text = dr4[3].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                lblProLitre.Text = dr4[4].ToString();

            }
            baglanti.Close();




            //Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from TBLBENZIN where petroltur='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblGaz.Text = dr5[3].ToString();
                progressBar5.Value = int.Parse(dr5[4].ToString());
                lblGazLitre.Text = dr5[4].ToString();

            }
            baglanti.Close();



            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from tblkasa", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95 = Convert.ToDouble(lblKur95.Text);
            double litre = Convert.ToDouble(numericUpDown2.Value);
            double tutar = kursunsuz95 * litre;
            txtKur95Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97 = Convert.ToDouble(lblKur97.Text);
            double litre = Convert.ToDouble(numericUpDown3.Value);
            double tutar = kursunsuz97 * litre;
            txtKur97Fiyat.Text = tutar.ToString();

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double euro = Convert.ToDouble(lblEuro10.Text);
            double litre = Convert.ToDouble(numericUpDown5.Value);
            double tutar = euro * litre;
            txtEuroFiyat.Text = tutar.ToString();

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double pro = Convert.ToDouble(lblPro.Text);
            double litre = Convert.ToDouble(numericUpDown4.Value);
            double tutar = pro * litre;
            txtProFiyat.Text = tutar.ToString();

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            double gaz = Convert.ToDouble(lblGaz.Text);
            double litre = Convert.ToDouble(numericUpDown6.Value);
            double tutar = gaz * litre;
            txtGazFiyat.Text = tutar.ToString();

        }

        private void btnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kurşunsuz 95");
                komut.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txtKur95Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı!");


                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR+=@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", decimal.Parse(txtKur95Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();


                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok-=@p1 where petroltur='kurşunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown2.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                listele();
            }
        }
    }
}
