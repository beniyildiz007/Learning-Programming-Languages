﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Int_Degiskenler_Klavye_Veri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, kup;
            sayi = Convert.ToInt32(textBox1.Text);
            kup = sayi * sayi * sayi;
            label2.Text = kup.ToString();
        }
    }
}
