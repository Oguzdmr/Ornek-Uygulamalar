using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        ArrayList eleman = new ArrayList();
        string[] dizi = new string[20];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 5; i++)
            {
                dizi[i] = textBox1.Text;
                listBox1.Items.Add(dizi[i]);
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
