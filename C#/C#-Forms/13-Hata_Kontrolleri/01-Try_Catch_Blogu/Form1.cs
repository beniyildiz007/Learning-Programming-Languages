using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Try_Catch_Blogu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                int s1 = Convert.ToInt32(textBox1.Text);
                int s2 = Convert.ToInt32(textBox2.Text);
                int toplam = s1 + s2;
                MessageBox.Show(toplam.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen değerlerinizi kontrol ediniz!");
            }
            */



            /*
            //Exception kontrolü
            try
            {
                int s1 = Convert.ToInt32(textBox1.Text);
                int s2 = Convert.ToInt32(textBox2.Text);
                int toplam = s1 + s2;
                MessageBox.Show(toplam.ToString());
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            */




            //Finally bloğu kontrolü
            //Eğer hata yoksa try+finally çalışır, hata varsa catch+finally çalışır.
            try
            {
                int s1 = Convert.ToInt32(textBox1.Text);
                int s2 = Convert.ToInt32(textBox2.Text);
                int toplam = s1 + s2;
                MessageBox.Show(toplam.ToString());
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
            finally
            {
                MessageBox.Show("Finally Bloğu Çalıştı");
            }


        }
    }
}
