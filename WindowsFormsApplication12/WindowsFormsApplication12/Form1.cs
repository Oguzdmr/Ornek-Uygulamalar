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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=0ĞUZ\\SQLEXPRESS;Initial Catalog=Toplulukİslem;Integrated Security=True;");

        string kullanıcıadı, sifre;
        private void giris()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *from Sifreislem", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                kullanıcıadı = oku["KullanıcıAdı"].ToString();
                sifre = oku["Sifre"].ToString();
                if (kullanıcıadı == textBox1.Text && sifre == textBox2.Text)
                {

                }
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnsifreunuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttum sfrunttum = new SifremiUnuttum();
            sfrunttum.Show();
            this.Hide();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {

        }

        
    }
}
