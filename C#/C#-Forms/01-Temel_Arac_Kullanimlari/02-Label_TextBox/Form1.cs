using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Label_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Butona tıklandığında belirlediğimiz label'lara belirlediğimiz değerler getirilecek
            label4.Text = "Berkan Nihat";
            label5.Text = "Yıldız";
            label6.Text = "Software Developer";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Butona tıkladığımızda textbox1 içerisindeki bilgiler label8 içerisine aktarılacak
            label8.Text = textBox1.Text;
        }
    }
}
