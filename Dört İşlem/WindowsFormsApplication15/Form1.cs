using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtsayi1.Text);
            int sayi2 = Convert.ToInt32(txtsayi2.Text);
            if (rdbtoplama.Checked)
            {
                
               string sonuc = Convert.ToString(sayi1+sayi2);
                MessageBox.Show(sonuc);
            }
            else if (rdbcarpma.Checked)
            {
                
                string sonuc = Convert.ToString(sayi1*sayi2);
                MessageBox.Show(sonuc);
            }
            else if (rdbcıkarma.Checked)
            {
                string sonuc = Convert.ToString(sayi1 - sayi2);
                MessageBox.Show(sonuc);
            }
            else if (rdbbölme.Checked)
            {
                string sonuc = Convert.ToString(sayi1 / sayi2);
                MessageBox.Show(sonuc);
            }
        }

        private void txtsayi1_KeyDown(object sender, KeyEventArgs e)
        {  /*
            if (e.KeyValue < 48 || e.KeyValue > 57)
            {
                e.Handled = false;
            }
           */


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 10)
            {
                this.BackColor = Color.DarkBlue;
            }
            if (trackBar1.Value == 20)
            {
                this.BackColor = Color.DarkGray;
            }
            if (trackBar1.Value == 30)
            {
                this.BackColor = Color.DarkGreen;
            }
            if (trackBar1.Value == 40)
            {
                this.BackColor = Color.DarkMagenta;
            }
            if (trackBar1.Value == 50)
            {
                this.BackColor = Color.DarkRed;
            }
        }

        private void txtsayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToByte(e.KeyChar) < 48 || Convert.ToByte(e.KeyChar) > 57)
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 50;
            trackBar1.Minimum = 5;

        }
    }
}
