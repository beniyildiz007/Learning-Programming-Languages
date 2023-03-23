using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Ucak_Bilet_Rezervasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Nereden: " + comboBox1.Text + " Nereye: " + comboBox2.Text + " Tarih: " + maskedTextBox1.Text + " Saat: " + maskedTextBox2.Text + " --- YOLCU BİLGİLERİ --- Ad Soyad: " + textBox1.Text + " TC: " + maskedTextBox4.Text + " Telefon: " + maskedTextBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kopru;
            kopru = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = kopru;
        }
    }
}
