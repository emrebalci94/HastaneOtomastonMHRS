namespace HastaneOtomasyon
{
    partial class GirisForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.lbl_saat = new System.Windows.Forms.Label();
            this.pct_doktor = new System.Windows.Forms.PictureBox();
            this.pct_hasta = new System.Windows.Forms.PictureBox();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.pct_line = new System.Windows.Forms.PictureBox();
            this.pct_baslik = new System.Windows.Forms.PictureBox();
            this.pct_kapat = new System.Windows.Forms.PictureBox();
            this.pct_kucult = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pct_koyu = new System.Windows.Forms.PictureBox();
            this.pct_mavi = new System.Windows.Forms.PictureBox();
            this.pct_yesil = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pct_ustLineAcik = new System.Windows.Forms.PictureBox();
            this.pct_ustLineKoyu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_doktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_baslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_koyu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_mavi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_yesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_ustLineAcik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_ustLineKoyu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tarih.ForeColor = System.Drawing.Color.White;
            this.lbl_tarih.Location = new System.Drawing.Point(12, 9);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(0, 22);
            this.lbl_tarih.TabIndex = 0;
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saat.ForeColor = System.Drawing.Color.White;
            this.lbl_saat.Location = new System.Drawing.Point(844, 502);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(0, 22);
            this.lbl_saat.TabIndex = 1;
            // 
            // pct_doktor
            // 
            this.pct_doktor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_doktor.Image = ((System.Drawing.Image)(resources.GetObject("pct_doktor.Image")));
            this.pct_doktor.Location = new System.Drawing.Point(157, 280);
            this.pct_doktor.Name = "pct_doktor";
            this.pct_doktor.Size = new System.Drawing.Size(210, 182);
            this.pct_doktor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_doktor.TabIndex = 2;
            this.pct_doktor.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_doktor, "Doktor Girişi");
            this.pct_doktor.Click += new System.EventHandler(this.pct_doktor_Click);
            this.pct_doktor.MouseLeave += new System.EventHandler(this.pct_doktor_MouseLeave);
            this.pct_doktor.MouseHover += new System.EventHandler(this.pct_doktor_MouseHover);
            // 
            // pct_hasta
            // 
            this.pct_hasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_hasta.Image = ((System.Drawing.Image)(resources.GetObject("pct_hasta.Image")));
            this.pct_hasta.Location = new System.Drawing.Point(596, 280);
            this.pct_hasta.Name = "pct_hasta";
            this.pct_hasta.Size = new System.Drawing.Size(210, 182);
            this.pct_hasta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_hasta.TabIndex = 3;
            this.pct_hasta.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_hasta, "Hasta Girişi");
            this.pct_hasta.Click += new System.EventHandler(this.pct_hasta_Click);
            this.pct_hasta.MouseLeave += new System.EventHandler(this.pct_hasta_MouseLeave);
            this.pct_hasta.MouseHover += new System.EventHandler(this.pct_hasta_MouseHover);
            // 
            // pct_logo
            // 
            this.pct_logo.Image = ((System.Drawing.Image)(resources.GetObject("pct_logo.Image")));
            this.pct_logo.Location = new System.Drawing.Point(412, 297);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(133, 134);
            this.pct_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_logo.TabIndex = 4;
            this.pct_logo.TabStop = false;
            // 
            // pct_line
            // 
            this.pct_line.Image = ((System.Drawing.Image)(resources.GetObject("pct_line.Image")));
            this.pct_line.Location = new System.Drawing.Point(54, 59);
            this.pct_line.Name = "pct_line";
            this.pct_line.Size = new System.Drawing.Size(855, 50);
            this.pct_line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_line.TabIndex = 5;
            this.pct_line.TabStop = false;
            // 
            // pct_baslik
            // 
            this.pct_baslik.Image = ((System.Drawing.Image)(resources.GetObject("pct_baslik.Image")));
            this.pct_baslik.Location = new System.Drawing.Point(310, 157);
            this.pct_baslik.Name = "pct_baslik";
            this.pct_baslik.Size = new System.Drawing.Size(333, 50);
            this.pct_baslik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_baslik.TabIndex = 6;
            this.pct_baslik.TabStop = false;
            // 
            // pct_kapat
            // 
            this.pct_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(117)))));
            this.pct_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_kapat.Image = ((System.Drawing.Image)(resources.GetObject("pct_kapat.Image")));
            this.pct_kapat.Location = new System.Drawing.Point(913, 8);
            this.pct_kapat.Name = "pct_kapat";
            this.pct_kapat.Size = new System.Drawing.Size(25, 25);
            this.pct_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_kapat.TabIndex = 7;
            this.pct_kapat.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_kapat, "Kapat");
            this.pct_kapat.Click += new System.EventHandler(this.pct_kapat_Click);
            // 
            // pct_kucult
            // 
            this.pct_kucult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(117)))));
            this.pct_kucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_kucult.Image = ((System.Drawing.Image)(resources.GetObject("pct_kucult.Image")));
            this.pct_kucult.Location = new System.Drawing.Point(888, 8);
            this.pct_kucult.Name = "pct_kucult";
            this.pct_kucult.Size = new System.Drawing.Size(25, 25);
            this.pct_kucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_kucult.TabIndex = 8;
            this.pct_kucult.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_kucult, "Küçült");
            this.pct_kucult.Click += new System.EventHandler(this.pct_kucult_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pct_koyu
            // 
            this.pct_koyu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_koyu.Image = ((System.Drawing.Image)(resources.GetObject("pct_koyu.Image")));
            this.pct_koyu.Location = new System.Drawing.Point(898, 279);
            this.pct_koyu.Name = "pct_koyu";
            this.pct_koyu.Size = new System.Drawing.Size(30, 30);
            this.pct_koyu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_koyu.TabIndex = 9;
            this.pct_koyu.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_koyu, "Tema 1");
            this.pct_koyu.Click += new System.EventHandler(this.pct_koyu_Click);
            // 
            // pct_mavi
            // 
            this.pct_mavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_mavi.Image = ((System.Drawing.Image)(resources.GetObject("pct_mavi.Image")));
            this.pct_mavi.Location = new System.Drawing.Point(898, 327);
            this.pct_mavi.Name = "pct_mavi";
            this.pct_mavi.Size = new System.Drawing.Size(25, 25);
            this.pct_mavi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_mavi.TabIndex = 10;
            this.pct_mavi.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_mavi, "Tema 2");
            this.pct_mavi.Click += new System.EventHandler(this.pct_mavi_Click);
            // 
            // pct_yesil
            // 
            this.pct_yesil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_yesil.Image = ((System.Drawing.Image)(resources.GetObject("pct_yesil.Image")));
            this.pct_yesil.Location = new System.Drawing.Point(898, 375);
            this.pct_yesil.Name = "pct_yesil";
            this.pct_yesil.Size = new System.Drawing.Size(25, 25);
            this.pct_yesil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_yesil.TabIndex = 11;
            this.pct_yesil.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_yesil, "Tema 3");
            this.pct_yesil.Click += new System.EventHandler(this.pct_yesil_Click);
            // 
            // pct_ustLineAcik
            // 
            this.pct_ustLineAcik.Image = ((System.Drawing.Image)(resources.GetObject("pct_ustLineAcik.Image")));
            this.pct_ustLineAcik.Location = new System.Drawing.Point(4, 4);
            this.pct_ustLineAcik.Name = "pct_ustLineAcik";
            this.pct_ustLineAcik.Size = new System.Drawing.Size(943, 33);
            this.pct_ustLineAcik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_ustLineAcik.TabIndex = 12;
            this.pct_ustLineAcik.TabStop = false;
            // 
            // pct_ustLineKoyu
            // 
            this.pct_ustLineKoyu.Image = ((System.Drawing.Image)(resources.GetObject("pct_ustLineKoyu.Image")));
            this.pct_ustLineKoyu.Location = new System.Drawing.Point(4, 10);
            this.pct_ustLineKoyu.Name = "pct_ustLineKoyu";
            this.pct_ustLineKoyu.Size = new System.Drawing.Size(943, 33);
            this.pct_ustLineKoyu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_ustLineKoyu.TabIndex = 13;
            this.pct_ustLineKoyu.TabStop = false;
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 545);
            this.Controls.Add(this.pct_yesil);
            this.Controls.Add(this.pct_mavi);
            this.Controls.Add(this.pct_koyu);
            this.Controls.Add(this.pct_kucult);
            this.Controls.Add(this.pct_kapat);
            this.Controls.Add(this.pct_baslik);
            this.Controls.Add(this.pct_line);
            this.Controls.Add(this.pct_logo);
            this.Controls.Add(this.pct_hasta);
            this.Controls.Add(this.pct_doktor);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.pct_ustLineAcik);
            this.Controls.Add(this.pct_ustLineKoyu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.GirisForm_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pct_doktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_hasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_baslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_koyu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_mavi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_yesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_ustLineAcik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_ustLineKoyu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.PictureBox pct_doktor;
        private System.Windows.Forms.PictureBox pct_hasta;
        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.PictureBox pct_line;
        private System.Windows.Forms.PictureBox pct_baslik;
        private System.Windows.Forms.PictureBox pct_kapat;
        private System.Windows.Forms.PictureBox pct_kucult;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pct_koyu;
        private System.Windows.Forms.PictureBox pct_mavi;
        private System.Windows.Forms.PictureBox pct_yesil;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pct_ustLineAcik;
        private System.Windows.Forms.PictureBox pct_ustLineKoyu;
    }
}

