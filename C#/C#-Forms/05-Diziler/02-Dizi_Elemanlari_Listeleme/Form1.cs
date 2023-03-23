using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Dizi_Elemanlari_Listeleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Antalya", "Adana", "Ankara", "İstanbul", "İzmir", "Gaziantep", "Kahramanmaraş", "Bursa" };
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (sehirler[i] != "İzmir")
                {
                    listBox1.Items.Add(sehirler[i]); //İzmir dışındaki bütün şehirleri listbox1 listesine ekledik
                }
            }
        }
    }
}
