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
        Random rastgele = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, max=0, min=500; 
            int[] dizi = new int[100];
            
            for(i=0;i<100;i++){

            
            int sayi = rastgele.Next(1, 500);
            dizi[i] = sayi;
            listBox1.Items.Add(">>" + sayi);

           
            }
            
            for (int j = 0; j < 100; j++)
            {
                if (dizi[j] > max)
                {
                    max = dizi[j];
                }
                if (dizi[j] < min)
                {
                    min = dizi[j];
                }
                textBox1.Text = Convert.ToString(max);
                textBox2.Text = Convert.ToString(min);
        
            }
            
            for (i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (dizi[i] < dizi[j])
                    {
                        int degisken = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = degisken;
                    }
                }
                
            }

            for (i = 0; i < 100; i++)
            {
                listBox2.Items.Add(dizi[i]);
            }
           
            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
