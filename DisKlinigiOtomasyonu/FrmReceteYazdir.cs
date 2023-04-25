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
    public partial class FrmReceteYazdir : Form
    {
        public FrmReceteYazdir()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID as 'REÇETE ID',ADSOYAD as 'AD SOYAD',TEDAVI as 'TEDAVİ ADI',UCRET as 'TEDAVİ ÜCRETİ',ILAC as 'İLAÇ İSMİ' From Tbl_Recete", bgl.baglanti());
            da.Fill(dt);
            dgvReceteYazdir.DataSource = dt;
        }

        private void pGeri_Click(object sender, EventArgs e)
        {
            FrmRecete fr = new FrmRecete();
            fr.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dgvReceteYazdir.Width, this.dgvReceteYazdir.Height);
            dgvReceteYazdir.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dgvReceteYazdir.Width, this.dgvReceteYazdir.Height));
            e.Graphics.DrawImage(objBmp, 30, 100);
            e.Graphics.DrawString(label2.Text, new Font("Bookman Old Style", 20, FontStyle.Bold), Brushes.Black, new Point(300, 20));
        }

        private void FrmReceteYazdir_Load(object sender, EventArgs e)
        {
            listele();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
