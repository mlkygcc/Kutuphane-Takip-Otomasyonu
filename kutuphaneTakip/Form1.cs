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

namespace kutuphaneTakip
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = MELEK\SQLEXPRESS; Initial Catalog = Kutuphane; Integrated Security = True;");
        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM uyeler WHERE uyeKullaniciAd=@p1 and uyeSifre=@p2", baglanti);

            komut.Parameters.AddWithValue("@p1", textKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", textSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                if (textKullaniciAdi.Text == "admin" && textSifre.Text == "12345")
                {
                    frmAdmin admin = new frmAdmin();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sadece Admin Giriş Yapabilir", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "Hata");
            }
            baglanti.Close();

        }

        private void frmGiris_Load(object sender, EventArgs e)
        {

        }

        private void textKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
