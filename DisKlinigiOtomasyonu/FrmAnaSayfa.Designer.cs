namespace DisKlinigiOtomasyonu
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHasta = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnRandevu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnTedavi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnReceteler = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pCikis = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.pCikis);
            this.panel1.Controls.Add(this.btnReceteler);
            this.panel1.Controls.Add(this.btnRandevu);
            this.panel1.Controls.Add(this.btnTedavi);
            this.panel1.Controls.Add(this.btnHasta);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 102);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnHasta
            // 
            this.btnHasta.BorderRadius = 10;
            this.btnHasta.BorderThickness = 3;
            this.btnHasta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHasta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHasta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHasta.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHasta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHasta.FillColor = System.Drawing.Color.Blue;
            this.btnHasta.FillColor2 = System.Drawing.Color.Green;
            this.btnHasta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnHasta.ForeColor = System.Drawing.Color.White;
            this.btnHasta.Location = new System.Drawing.Point(150, 25);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(180, 45);
            this.btnHasta.TabIndex = 0;
            this.btnHasta.Text = "Hasta";
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.BorderRadius = 10;
            this.btnRandevu.BorderThickness = 3;
            this.btnRandevu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRandevu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRandevu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRandevu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRandevu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRandevu.FillColor = System.Drawing.Color.Blue;
            this.btnRandevu.FillColor2 = System.Drawing.Color.Green;
            this.btnRandevu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRandevu.ForeColor = System.Drawing.Color.White;
            this.btnRandevu.Location = new System.Drawing.Point(346, 25);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(180, 45);
            this.btnRandevu.TabIndex = 1;
            this.btnRandevu.Text = "Randevu";
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // btnTedavi
            // 
            this.btnTedavi.BorderRadius = 10;
            this.btnTedavi.BorderThickness = 3;
            this.btnTedavi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTedavi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTedavi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTedavi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTedavi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTedavi.FillColor = System.Drawing.Color.Blue;
            this.btnTedavi.FillColor2 = System.Drawing.Color.Green;
            this.btnTedavi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnTedavi.ForeColor = System.Drawing.Color.White;
            this.btnTedavi.Location = new System.Drawing.Point(542, 25);
            this.btnTedavi.Name = "btnTedavi";
            this.btnTedavi.Size = new System.Drawing.Size(180, 45);
            this.btnTedavi.TabIndex = 2;
            this.btnTedavi.Text = "Tedavi";
            this.btnTedavi.Click += new System.EventHandler(this.btnTedavi_Click);
            // 
            // btnReceteler
            // 
            this.btnReceteler.BorderRadius = 10;
            this.btnReceteler.BorderThickness = 3;
            this.btnReceteler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReceteler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReceteler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReceteler.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReceteler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReceteler.FillColor = System.Drawing.Color.Blue;
            this.btnReceteler.FillColor2 = System.Drawing.Color.Green;
            this.btnReceteler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnReceteler.ForeColor = System.Drawing.Color.White;
            this.btnReceteler.Location = new System.Drawing.Point(738, 25);
            this.btnReceteler.Name = "btnReceteler";
            this.btnReceteler.Size = new System.Drawing.Size(180, 45);
            this.btnReceteler.TabIndex = 3;
            this.btnReceteler.Text = "Reçeteler";
            this.btnReceteler.Click += new System.EventHandler(this.btnReceteler_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(976, 546);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(374, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 34);
            this.label1.TabIndex = 12;
            this.label1.Text = "SEVDE DİŞ KLİNİĞİ";
            // 
            // pCikis
            // 
            this.pCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pCikis.Image = ((System.Drawing.Image)(resources.GetObject("pCikis.Image")));
            this.pCikis.Location = new System.Drawing.Point(950, 3);
            this.pCikis.Name = "pCikis";
            this.pCikis.Size = new System.Drawing.Size(50, 33);
            this.pCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pCikis.TabIndex = 4;
            this.pCikis.TabStop = false;
            this.pCikis.Click += new System.EventHandler(this.pCikis_Click);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnHasta;
        private Guna.UI2.WinForms.Guna2GradientButton btnReceteler;
        private Guna.UI2.WinForms.Guna2GradientButton btnRandevu;
        private Guna.UI2.WinForms.Guna2GradientButton btnTedavi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pCikis;
    }
}