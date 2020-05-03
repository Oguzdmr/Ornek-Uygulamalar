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

namespace WindowsFormsApplication12
{
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }

        string Kullanıcıadı, Yanıt;
        public static int ıd;

        SqlConnection baglan = new SqlConnection("Data Source=0ĞUZ\\SQLEXPRESS;Initial Catalog=Toplulukİslem;Integrated Security=True;");
      

        private void dogrula()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Sifreislem", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ıd = int.Parse(oku["Id"].ToString());
                Kullanıcıadı = oku["KullanıcıAdı"].ToString();
                Yanıt = oku["Yanıt"].ToString();
                if (Kullanıcıadı==txtkllnıcıadı.Text.ToString() && Yanıt==txtyanıt.Text.ToString())
                {
                    YeniSifre ynisifr = new YeniSifre();
                    ynisifr.Show();
                    this.Hide();
                }
            }
            if (Kullanıcıadı != txtkllnıcıadı.Text.ToString() || Yanıt != txtyanıt.Text.ToString())
            {
                MessageBox.Show("Yanlış Bilgi Girdiniz!!!");
            }
            baglan.Close();
        }

        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("İlk Evcil Hayvanınızın Adı Nedir?");
            comboBox1.Items.Add("İlk Okul Öğretmeninizin Adı Nedir?");
            comboBox1.Items.Add("En Yakın Arkadaşınızn Adı Nedir?");
            comboBox1.Items.Add("Çocukluk Lakabınız Nedir?");

        }

        private void btndogrula_Click(object sender, EventArgs e)
        {
            dogrula();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Login lgn = new Login();
            lgn.Show();
            this.Hide();
        }
      
    }
}
