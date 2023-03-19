using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Combobox_Listbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Butona basıldığında Combobox'a Antalya şehrini ekledik
            comboBox1.Items.Add("Antalya");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Butona basıldığında Textbox1'deki yazıyı Combobox'a ekler
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Butona tıkladığımızda listbox1'e 4 tane meslek ekler
            listBox1.Items.Add("Kasiyer");
            listBox1.Items.Add("Futbolcu");
            listBox1.Items.Add("Muhasebeci");
            listBox1.Items.Add("Antrenör");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Butona tıkladığımızda textbox2 içerisindeki yazıyı listbox1'e ekler
            listBox1.Items.Add(textBox2.Text);
        }
    }
}
