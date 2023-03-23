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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HKL3D7O\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {

            //Şehirlere Göre Personel Grafiği
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count(*) From TBL_Personel Group By PerSehir", baglanti);
            SqlDataReader drg1 = komutg1.ExecuteReader();

            while (drg1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(drg1[0], drg1[1]);
            }

            baglanti.Close();




            //Mesleklere Göre Ortalama Maaş Grafiği
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerMeslek,avg(PerMaas) from TBL_Personel Group By PerMeslek", baglanti);
            SqlDataReader drg2 = komutg2.ExecuteReader();

            while (drg2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(drg2[0], drg2[1]);
            }

            baglanti.Close();
        }
    }
}
