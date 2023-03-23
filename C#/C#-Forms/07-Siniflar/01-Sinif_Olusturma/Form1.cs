using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Sinif_Olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba car = new Araba();

            car.renk = "Mavi";
            car.hiz = 160;
            car.motor = 1245.45;
            car.fiyat = 400000;
            car.durum = 's';
            car.YIL = -2023;
            car.MARKA = "Golf";
            car.muayene = 2017;
            car.plaka = "07 BYS 1995";
            car.sahip = "Berkan Nihat Yıldız";

            label1.Text = car.renk;
            label2.Text = car.hiz.ToString();
            label3.Text = car.motor.ToString();
            label4.Text = car.fiyat.ToString();
            label5.Text = car.durum.ToString();
            label6.Text = car.YIL.ToString();
            label7.Text = car.MARKA.ToString();
            label8.Text = car.muayene.ToString();
            label9.Text = car.plaka;
            label10.Text = car.sahip;
        }
    }
}
