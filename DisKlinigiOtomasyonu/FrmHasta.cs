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
    public partial class FrmHasta : Form
    {
        public FrmHasta()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_HASTA", bgl.baglanti());
            da.Fill(dt);
            dgvHasta.DataSource = dt;
        }
        void temizle()
        {
            txtid.Text = "";
            txtAdSoyad.Text = "";
            txtTelefon.Text = "";
            dtpDogumTarihi.Text = "";
            cmbCinsiyet.SelectedItem = " ";
            txtAlerji.Text = "";
            txtAdres.Text = "";
        }

        private void pGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void FrmHasta_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Hasta kaydı sisteme eklenecektir.Gerçekten eklemek istiyor musunuz?", "Hasta Kaydı Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("insert into TBL_HASTA (ADSOYAD,TELEFON,TARIH,CINSIYET,ALERJI,ADRES) values (@P1,@P2,@P3,@P4,@P5,@P6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@P2", txtTelefon.Text);
                komut.Parameters.AddWithValue("@P3", dtpDogumTarihi.Value.Date);
                komut.Parameters.AddWithValue("@P4", cmbCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@P5", txtAlerji.Text);
                komut.Parameters.AddWithValue("@P6", txtAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Hasta kaydı sisteme başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Hasta kaydı ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvHasta.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtAdSoyad.Text = dgvHasta.Rows[e.RowIndex].Cells["ADSOYAD"].Value.ToString();
            txtTelefon.Text = dgvHasta.Rows[e.RowIndex].Cells["TELEFON"].Value.ToString();
            dtpDogumTarihi.Text = dgvHasta.Rows[e.RowIndex].Cells["TARIH"].Value.ToString();
            cmbCinsiyet.Text = dgvHasta.Rows[e.RowIndex].Cells["CINSIYET"].Value.ToString();
            txtAlerji.Text = dgvHasta.Rows[e.RowIndex].Cells["ALERJI"].Value.ToString();
            txtAdres.Text = dgvHasta.Rows[e.RowIndex].Cells["ADRES"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Hasta kaydı sistemden silinecektir.Gerçekten silmek istiyor musunuz?", "Hasta Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from TBL_HASTA where ID=@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Hasta kaydı sistemden başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Hasta kaydı silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Hasta kaydı güncellenecektir.Gerçekten güncellemek istiyor musunuz?", "Hasta Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update TBL_HASTA set ADSOYAD=@P1,TELEFON=@P2,TARIH=@P3,CINSIYET=@P4,ALERJI=@P5,ADRES=@P6 where ID=@P7", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@P2", txtTelefon.Text);
                komut.Parameters.AddWithValue("@P3", dtpDogumTarihi.Value.Date);
                komut.Parameters.AddWithValue("@P4", cmbCinsiyet.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@P5", txtAlerji.Text);
                komut.Parameters.AddWithValue("@P6", txtAdres.Text);
                komut.Parameters.AddWithValue("@P7", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Hasta kaydı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Hasta kaydı güncelleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_HASTA where ADSOYAD like '%" + txtAdSoyad.Text + "%'");
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
        }
    }
}
