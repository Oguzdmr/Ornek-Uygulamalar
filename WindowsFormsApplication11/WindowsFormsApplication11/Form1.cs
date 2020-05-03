using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Çankaya");
            comboBox1.Items.Add("Altındağ");
            comboBox1.Items.Add("Yenimahalle");
            comboBox1.Items.Add("Keçiören");
            comboBox1.Text = "Ankara";

            groupBox1.Enabled = false;
            buttonListe.Enabled = false;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            TCNo = textBoxTCNo.Text.ToString();
            Adsoyad = textBoxAD.Text.ToString();
            Telno = textBoxTel.Text.ToString();
            Adres = richTextBoxAdress.ToString();
            if (radioButton1.Checked == true)
            {
                cinsiyet = "Erkek";
            }
            else
            {
                cinsiyet = "Kadın";
            }
            Semt = comboBox1.Text.ToString();
            buttonListe.Enabled = true;
        }

        private void buttonListe_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxAD.Text = "";
            textBoxTCNo.Text = "";
            textBoxTel.Text = "";
            richTextBoxAdress.Text = "";
            comboBox1.Text = "";

        }
    }
}
