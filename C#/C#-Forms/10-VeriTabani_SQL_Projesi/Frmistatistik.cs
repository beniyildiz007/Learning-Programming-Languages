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

namespace _10_VeriTabani_SQL_Projesi
{
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HKL3D7O\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void Frmistatistik_Load(object sender, EventArgs e)
        {

            //Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select Count(*) From TBL_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                lblToplamPrs.Text = dr1[0].ToString();
            }

            baglanti.Close();


            //Evli Personel Sayısı
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) From TBL_Personel where PerDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                lblEvliPrs.Text = dr2[0].ToString();
            }

            baglanti.Close();



            //Bekar Personel Sayısı
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select Count(*) From TBL_Personel where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                lblBekarPrs.Text = dr3[0].ToString();
            }
            
            baglanti.Close();



            //Şehir Sayısı
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From TBL_Personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                lblSehir.Text = dr4[0].ToString();
            }

            baglanti.Close();



            //Toplam Maaş
            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("Select sum(PerMaas) from TBL_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();

            while (dr5.Read())
            {
                lblToplamMaas.Text = dr5[0].ToString()+" TL";
            }

            baglanti.Close();



            //Ortalama Maaş
            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("Select avg(PerMaas) From TBL_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();

            while (dr6.Read())
            {
                lblOrtMaas.Text = dr6[0] + " TL";
            }

            baglanti.Close();

        }
    }
}
