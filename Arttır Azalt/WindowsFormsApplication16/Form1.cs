using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        int toplam=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                toplam = toplam + 10;
                textBox1.Text = Convert.ToString(toplam);
            }
            else if (radioButton2.Checked)
            {
                toplam = toplam - 10;
                textBox1.Text = Convert.ToString(toplam);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                toplam = toplam + 20;
                textBox1.Text = Convert.ToString(toplam);
            }
             else if (radioButton2.Checked)
            {
                toplam = toplam - 20;
                textBox1.Text = Convert.ToString(toplam);
           }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                toplam = toplam + 30;
                textBox1.Text = Convert.ToString(toplam);
            }
             else if (radioButton2.Checked)
            {
                toplam = toplam - 30;
                textBox1.Text = Convert.ToString(toplam);
             }
           }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                toplam = toplam + 40;
                textBox1.Text = Convert.ToString(toplam);
            }
            else if (radioButton2.Checked)
            {
                toplam = toplam - 40;
                textBox1.Text = Convert.ToString(toplam);
            }
        }
    }
}
