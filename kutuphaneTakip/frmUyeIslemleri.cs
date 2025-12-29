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
    public partial class frmUyeIslemleri : Form
    {
        public frmUyeIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = MELEK\SQLEXPRESS; Initial Catalog = Kutuphane; Integrated Security = True;");
        int secilenUyeID = 0;

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM uyeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tableUyeler.DataSource = dt;
            tableUyeler.Columns["uyeID"].Visible = false;
        }
        private void frmUyeIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void tableUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenUyeID = int.Parse(tableUyeler.Rows[e.RowIndex].Cells["uyeID"].Value.ToString());

            txtAd.Text = tableUyeler.Rows[e.RowIndex].Cells["uyeAd"].Value.ToString();
            txtSoyad.Text = tableUyeler.Rows[e.RowIndex].Cells["uyeSoyad"].Value.ToString();
            txtKullaniciAdi.Text = tableUyeler.Rows[e.RowIndex].Cells["uyeKullaniciAd"].Value.ToString();
            txtSifre.Text = tableUyeler.Rows[e.RowIndex].Cells["uyeSifre"].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO uyeler (uyeAd,uyeSoyad,uyeKullaniciAd,uyeSifre) VALUES (@p1,@p2,@p3,@p4)", baglanti);

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            secilenUyeID = 0;

            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE uyeler SET uyeAd=@p1, uyeSoyad=@p2, uyeKullaniciAd=@p3, uyeSifre=@p4 WHERE uyeID=@p5", baglanti);

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", secilenUyeID);

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            secilenUyeID = 0;

            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM uyeler WHERE uyeID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", secilenUyeID); 
            komut.ExecuteNonQuery();
            baglanti.Close();

            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            secilenUyeID = 0;

            Listele();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            secilenUyeID = 0;
        }
    }
}
