using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Sinema_Bufe_Satis_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasa = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir = Convert.ToInt32(txtMisir.Text);
            int su = Convert.ToInt32(txtSu.Text);
            int cay = Convert.ToInt32(txtCay.Text);
            int bilet = Convert.ToInt32(txtBilet.Text);
            int toplam = (misir * 30) + (su * 5) + (cay * 10) + (bilet * 40);

            lblToplam.Text = toplam+" TL";

            kasa += toplam;

            lblKasa.Text = kasa+" TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = "";
            txtCay.Text = "";
            txtMisir.Text = "";
            txtSu.Text = "";
            lblToplam.Text = "00 TL";
            lblKasa.Text = "00 TL";
            txtMisir.Focus(); // Temizleme butonuna bastıktan sonra cursor direkt olarak mısır textbox'unda başlayacak
        }
    }
}
