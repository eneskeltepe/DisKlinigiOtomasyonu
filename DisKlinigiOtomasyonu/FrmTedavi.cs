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
    public partial class FrmTedavi : Form
    {
        public FrmTedavi()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_TEDAVI", bgl.baglanti());
            da.Fill(dt);
            dgvTedavi.DataSource = dt;
        }

        void temizle()
        {
            txtid.Text = "";
            txtTedaviAdi.Text = "";
            txtTutar.Text = "";
            txtAciklama.Text = "";
        }

        private void FrmTedavi_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Tedavi kaydı sisteme eklenecektir.Gerçekten eklemek istiyor musunuz?", "Tedavi Kaydı Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("insert into TBL_TEDAVI (AD,UCRET,ACIKLAMA) values (@P1,@P2,@P3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtTedaviAdi.Text);
                komut.Parameters.AddWithValue("@P2", txtTutar.Text);
                komut.Parameters.AddWithValue("@P3", txtAciklama.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Tedavi kaydı sisteme başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Tedavi kaydı ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvTedavi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvTedavi.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtTedaviAdi.Text = dgvTedavi.Rows[e.RowIndex].Cells["AD"].Value.ToString();
            txtTutar.Text = dgvTedavi.Rows[e.RowIndex].Cells["UCRET"].Value.ToString();
            txtAciklama.Text = dgvTedavi.Rows[e.RowIndex].Cells["ACIKLAMA"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Tedavi kaydı sistemden silinecektir.Gerçekten silmek istiyor musunuz?", "Tedavi Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from TBL_TEDAVI where ID=@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Tedavi kaydı sistemden başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Tedavi kaydı silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Tedavi kaydı güncellenecektir.Gerçekten güncellemek istiyor musunuz?", "Tedavi Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update TBL_TEDAVI set AD=@P1,UCRET=@P2,ACIKLAMA=@P3 where ID=@P4", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtTedaviAdi.Text);
                komut.Parameters.AddWithValue("@P2", txtTutar.Text);
                komut.Parameters.AddWithValue("@P3", txtAciklama.Text);
                komut.Parameters.AddWithValue("@P4", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Tedavi kaydı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tedavi kaydı güncelleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
