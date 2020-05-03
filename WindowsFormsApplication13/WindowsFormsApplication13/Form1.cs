using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }
    
    
        public static string secilen;
        Form2 frm2 = new Form2();
        
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            secilen = "Team Viewer";
            frm2.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            secilen = "WAMP";
            frm2.Show();
            this.Hide();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            secilen = "AIMP";
            frm2.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            secilen = "QBittorent";
            frm2.Show();
            this.Hide();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            secilen = "SM Player";
            frm2.Show();
            this.Hide();
        }

      
       

      
        
    }
}
