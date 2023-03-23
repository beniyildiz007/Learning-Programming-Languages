using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Double_Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            s1 = 60;
            s2 = 50;
            s3 = 78;
            ort = (s1 + s2 + s3) / 3;
            label1.Text = ort.ToString("0.00"); //.ToString içerisine yazdığımız sıfırlar, sonucun nasıl bir formatta yazılması gerektiğini belirler
        }
    }
}
