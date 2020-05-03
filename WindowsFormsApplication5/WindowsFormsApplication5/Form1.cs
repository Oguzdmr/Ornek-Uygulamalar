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

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=0ĞUZ\\SQLEXPRESS;Initial Catalog=öğrenciler;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut= new SqlCommand("Select *from bilgiler",baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle=new ListViewItem();
                ekle.Text=oku["Ad Soyad"].ToString();
                ekle.SubItems.Add(oku["Şehir"].ToString());
                ekle.SubItems.Add(oku["Okul"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
    }
}
