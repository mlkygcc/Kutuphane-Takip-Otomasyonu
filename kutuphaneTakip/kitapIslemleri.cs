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
    public partial class frmKitapIslemleri : Form
    {
        public frmKitapIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = MELEK\SQLEXPRESS; Initial Catalog = Kutuphane; Integrated Security = True;");
        int secilenKitapID = 0;

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kitaplar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tableKitaplar.DataSource = dt;
            tableKitaplar.Columns["kitapID"].Visible = false;
            tableKitaplar.Columns["durum"].Visible = false;
        }
        private void frmKitapIslemleri_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO kitaplar (ISBN, kitapAdi, yazar, sayfaSayisi, stok, kategori, durum) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);

            komut.Parameters.AddWithValue("@p1", txtISBN.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtYazar.Text);
            komut.Parameters.AddWithValue("@p4", txtSayfa.Text);
            komut.Parameters.AddWithValue("@p5", txtStok.Text);
            komut.Parameters.AddWithValue("@p6", comboKategori.Text);
            komut.Parameters.AddWithValue("@p7", 0);

            txtISBN.Text = "";
            txtAd.Text = "";
            txtYazar.Text = "";
            txtSayfa.Text = "";
            txtStok.Text = "";
            comboKategori.Text = "";
            secilenKitapID = 0;

            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void tableKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenKitapID = int.Parse(tableKitaplar.Rows[e.RowIndex].Cells["kitapID"].Value.ToString());

            txtISBN.Text = tableKitaplar.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
            txtAd.Text = tableKitaplar.Rows[e.RowIndex].Cells["kitapAdi"].Value.ToString();
            txtYazar.Text = tableKitaplar.Rows[e.RowIndex].Cells["yazar"].Value.ToString();
            txtSayfa.Text = tableKitaplar.Rows[e.RowIndex].Cells["sayfaSayisi"].Value.ToString();
            txtStok.Text = tableKitaplar.Rows[e.RowIndex].Cells["stok"].Value.ToString();
            comboKategori.Text = tableKitaplar.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE kitaplar SET ISBN=@p1, kitapAdi=@p2, yazar=@p3, sayfaSayisi=@p4, stok=@p5, kategori=@p6 WHERE kitapID=@p8", baglanti);

            komut.Parameters.AddWithValue("@p1", txtISBN.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtYazar.Text);
            komut.Parameters.AddWithValue("@p4", txtSayfa.Text);
            komut.Parameters.AddWithValue("@p5", txtStok.Text);
            komut.Parameters.AddWithValue("@p6", comboKategori.Text);
            komut.Parameters.AddWithValue("@p8", secilenKitapID);

            txtISBN.Text = "";
            txtAd.Text = "";
            txtYazar.Text = "";
            txtSayfa.Text = "";
            txtStok.Text = "";
            comboKategori.Text = "";
            secilenKitapID = 0;

            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM kitaplar WHERE kitapID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", secilenKitapID);
            komut.ExecuteNonQuery();
            baglanti.Close();

            txtISBN.Text = "";
            txtAd.Text = "";
            txtYazar.Text = "";
            txtSayfa.Text = "";
            txtStok.Text = "";
            comboKategori.Text = "";
            secilenKitapID = 0;

            Listele();
        }

        private void bnTemizle_Click(object sender, EventArgs e)
        {
            txtISBN.Text = "";
            txtAd.Text = "";
            txtYazar.Text = "";
            txtSayfa.Text = "";
            txtStok.Text = "";
            comboKategori.Text = "";
            secilenKitapID = 0;
        }
    }
}
