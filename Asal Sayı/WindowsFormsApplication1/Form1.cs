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

            int i;
            for (i = 0; i <= 100; i++)
            {
                int j;
                int a=0;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        a = 1;
                        break;
                    }
                }
                if (a == 1)
                {
                    listBox1.Items.Add(i + " Asal Değil");
                }
                else
                {
                    listBox1.Items.Add(i + " Asal");
                }
            }
        }
    }
}
