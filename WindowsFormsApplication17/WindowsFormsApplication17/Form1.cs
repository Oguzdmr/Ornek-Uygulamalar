using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form

    {
        
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frm2 = new Form2();
 
        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            comboBox1.Items.Add("Bilgisayar Programcılığı");
            comboBox1.Items.Add("Bilgisayar İşletme");
            comboBox1.Items.Add("Bilgisayar Mühendisliği");
            comboBox1.Items.Add("Yazılım Uzmanlığı");
            comboBox1.Items.Add("Yazılım Mühendisliği");

            comboBox2.Items.Add("C#");
            comboBox2.Items.Add("Java");
            comboBox2.Items.Add("Ruby");
            comboBox2.Items.Add("MobilProgramlama");
            comboBox2.Items.Add("Algoritmalar");

          
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            frm2.listBox1.Items.Add(textBox1.Text);
            frm2.listBox2.Items.Add(textBox2.Text);
            frm2.listBox3.Items.Add(comboBox1.SelectedItem);
            frm2.listBox4.Items.Add(comboBox2.SelectedItem);


            if (radioButton1.Checked==true)
            {
                frm2.listBox5.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked==true)
            {
                frm2.listBox5.Items.Add(radioButton2.Text);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            frm2.Show();
            this.Hide();
        }
    }
}
