using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _22_Kitaplik
{
    class KitapVT
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\nihat\OneDrive\Belgeler\GitHub\Learning-Programming-Languages\C#\C#-Forms\01-murat_yucedag\12-Access_Veri_Tabani\Kitaplik.mdb");

        public List<Kitap> Liste()
        {
            List<Kitap> ktp = new List<Kitap>();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Kitaplar", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.ID = Convert.ToInt32(dr[0].ToString());
                k.ADI = dr[1].ToString();
                k.YAZARI = dr[2].ToString();

                ktp.Add(k);
            }
            baglanti.Close();

            return ktp;
        }

        public void KitapEkle(Kitap kt)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,Yazar) values (@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", kt.ADI);
            komut.Parameters.AddWithValue("@p2", kt.YAZARI);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
