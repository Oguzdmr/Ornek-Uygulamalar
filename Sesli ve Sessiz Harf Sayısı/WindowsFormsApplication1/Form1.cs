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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] dizi = new char[textBox1.Text.Length];
            char[] sesliHarf = {'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            int i, j, sesliSayi = 0, SessizSayi = 0, bosluksayi=0;
            char[] bosluk={' '};

            for (i = 0; i < textBox1.Text.Length; i++)
            {
                dizi[i] = textBox1.Text[i];
                for (j = 0; j <= 7; j++)
                {
                   if(dizi[i]==sesliHarf[j])
                    {
                        sesliSayi++;
                    }
                  
                    
                }
                if (dizi[i] == bosluk[0])
                {
                    bosluksayi++;
                }
                SessizSayi = (textBox1.Text.Length - sesliSayi-bosluksayi);
            }
            

            textBox2.Text = Convert.ToString(sesliSayi);
            textBox3.Text = Convert.ToString(SessizSayi);
            textBox4.Text = Convert.ToString(bosluksayi);

        }
    }
}
