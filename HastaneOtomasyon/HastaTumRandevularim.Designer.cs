namespace HastaneOtomasyon
{
    partial class HastaTumRandevularim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaTumRandevularim));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_ustLineAcik = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pct_kapat = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_secim = new System.Windows.Forms.ComboBox();
            this.dt_tarih1 = new System.Windows.Forms.DateTimePicker();
            this.dt_tarih2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dtg_liste = new System.Windows.Forms.DataGridView();
            this.txt_arama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_ustLineAcik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_liste)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(110)))), ((int)(((byte)(103)))));
            this.pictureBox1.Location = new System.Drawing.Point(1, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(563, 10);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_ustLineAcik
            // 
            this.pnl_ustLineAcik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(117)))));
            this.pnl_ustLineAcik.Controls.Add(this.label1);
            this.pnl_ustLineAcik.Controls.Add(this.pct_kapat);
            this.pnl_ustLineAcik.Location = new System.Drawing.Point(1, -1);
            this.pnl_ustLineAcik.Name = "pnl_ustLineAcik";
            this.pnl_ustLineAcik.Size = new System.Drawing.Size(562, 39);
            this.pnl_ustLineAcik.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÜM RANDEVULARIM";
            // 
            // pct_kapat
            // 
            this.pct_kapat.BackColor = System.Drawing.Color.Transparent;
            this.pct_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_kapat.Image = ((System.Drawing.Image)(resources.GetObject("pct_kapat.Image")));
            this.pct_kapat.Location = new System.Drawing.Point(522, 5);
            this.pct_kapat.Name = "pct_kapat";
            this.pct_kapat.Size = new System.Drawing.Size(30, 30);
            this.pct_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_kapat.TabIndex = 8;
            this.pct_kapat.TabStop = false;
            this.pct_kapat.Click += new System.EventHandler(this.pct_kapat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_arama);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dt_tarih2);
            this.groupBox1.Controls.Add(this.dt_tarih1);
            this.groupBox1.Controls.Add(this.cmb_secim);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(62, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 102);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // cmb_secim
            // 
            this.cmb_secim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_secim.FormattingEnabled = true;
            this.cmb_secim.Items.AddRange(new object[] {
            "Tümü",
            "Tarihler Arasında",
            "Doktor Adına"});
            this.cmb_secim.Location = new System.Drawing.Point(21, 36);
            this.cmb_secim.Name = "cmb_secim";
            this.cmb_secim.Size = new System.Drawing.Size(136, 21);
            this.cmb_secim.TabIndex = 0;
            this.cmb_secim.SelectedIndexChanged += new System.EventHandler(this.cmb_secim_SelectedIndexChanged);
            // 
            // dt_tarih1
            // 
            this.dt_tarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tarih1.Location = new System.Drawing.Point(174, 37);
            this.dt_tarih1.Name = "dt_tarih1";
            this.dt_tarih1.Size = new System.Drawing.Size(97, 20);
            this.dt_tarih1.TabIndex = 1;
            this.dt_tarih1.Visible = false;
            // 
            // dt_tarih2
            // 
            this.dt_tarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tarih2.Location = new System.Drawing.Point(288, 37);
            this.dt_tarih2.Name = "dt_tarih2";
            this.dt_tarih2.Size = new System.Drawing.Size(97, 20);
            this.dt_tarih2.TabIndex = 2;
            this.dt_tarih2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(163, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Uygula";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtg_liste
            // 
            this.dtg_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_liste.Location = new System.Drawing.Point(12, 180);
            this.dtg_liste.Name = "dtg_liste";
            this.dtg_liste.Size = new System.Drawing.Size(541, 150);
            this.dtg_liste.TabIndex = 7;
            this.dtg_liste.Visible = false;
            // 
            // txt_arama
            // 
            this.txt_arama.ForeColor = System.Drawing.Color.White;
            this.txt_arama.Location = new System.Drawing.Point(182, 36);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(197, 20);
            this.txt_arama.TabIndex = 4;
            // 
            // HastaTumRandevularim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(565, 353);
            this.Controls.Add(this.dtg_liste);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_ustLineAcik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HastaTumRandevularim";
            this.Text = "HastaTumRandevularim";
            this.Load += new System.EventHandler(this.HastaTumRandevularim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_ustLineAcik.ResumeLayout(false);
            this.pnl_ustLineAcik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_ustLineAcik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pct_kapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dt_tarih2;
        private System.Windows.Forms.DateTimePicker dt_tarih1;
        private System.Windows.Forms.ComboBox cmb_secim;
        private System.Windows.Forms.DataGridView dtg_liste;
        private System.Windows.Forms.TextBox txt_arama;
    }
}