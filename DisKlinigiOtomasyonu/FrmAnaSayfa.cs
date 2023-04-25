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
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnHasta_Click(object sender, EventArgs e)
        {
            FrmHasta fr = new FrmHasta();
            fr.Show();
            this.Hide();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            FrmRandevu fr = new FrmRandevu();
            fr.Show();
            this.Hide();
        }

        private void btnTedavi_Click(object sender, EventArgs e)
        {
            FrmTedavi fr = new FrmTedavi();
            fr.Show();
            this.Hide();
        }

        private void btnReceteler_Click(object sender, EventArgs e)
        {
            FrmRecete fr = new FrmRecete();
            fr.Show();
            this.Hide();
        }

        private void pCikis_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
