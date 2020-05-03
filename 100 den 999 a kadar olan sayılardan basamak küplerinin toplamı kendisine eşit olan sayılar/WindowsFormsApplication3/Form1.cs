using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int kupAl(int sayi)
        {
            return sayi * sayi * sayi;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 100; i <= 999; i++)
            {
                int yuzler = i % 100;
                yuzler = (i - yuzler) / 100;
                int birler = i % 10;
                int onlar = i % 100;
                onlar = onlar - birler;
                onlar = onlar / 10;




                int a = kupAl(yuzler);
                int b = kupAl(onlar);
                int c = kupAl(birler);
                int toplam = a + b + c;


                if(toplam==i)
                {
                    listBox1.Items.Add(i);
                }


            }
        }
    }
}
