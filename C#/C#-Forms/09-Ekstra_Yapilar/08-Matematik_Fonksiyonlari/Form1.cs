using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Matematik_Fonksiyonlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(textBox1.Text);
            //label1.Text = Math.Abs(sayi).ToString(); //Mutlak Değer
            //label1.Text = Math.Ceiling(sayi).ToString(); //Yukarı yuvarlama
            //label1.Text = Math.Floor(sayi).ToString(); //Aşağı Yuvarlama
            //label1.Text = Math.Pow(sayi, 3).ToString(); //Sayının kuvvetini alma
            label1.Text = Math.Sqrt(sayi).ToString(); //Sayının karekökünü alma

        }
    }
}
