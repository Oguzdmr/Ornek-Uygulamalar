using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int i = 0;
        int[] sayilar = new int[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int sayi = Convert.ToInt32(textBox1.Text);
            sayilar[i] = sayi;
         
            listBox1.Items.Add(sayilar[i]);
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int degis = 0;
            for (int j = 0; j < 4; j++)
            {
                if (sayilar[j] >= sayilar[j + 1])
                {
                    degis = sayilar[j];
                    sayilar[j] = sayilar[j + 1];
                    sayilar[j + 1] = degis;

                }

            }

            textBox2.Text = Convert.ToString(sayilar[3]);
        }
    }
}
