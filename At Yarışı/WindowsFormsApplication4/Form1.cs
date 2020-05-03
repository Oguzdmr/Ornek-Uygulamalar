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
        int x = 5, y = 5;
        Random a = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
                       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += a.Next(5,15);
            if (pictureBox1.Width+ pictureBox1.Left >= label5.Left)
            {
                timer1.Enabled = false;
            }
            timer1.Interval = a.Next(1, 70);

            pictureBox2.Left += a.Next(5,15);
            if (pictureBox2.Width + pictureBox2.Left >= label5.Left)
            {
                timer1.Enabled = false;
            }
            
            pictureBox3.Left += a.Next(5,15);
            if (pictureBox3.Width + pictureBox3.Left >= label5.Left)
            {
                timer1.Enabled = false;
            }

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Birinci At Öne Geçti";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "İkinci At Öne Geçti";
            }

            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "Üçüncü At Öne Geçti";
            }


            if (pictureBox1.Width + pictureBox1.Left >= label5.Left)
            {
               label6.Text=" ! Yarışı Birinci At Kazandı...";
            }


              if (pictureBox2.Width + pictureBox2.Left >= label5.Left)
            {
               label6.Text=" ! Yarışı İkinci At Kazandı...";
            }

              if (pictureBox3.Width + pictureBox3.Left >= label5.Left)
            {
                label6.Text = " ! Yarışı Üçüncü At Kazandı...";
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
            label6.Text = "";
        }

      
    }
}
