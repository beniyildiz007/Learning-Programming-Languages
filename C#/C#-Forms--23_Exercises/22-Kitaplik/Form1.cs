using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_Kitaplik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        KitapVT vtsinif = new KitapVT();

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vtsinif.Liste();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kitap ktpsinif = new Kitap();
            ktpsinif.ADI = txtKitapAdi.Text;
            ktpsinif.YAZARI = txtYazar.Text;

            vtsinif.KitapEkle(ktpsinif);

            MessageBox.Show("Kitap Eklendi");

            dataGridView1.DataSource = vtsinif.Liste();

        }
    }
}
