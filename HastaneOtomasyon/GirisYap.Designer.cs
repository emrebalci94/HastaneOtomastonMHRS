namespace HastaneOtomasyon
{
    partial class GirisYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisYap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.pct_kapat = new System.Windows.Forms.PictureBox();
            this.pct_kucult = new System.Windows.Forms.PictureBox();
            this.lbl_secilen = new System.Windows.Forms.Label();
            this.pct_giris = new System.Windows.Forms.PictureBox();
            this.pnl_giris = new System.Windows.Forms.Panel();
            this.lbl_giris = new System.Windows.Forms.Label();
            this.pnl_kayit = new System.Windows.Forms.Panel();
            this.lbl_kayit = new System.Windows.Forms.Label();
            this.pct_kayit = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kucult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_giris)).BeginInit();
            this.pnl_giris.SuspendLayout();
            this.pnl_kayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kayit)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C Kimlik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // txt_tc
            // 
            this.txt_tc.ForeColor = System.Drawing.Color.White;
            this.txt_tc.Location = new System.Drawing.Point(71, 63);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(234, 20);
            this.txt_tc.TabIndex = 2;
            this.txt_tc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_tc, "11 Haneli T.C kimlik numaranızı giriniz...");
            this.txt_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tc_KeyPress);
            // 
            // txt_sifre
            // 
            this.txt_sifre.ForeColor = System.Drawing.Color.White;
            this.txt_sifre.Location = new System.Drawing.Point(71, 106);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(234, 20);
            this.txt_sifre.TabIndex = 3;
            this.txt_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txt_sifre, "Şifrenizi Giriniz.");
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // pct_kapat
            // 
            this.pct_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_kapat.Location = new System.Drawing.Point(315, 3);
            this.pct_kapat.Name = "pct_kapat";
            this.pct_kapat.Size = new System.Drawing.Size(20, 20);
            this.pct_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_kapat.TabIndex = 4;
            this.pct_kapat.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_kapat, "Kapat");
            this.pct_kapat.Click += new System.EventHandler(this.pct_kapat_Click);
            // 
            // pct_kucult
            // 
            this.pct_kucult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_kucult.Image = ((System.Drawing.Image)(resources.GetObject("pct_kucult.Image")));
            this.pct_kucult.Location = new System.Drawing.Point(294, 3);
            this.pct_kucult.Name = "pct_kucult";
            this.pct_kucult.Size = new System.Drawing.Size(20, 20);
            this.pct_kucult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_kucult.TabIndex = 5;
            this.pct_kucult.TabStop = false;
            this.toolTip1.SetToolTip(this.pct_kucult, "Küçült");
            this.pct_kucult.Click += new System.EventHandler(this.pct_kucult_Click);
            // 
            // lbl_secilen
            // 
            this.lbl_secilen.AutoSize = true;
            this.lbl_secilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_secilen.ForeColor = System.Drawing.Color.White;
            this.lbl_secilen.Location = new System.Drawing.Point(122, 27);
            this.lbl_secilen.Name = "lbl_secilen";
            this.lbl_secilen.Size = new System.Drawing.Size(60, 24);
            this.lbl_secilen.TabIndex = 6;
            this.lbl_secilen.Text = "label3";
            // 
            // pct_giris
            // 
            this.pct_giris.Image = ((System.Drawing.Image)(resources.GetObject("pct_giris.Image")));
            this.pct_giris.Location = new System.Drawing.Point(3, 3);
            this.pct_giris.Name = "pct_giris";
            this.pct_giris.Size = new System.Drawing.Size(140, 35);
            this.pct_giris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_giris.TabIndex = 7;
            this.pct_giris.TabStop = false;
            this.pct_giris.Click += new System.EventHandler(this.pct_giris_Click);
            this.pct_giris.MouseLeave += new System.EventHandler(this.pct_giris_MouseLeave);
            this.pct_giris.MouseHover += new System.EventHandler(this.pct_giris_MouseHover);
            // 
            // pnl_giris
            // 
            this.pnl_giris.BackColor = System.Drawing.Color.Transparent;
            this.pnl_giris.Controls.Add(this.lbl_giris);
            this.pnl_giris.Controls.Add(this.pct_giris);
            this.pnl_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_giris.Location = new System.Drawing.Point(21, 149);
            this.pnl_giris.Name = "pnl_giris";
            this.pnl_giris.Size = new System.Drawing.Size(145, 50);
            this.pnl_giris.TabIndex = 8;
            // 
            // lbl_giris
            // 
            this.lbl_giris.AutoSize = true;
            this.lbl_giris.BackColor = System.Drawing.Color.Transparent;
            this.lbl_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris.ForeColor = System.Drawing.Color.White;
            this.lbl_giris.Location = new System.Drawing.Point(53, 12);
            this.lbl_giris.Name = "lbl_giris";
            this.lbl_giris.Size = new System.Drawing.Size(63, 16);
            this.lbl_giris.TabIndex = 9;
            this.lbl_giris.Text = "Giriş Yap";
            this.lbl_giris.Click += new System.EventHandler(this.pct_giris_Click);
            this.lbl_giris.MouseLeave += new System.EventHandler(this.pct_giris_MouseLeave);
            this.lbl_giris.MouseHover += new System.EventHandler(this.pct_giris_MouseHover);
            // 
            // pnl_kayit
            // 
            this.pnl_kayit.BackColor = System.Drawing.Color.Transparent;
            this.pnl_kayit.Controls.Add(this.lbl_kayit);
            this.pnl_kayit.Controls.Add(this.pct_kayit);
            this.pnl_kayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_kayit.Location = new System.Drawing.Point(182, 149);
            this.pnl_kayit.Name = "pnl_kayit";
            this.pnl_kayit.Size = new System.Drawing.Size(145, 50);
            this.pnl_kayit.TabIndex = 9;
            // 
            // lbl_kayit
            // 
            this.lbl_kayit.AutoSize = true;
            this.lbl_kayit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kayit.ForeColor = System.Drawing.Color.White;
            this.lbl_kayit.Location = new System.Drawing.Point(57, 11);
            this.lbl_kayit.Name = "lbl_kayit";
            this.lbl_kayit.Size = new System.Drawing.Size(53, 16);
            this.lbl_kayit.TabIndex = 9;
            this.lbl_kayit.Text = "Kayıt Ol";
            this.lbl_kayit.Click += new System.EventHandler(this.pct_kayit_Click);
            this.lbl_kayit.MouseLeave += new System.EventHandler(this.pct_kayit_MouseLeave);
            this.lbl_kayit.MouseHover += new System.EventHandler(this.pct_kayit_MouseHover);
            // 
            // pct_kayit
            // 
            this.pct_kayit.Image = ((System.Drawing.Image)(resources.GetObject("pct_kayit.Image")));
            this.pct_kayit.Location = new System.Drawing.Point(2, 3);
            this.pct_kayit.Name = "pct_kayit";
            this.pct_kayit.Size = new System.Drawing.Size(140, 35);
            this.pct_kayit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_kayit.TabIndex = 8;
            this.pct_kayit.TabStop = false;
            this.pct_kayit.Click += new System.EventHandler(this.pct_kayit_Click);
            this.pct_kayit.MouseLeave += new System.EventHandler(this.pct_kayit_MouseLeave);
            this.pct_kayit.MouseHover += new System.EventHandler(this.pct_kayit_MouseHover);
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 223);
            this.Controls.Add(this.pnl_kayit);
            this.Controls.Add(this.pnl_giris);
            this.Controls.Add(this.lbl_secilen);
            this.Controls.Add(this.pct_kucult);
            this.Controls.Add(this.pct_kapat);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_tc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisYap";
            this.Load += new System.EventHandler(this.GirisYap_Load);
            this.Shown += new System.EventHandler(this.GirisYap_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kucult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_giris)).EndInit();
            this.pnl_giris.ResumeLayout(false);
            this.pnl_giris.PerformLayout();
            this.pnl_kayit.ResumeLayout(false);
            this.pnl_kayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.PictureBox pct_kapat;
        private System.Windows.Forms.PictureBox pct_kucult;
        private System.Windows.Forms.Label lbl_secilen;
        private System.Windows.Forms.PictureBox pct_giris;
        private System.Windows.Forms.Panel pnl_giris;
        private System.Windows.Forms.Panel pnl_kayit;
        private System.Windows.Forms.PictureBox pct_kayit;
        private System.Windows.Forms.Label lbl_giris;
        private System.Windows.Forms.Label lbl_kayit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}