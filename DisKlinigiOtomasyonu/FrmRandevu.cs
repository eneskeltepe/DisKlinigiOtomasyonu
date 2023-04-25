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

namespace DisKlinigiOtomasyonu
{
    public partial class FrmRandevu : Form
    {
        public FrmRandevu()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_Randevu", bgl.baglanti());
            da.Fill(dt);
            dgvRandevu.DataSource = dt;
        }

        void temizle()
        {
            txtid.Text = "";
            cmbAdSoyad.SelectedValue = "  ";
            dtpTarih.Text = "";
            cmbSaat.SelectedValue = "  ";
            cmbTedavi.SelectedValue = "  ";
        }

        void fillHasta()
        {
            SqlCommand komut = new SqlCommand("Select ADSOYAD from TBL_HASTA", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ADSOYAD", typeof(string));
            dt.Load(dr);
            cmbAdSoyad.ValueMember = "ADSOYAD";
            cmbAdSoyad.DataSource = dt;
        }

        void fillTedavi()
        {
            SqlCommand komut = new SqlCommand("Select AD from TBL_TEDAVI", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("AD", typeof(string));
            dt.Load(dr);
            cmbTedavi.ValueMember = "AD";
            cmbTedavi.DataSource = dt;
        }

        private void pGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void FrmRandevu_Load(object sender, EventArgs e)
        {
            listele();
            fillHasta();
            fillTedavi();
            temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Randevu kaydı sisteme eklenecektir.Gerçekten eklemek istiyor musunuz?", "Randevu Kaydı Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("insert into TBL_RANDEVU (ADSOYAD,TEDAVI,TARIH,SAAT) values (@P1,@P2,@P3,@P4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", cmbAdSoyad.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@P2", cmbTedavi.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@P3", dtpTarih.Text);
                komut.Parameters.AddWithValue("@P4", cmbSaat.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Randevu kaydı ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Randevu kaydı sistemden silinecektir.Gerçekten silmek istiyor musunuz?", "Randevu Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from TBL_RANDEVU where ID=@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu kaydı sistemden başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Randevu kaydı silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvRandevu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvRandevu.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            cmbAdSoyad.Text = dgvRandevu.Rows[e.RowIndex].Cells["ADSOYAD"].Value.ToString();
            cmbTedavi.Text = dgvRandevu.Rows[e.RowIndex].Cells["TEDAVI"].Value.ToString();
            dtpTarih.Text = dgvRandevu.Rows[e.RowIndex].Cells["TARIH"].Value.ToString();
            cmbSaat.Text = dgvRandevu.Rows[e.RowIndex].Cells["SAAT"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Randevu kaydı güncellenecektir.Gerçekten güncellemek istiyor musunuz?", "Randevu Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update TBL_RANDEVU set ADSOYAD=@P1,TEDAVI=@P2,TARIH=@P3,SAAT=@P4 where ID=@P5", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", cmbAdSoyad.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@P2", cmbTedavi.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@P3", dtpTarih.Text);
                komut.Parameters.AddWithValue("@P4", cmbSaat.Text);
                komut.Parameters.AddWithValue("@P5", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu kaydı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Randevu kaydı güncelleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
