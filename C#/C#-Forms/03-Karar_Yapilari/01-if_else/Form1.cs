using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_if_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (sayi%2==0 || sayi >= 10)
            {
                label1.Text = "Sayı 10'dan büyük ya da çift";
            }
            else
            {
                label1.Text = "Sayı 10'dan büyük değil ya da çift değil";
            }
        }
    }
}
