using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Random rdm = new Random();
        int sayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayi = rdm.Next(100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi2 = Convert.ToInt32(textBox1.Text);
            if (sayi2 == sayi)
            {
                MessageBox.Show("Tebrikler Tahmin Başarlı");

            }
            else if (sayi2 < sayi)
            {
                MessageBox.Show("Tahmininizi Yükseltin");
            }
            else if (sayi2 > sayi)
            {
                MessageBox.Show("Tahmininizi Küçültün");
            }
        }
    }
}
