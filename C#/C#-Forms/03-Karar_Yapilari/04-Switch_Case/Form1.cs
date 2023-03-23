using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mevsim = textBox1.Text;
            switch (mevsim)
            {
                case "sonbahar":
                    label2.Text = "Eylül - Ekim - Kasım";
                    break;
                case "kış":
                    label2.Text = "Aralık - Ocak - Şubat";
                    break;
                case "ilkbahar":
                    label2.Text = "Mart - Nisan - Mayıs";
                    break;
                case "yaz":
                    label2.Text = "Haziran - Temmuz - Ağustos";
                    break;
                default:
                    label2.Text = "Hatalı mevsim adı girdiniz!";
                    break;

            }
        }
    }
}
