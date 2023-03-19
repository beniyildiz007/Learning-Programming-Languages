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

namespace _13_Veritabani_Verilerini_Sifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HKL3D7O\SQLEXPRESS;Initial Catalog=DbHesapBilgileri;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLVERILER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string adsifre = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(txtAd.Text));
            string soyadsifre = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(txtSoyad.Text));
            string mailsifre = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(txtMail.Text));
            string sifre = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(txtSifre.Text));
            string hesapnosifre = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(txtHesapno.Text));

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLVERILER (AD,SOYAD,MAIL,SIFRE,HESAPNO) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", mailsifre);
            komut.Parameters.AddWithValue("@p4", sifre);
            komut.Parameters.AddWithValue("@p5", hesapnosifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Verileriniz Şifreli Şekilde Eklendi!");

            listele();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
