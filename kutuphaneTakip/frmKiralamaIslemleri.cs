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
    public partial class frmKiralamaIslemleri : Form
    {
        public frmKiralamaIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source = MELEK\SQLEXPRESS; Initial Catalog = Kutuphane; Integrated Security = True;");
        int secilenUyeID = 0;
        int secilenKitapID = 0;

        void uyeListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM uyeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tableUyeler.DataSource = dt;
            tableUyeler.Columns["uyeID"].Visible = false;
        }
        void kitapListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kitaplar WHERE durum = 0", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tableKitaplar.DataSource = dt;
            tableKitaplar.Columns["kitapID"].Visible = false;
            tableKitaplar.Columns["durum"].Visible = false;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (secilenUyeID == 0 || secilenKitapID == 0)
            {
                MessageBox.Show("Lütfen listeden bir üye ve bir kitap seçiniz", "Uyarı");
            }
            baglanti.Open();

            SqlCommand komutEkle = new SqlCommand("INSERT INTO kiralamalar (uyeID, kitapID, alisTarihi, teslimTarihi, iadeDurumu) VALUES (@p1, @p2, @p3, @p4, 0)", baglanti);
            komutEkle.Parameters.AddWithValue("@p1", secilenUyeID);
            komutEkle.Parameters.AddWithValue("@p2", secilenKitapID);
            komutEkle.Parameters.AddWithValue("@p3", dateVerilis.Value);
            komutEkle.Parameters.AddWithValue("@p4", dateİade.Value);
            komutEkle.ExecuteNonQuery();

            SqlCommand komutGuncelle = new SqlCommand("UPDATE kitaplar SET durum = 1 WHERE kitapID = @k1", baglanti);
            komutGuncelle.Parameters.AddWithValue("@k1", secilenKitapID);
            komutGuncelle.ExecuteNonQuery();

            baglanti.Close();

            kitapListele(); 
            lblSecilenKitap.Text = "";
            lblSecilenUye.Text = "";
            secilenKitapID = 0;
            secilenUyeID = 0;
        }

        private void frmKiralamaIslemleri_Load(object sender, EventArgs e)
        {
            uyeListele();
            kitapListele();

        }

        private void tableUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenUyeID = int.Parse(tableUyeler.Rows[e.RowIndex].Cells["uyeID"].Value.ToString());

            lblSecilenUye.Text = tableUyeler.Rows[e.RowIndex].Cells["uyeAd"].Value.ToString() + " " +
                                 tableUyeler.Rows[e.RowIndex].Cells["uyeSoyad"].Value.ToString();
        }

        private void tableKitaplar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenKitapID = int.Parse(tableKitaplar.Rows[e.RowIndex].Cells["kitapID"].Value.ToString());

            lblSecilenKitap.Text = tableKitaplar.Rows[e.RowIndex].Cells["kitapAdi"].Value.ToString();
        }

        private void txtUyeAra_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM uyeler WHERE uyeAd LIKE '%" + txtUyeAra.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tableUyeler.DataSource = dt;
        }

        private void textKitapAra_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kitaplar WHERE durum=0 AND kitapAdi LIKE '%" + textKitapAra.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tableKitaplar.DataSource = dt;
        }
    }
}
