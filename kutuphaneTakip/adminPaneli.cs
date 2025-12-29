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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = MELEK\SQLEXPRESS; Initial Catalog = Kutuphane; Integrated Security = True;");
        void Listele()
        {
            string sorgu = @"
        SELECT uyeler.uyeAd + ' ' + uyeler.uyeSoyad AS 'Üye Adı',  kitaplar.kitapAdi AS 'Kitap Adı', 
        kiralamalar.alisTarihi AS 'Veriliş Tarihi',
        kiralamalar.teslimTarihi AS 'İade Tarihi' FROM kiralamalar
        INNER JOIN uyeler ON kiralamalar.UyeID = uyeler.uyeID
        INNER JOIN kitaplar ON kiralamalar.KitapID = kitaplar.kitapID";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tableKiralamalar.DataSource = dt;
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            Listele();
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM kitaplar", baglanti);
            lblToplamKitap.Text = komut1.ExecuteScalar().ToString();

            SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM uyeler", baglanti);
            lblToplamUye.Text = komut2.ExecuteScalar().ToString();

            SqlCommand komut3 = new SqlCommand("SELECT COUNT(*) FROM kitaplar WHERE durum = 1", baglanti);
            lblKiralamalar.Text = komut3.ExecuteScalar().ToString();
            
            baglanti.Close();

        }

        private void btnKitapIslemleri_Click(object sender, EventArgs e)
        {
            frmKitapIslemleri kitap = new frmKitapIslemleri();
            kitap.Show();
        }

        private void btnUyeIslemleri_Click(object sender, EventArgs e)
        {
            frmUyeIslemleri uye = new frmUyeIslemleri();
            uye.Show();
        }

        private void btnKiralamaIslemleri_Click(object sender, EventArgs e)
        {
            frmKiralamaIslemleri kiralama = new frmKiralamaIslemleri();
            kiralama.Show();

        }
    }
}
