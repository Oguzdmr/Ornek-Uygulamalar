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

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=0ĞUZ\\SQLEXPRESS;Initial Catalog=Kayıtlar;Integrated Security=True");

        private void verileriGöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Gelenler", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text=oku["Adı"].ToString();
                ekle.SubItems.Add(oku["Firma"].ToString());
                listView1.Items.Add(ekle);
            }
            
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verileriGöster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into Gelenler (Adı,Firma) Values('" + textBox1.Text.ToString() + "' , '" + textBox2.Text.ToString() + "' )", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verileriGöster();
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }
    }
}
