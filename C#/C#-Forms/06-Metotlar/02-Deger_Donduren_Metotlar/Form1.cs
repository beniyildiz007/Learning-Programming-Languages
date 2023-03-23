using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Deger_Donduren_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int toplam(int s1, int s2)
        {
            int s3 = s1 + s2;
            return s3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = toplam(2, 4).ToString();
            label2.Text = toplam(6, 3).ToString();
            label3.Text = toplam(4, 7).ToString();
            label4.Text = toplam(9, 1).ToString();
        }
    }
}
