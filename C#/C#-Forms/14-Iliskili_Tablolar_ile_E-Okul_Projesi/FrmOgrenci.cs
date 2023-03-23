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

namespace _06_Iliskili_Tablolar_ile_E_Okul_Projesi
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.DarkRed;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-HKL3D7O\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");

        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TBLKULUPLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKULUP.DisplayMember = "KULUPAD";
            cmbKULUP.ValueMember = "KULUPID";
            cmbKULUP.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSOYAD.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbKULUP.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()=="Erkek")
            {
                radioERKEK.Checked = true;
            }
            else
            {
                radioKIZ.Checked = true;
            }

        }
        string c = "";

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (radioERKEK.Checked = true)
            {
                c = "ERKEK";
            }
            if (radioKIZ.Checked = true)
            {
                c = "KIZ";
            }
            ds.OgrenciEkle(txtAD.Text, txtSOYAD.Text, byte.Parse(cmbKULUP.SelectedValue.ToString()), c);
            MessageBox.Show("Öğrenci Ekleme İşlemi Yapıldı!");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void cmbKULUP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtOgrenciID.Text));
            MessageBox.Show("Öğrenci Başarıyla SİLİNDİ!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.OgrenciGuncelle(txtAD.Text, txtSOYAD.Text, byte.Parse(cmbKULUP.SelectedValue.ToString()), c, int.Parse(txtOgrenciID.Text));
            MessageBox.Show("Güncelleme İşlemi Başarılı!");
        }

        private void radioKIZ_CheckedChanged(object sender, EventArgs e)
        {
            if (radioKIZ.Checked)
            {
                c = "KIZ";
            }
        }

        private void radioERKEK_CheckedChanged(object sender, EventArgs e)
        {
            if (radioERKEK.Checked)
            {
                c = "ERKEK";
            }
        }

        private void btnARA_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciGetir(txtARA.Text);
        }
    }
}
