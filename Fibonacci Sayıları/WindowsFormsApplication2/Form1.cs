using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1=1;
            int sayi2=1;
            int toplam = 0;
            listBox1.Items.Add("> " + sayi1);
            listBox1.Items.Add("> " + sayi2);
            for (int i = 1; i <= 100; i++)
            {
                toplam = sayi1 + sayi2;
                sayi1 = sayi2;
                sayi2 = toplam;
                listBox1.Items.Add("> " +toplam);
            }
            
        }
    }
}
