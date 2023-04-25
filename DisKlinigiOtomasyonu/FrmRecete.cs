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
    public partial class FrmRecete : Form
    {
        public FrmRecete()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_RECETE", bgl.baglanti());
            da.Fill(dt);
            dgvRecete.DataSource = dt;
        }
        void temizle()
        {
            txtid.Text = "";
            cmbAdSoyad.SelectedValue = " ";
            txtTedaviAdi.Text = "";
            txtTedaviUcreti.Text = "";
            txtIlac.Text = "";
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
            SqlCommand komut = new SqlCommand("Select * from TBL_RANDEVU where ADSOYAD='" + cmbAdSoyad.SelectedValue.ToString() + "'", bgl.baglanti());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtTedaviAdi.Text = dr["TEDAVI"].ToString();
            }
        }

        private void pGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa fr = new FrmAnaSayfa();
            fr.Show();
            this.Hide();
        }

        private void FrmRecete_Load(object sender, EventArgs e)
        {
            listele();
            fillHasta();
            temizle();
        }

        private void cmbAdSoyad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillTedavi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Reçete kaydı sisteme eklenecektir.Gerçekten eklemek istiyor musunuz?", "Reçete Kaydı Ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("insert into TBL_RECETE (ADSOYAD,TEDAVI,UCRET,ILAC) values (@P1,@P2,@P3,@P4)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", cmbAdSoyad.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@P2", txtTedaviAdi.Text);
                komut.Parameters.AddWithValue("@P3", txtTedaviUcreti.Text);
                komut.Parameters.AddWithValue("@P4", txtIlac.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Reçete kaydı sisteme başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Reçete kaydı ekleme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dgvRecete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgvRecete.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            cmbAdSoyad.Text = dgvRecete.Rows[e.RowIndex].Cells["ADSOYAD"].Value.ToString();
            txtTedaviAdi.Text = dgvRecete.Rows[e.RowIndex].Cells["TEDAVI"].Value.ToString();
            txtTedaviUcreti.Text = dgvRecete.Rows[e.RowIndex].Cells["UCRET"].Value.ToString();
            txtIlac.Text = dgvRecete.Rows[e.RowIndex].Cells["ILAC"].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Reçete kaydı sistemden silinecektir.Gerçekten silmek istiyor musunuz?", "Reçete Kaydı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Delete from TBL_RECETE where ID=@P1", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtid.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Reçete kaydı sistemden başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Reçete kaydı silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Randevu kaydı güncellenecektir.Gerçekten güncellemek istiyor musunuz?", "Randevu Kaydı Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("Update TBL_RECETE set ADSOYAD=@P1,TEDAVI=@P2,UCRET=@P3,ILAC=@P4 where ID=@P5", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", cmbAdSoyad.SelectedValue.ToString());
                komut.Parameters.AddWithValue("@P2", txtTedaviAdi.Text);
                komut.Parameters.AddWithValue("@P3", txtTedaviUcreti.Text);
                komut.Parameters.AddWithValue("@P4", txtIlac.Text);
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

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            FrmReceteYazdir fr = new FrmReceteYazdir();
            fr.Show();
            this.Hide();
        }
    }
}
