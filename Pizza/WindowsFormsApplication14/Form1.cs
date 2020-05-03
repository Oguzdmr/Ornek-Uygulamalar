using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(richTextBox1.Text);
            listBox4.Items.Add(comboBox1.Text + " " + numericUpDown1.Value);
            listBox6.Items.Add(comboBox2.Text + " " + numericUpDown2.Value);

            string tik = "";
            if (checkBox1.Checked) tik += "sucuk";
            if (checkBox2.Checked) tik += "sosis";
            if (checkBox3.Checked) tik += "mantar";
            if (checkBox4.Checked) tik += "kaşar";
            if (checkBox5.Checked) tik += "peynir";
            if (checkBox6.Checked) tik += "sebze";
            listBox5.Items.Add(tik);


            int toplam = 0;
            int Bpizza=10,Opizza=7,Kpizza=5,Ayran=2,Kola=3,İcetea=2,Padet,Iadet;
            Padet = Convert.ToInt32(numericUpDown1.Value);
            Iadet = Convert.ToInt32(numericUpDown2.Value);
            if (comboBox1.Text == "Büyük") toplam += Bpizza * Padet;
            if (comboBox1.Text == "Orta") toplam += Opizza * Padet;
            if (comboBox1.Text == "Küçük") toplam += Kpizza * Padet;
            if (comboBox2.Text == "Kola") toplam += Kola * Iadet;
            if (comboBox2.Text == "Ayran") toplam += Ayran * Iadet;
            if (comboBox2.Text == "İcetea") toplam += İcetea * Iadet;
            if (checkBox1.Checked) toplam += +1;
            if (checkBox2.Checked) toplam += +1;
            if (checkBox3.Checked) toplam += +1;
            if (checkBox4.Checked) toplam += +1;
            if (checkBox5.Checked) toplam += +1;
            if (checkBox6.Checked) toplam += +1;
            listBox7.Items.Add(toplam);
        }
          


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            richTextBox1.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToByte(e.KeyChar) < 65 || Convert.ToByte(e.KeyChar) > 91 && Convert.ToByte(e.KeyChar) < 97 || Convert.ToByte(e.KeyChar) > 122 )
            {
                e.Handled =true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToByte(e.KeyChar) < 48 || Convert.ToByte(e.KeyChar) > 57)
            {
                e.Handled = true;
            }
        }

    
           
     
    }
}
