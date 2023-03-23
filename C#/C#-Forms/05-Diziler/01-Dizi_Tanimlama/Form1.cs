using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Dizi_Tanimlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] isimler = { "Berkan", "Nihat", "Yıldız", "Ecmel", "Ecrin", "Mert" };
            int[] sayilar = { 4, 7, 2, 3, 5, 9, 4, 7, 5, 0, 2 };

            label1.Text = isimler[3];
            label2.Text = sayilar[7].ToString();
        }
    }
}
