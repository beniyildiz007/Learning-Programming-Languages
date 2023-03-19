using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _07_Ingılızce_Kelime_Ogren_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbSozluk.accdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;

        void getir()
        {
            int sayi;
            sayi = rast.Next(1, 2490);

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from sozluk where id=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtIngilizce.Text = dr[1].ToString();
                lblDogru.Text = dr[2].ToString();
                lblDogru.Text = lblDogru.Text.ToLower();
            }
            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getir();
            txtTurkce.Focus();
            timer1.Start();
        }

        private void txtTurkce_TextChanged(object sender, EventArgs e)
        {
            if (txtTurkce.Text == lblDogru.Text)
            {
                kelime++;
                lblKelime.Text = kelime.ToString();
                getir();
                txtTurkce.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                txtTurkce.Enabled = false;
                txtIngilizce.Enabled = false;
                timer1.Stop();
            }
        }
    }
}
