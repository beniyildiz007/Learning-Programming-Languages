using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Int_Degisken_Pratikler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, toplam, carpim, fark, bolum;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            toplam = s1 + s2;
            carpim = s1 * s2;
            fark = s1 - s2;
            bolum = s1 / s2;

            MessageBox.Show("Toplam: " + toplam + "\nFark: " + fark + "\nÇarpım: " + carpim + "\nBölüm: " + bolum);
        }
    }
}
