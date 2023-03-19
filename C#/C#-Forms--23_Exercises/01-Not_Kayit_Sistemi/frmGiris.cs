using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Not_Kayit_Sistemi
{
    public partial class frmOgrenciGiris : Form
    {
        public frmOgrenciGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmOgrenciDetay fr = new frmOgrenciDetay();
            fr.numara = maskedTextBox1.Text;
            fr.Show();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "1111")
            {
                frmOgretmenDetay fr = new frmOgretmenDetay();
                fr.Show();
            }
        }

        private void frmOgrenciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
