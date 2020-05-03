using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=0ĞUZ\\SQLEXPRESS;Initial Catalog=Kitaplık;Integrated Security=True");
        private void verileriGöster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Bilgiler",baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle= new ListViewItem();
                ekle.Text = oku["Sira"].ToString();
                ekle.SubItems.Add(oku["Kitap"].ToString());
                ekle.SubItems.Add(oku["Yazar"].ToString());
                ekle.SubItems.Add(oku["Yayınevi"].ToString());
                ekle.SubItems.Add(oku["Sayfa"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void Kaydet()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into Bilgiler (Sira,Kitap,Yazar,Yayınevi,Sayfa) Values('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString() + "','" + textBox5.Text.ToString() + "') ", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void silme()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from Bilgiler where Sira= (" + Sira + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void düzeltme()
        {

            baglan.Open();
            SqlCommand komut = new SqlCommand("Update Bilgiler set Sira='" + textBox1.Text.ToString() + "',Kitap='" + textBox2.Text.ToString() + "',Yazar='" + textBox3.Text.ToString() + "',Yayınevi='" + textBox4.Text.ToString() + "',Sayfa='" + textBox5.Text.ToString() + "'where Sira=" + Sira + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
           
        }

        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verileriGöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kaydet();
            verileriGöster();
            temizle();
        }

        int Sira = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Sira = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            silme();
            verileriGöster();
            temizle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            düzeltme();
            verileriGöster();
            temizle();
        }

        
        
     }
 }
