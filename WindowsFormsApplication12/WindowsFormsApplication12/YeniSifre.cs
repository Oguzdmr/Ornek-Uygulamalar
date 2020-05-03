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
    public partial class YeniSifre : Form
    {
        public YeniSifre()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=0ĞUZ\\SQLEXPRESS;Initial Catalog=Toplulukİslem;Integrated Security=True;");
        int Id1 = SifremiUnuttum.ıd;
        private void kaydet()
        {
            if (txtyenisifre1.Text == txtyenisifre2.Text)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Update Sifreislem set Sifre=@Sifre where Id="+Id1+"", baglan);
                komut.Parameters.AddWithValue("@Sifre", txtyenisifre1.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Şifreniz Kaydedilmiştir");
                
                Login lgn=new Login();
                lgn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Şifreler Uyuşmuyor!!!");
            }
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            kaydet();
            
        }
    }
}
