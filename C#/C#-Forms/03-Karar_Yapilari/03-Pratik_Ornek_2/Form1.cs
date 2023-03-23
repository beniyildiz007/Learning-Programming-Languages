using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Pratik_Ornek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Müşterinin aldığı kitap miktarına göre fiyat hesaplatan uygulama
            // 0-20 Kitap arasına => %20 indirim
            // 21-40 Kitap arasına => %40 indirim
            // 41++ Kitaba => %50 indirim

            int kitapadet;
            double toplam;
            kitapadet = Convert.ToInt32(textBox1.Text);
            if(kitapadet>=0 && kitapadet <= 20)
            {
                toplam = (kitapadet * 60) - (kitapadet * 60 * 0.20);
                label1.Text = toplam + " TL";
            }
            else if(kitapadet>=21 && kitapadet <= 40)
            {
                toplam = (kitapadet * 60) - (kitapadet * 60 * 0.40);
                label1.Text = toplam + " TL";
            }
            else
            {
                toplam = (kitapadet * 60) - (kitapadet * 60 * 0.50);
                label1.Text = toplam + " TL";
            }
        }
    }
}
