using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_EntityFramework_Projesi
{
    public partial class frmAnaForm : Form
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUrun fr = new frmUrun();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmIstatistik fr = new frmIstatistik();
            fr.Show();
        }
    }
}
