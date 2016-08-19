namespace HastaneOtomasyon
{
    partial class DoktorHastam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorHastam));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_ustLineAcik = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pct_kapat = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.cmb_arama = new System.Windows.Forms.ComboBox();
            this.dt_liste = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_teshisTarih = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_doktor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_teshis = new System.Windows.Forms.TextBox();
            this.txt_cinsiyet = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_ustLineAcik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_liste)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(110)))), ((int)(((byte)(103)))));
            this.pictureBox1.Location = new System.Drawing.Point(2, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 10);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_ustLineAcik
            // 
            this.pnl_ustLineAcik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(117)))));
            this.pnl_ustLineAcik.Controls.Add(this.label1);
            this.pnl_ustLineAcik.Controls.Add(this.pct_kapat);
            this.pnl_ustLineAcik.Location = new System.Drawing.Point(2, 0);
            this.pnl_ustLineAcik.Name = "pnl_ustLineAcik";
            this.pnl_ustLineAcik.Size = new System.Drawing.Size(415, 39);
            this.pnl_ustLineAcik.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(144, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "HASTALARIM";
            // 
            // pct_kapat
            // 
            this.pct_kapat.BackColor = System.Drawing.Color.Transparent;
            this.pct_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_kapat.Image = ((System.Drawing.Image)(resources.GetObject("pct_kapat.Image")));
            this.pct_kapat.Location = new System.Drawing.Point(375, 0);
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
            this.groupBox1.Controls.Add(this.cmb_arama);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(77, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 71);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // txt_arama
            // 
            this.txt_arama.Location = new System.Drawing.Point(129, 25);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(129, 20);
            this.txt_arama.TabIndex = 1;
            this.txt_arama.TextChanged += new System.EventHandler(this.txt_arama_TextChanged);
            // 
            // cmb_arama
            // 
            this.cmb_arama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_arama.FormattingEnabled = true;
            this.cmb_arama.Items.AddRange(new object[] {
            "Hasta Adı",
            "Tc Kimlik"});
            this.cmb_arama.Location = new System.Drawing.Point(6, 25);
            this.cmb_arama.Name = "cmb_arama";
            this.cmb_arama.Size = new System.Drawing.Size(107, 21);
            this.cmb_arama.TabIndex = 0;
            // 
            // dt_liste
            // 
            this.dt_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_liste.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dt_liste.Location = new System.Drawing.Point(12, 132);
            this.dt_liste.Name = "dt_liste";
            this.dt_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_liste.Size = new System.Drawing.Size(383, 169);
            this.dt_liste.TabIndex = 13;
            this.dt_liste.Visible = false;
            this.dt_liste.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_liste_CellContentDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.txt_teshisTarih);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_doktor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_teshis);
            this.groupBox2.Controls.Add(this.txt_cinsiyet);
            this.groupBox2.Controls.Add(this.txt_soyad);
            this.groupBox2.Controls.Add(this.txt_ad);
            this.groupBox2.Controls.Add(this.txt_tc);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(22, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 322);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Bilgileri";
            this.groupBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(112)))));
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(165, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "Yazdır";
            this.label9.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(104, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txt_teshisTarih
            // 
            this.txt_teshisTarih.Enabled = false;
            this.txt_teshisTarih.Location = new System.Drawing.Point(78, 244);
            this.txt_teshisTarih.Name = "txt_teshisTarih";
            this.txt_teshisTarih.Size = new System.Drawing.Size(245, 20);
            this.txt_teshisTarih.TabIndex = 24;
            this.txt_teshisTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Teşhis Tarihi:";
            // 
            // txt_doktor
            // 
            this.txt_doktor.Enabled = false;
            this.txt_doktor.Location = new System.Drawing.Point(78, 207);
            this.txt_doktor.Name = "txt_doktor";
            this.txt_doktor.Size = new System.Drawing.Size(245, 20);
            this.txt_doktor.TabIndex = 22;
            this.txt_doktor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Son Doktoru:";
            // 
            // txt_teshis
            // 
            this.txt_teshis.Enabled = false;
            this.txt_teshis.Location = new System.Drawing.Point(78, 169);
            this.txt_teshis.Name = "txt_teshis";
            this.txt_teshis.Size = new System.Drawing.Size(245, 20);
            this.txt_teshis.TabIndex = 20;
            this.txt_teshis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_cinsiyet
            // 
            this.txt_cinsiyet.Enabled = false;
            this.txt_cinsiyet.Location = new System.Drawing.Point(78, 134);
            this.txt_cinsiyet.Name = "txt_cinsiyet";
            this.txt_cinsiyet.Size = new System.Drawing.Size(245, 20);
            this.txt_cinsiyet.TabIndex = 19;
            this.txt_cinsiyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Enabled = false;
            this.txt_soyad.Location = new System.Drawing.Point(78, 99);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(245, 20);
            this.txt_soyad.TabIndex = 18;
            this.txt_soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ad
            // 
            this.txt_ad.Enabled = false;
            this.txt_ad.Location = new System.Drawing.Point(78, 64);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(245, 20);
            this.txt_ad.TabIndex = 17;
            this.txt_ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tc
            // 
            this.txt_tc.Enabled = false;
            this.txt_tc.Location = new System.Drawing.Point(78, 29);
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(245, 20);
            this.txt_tc.TabIndex = 16;
            this.txt_tc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Son Teşhis:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cinsiyet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tc Kimlik:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(15, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(383, 169);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // DoktorHastam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(423, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dt_liste);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_ustLineAcik);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoktorHastam";
            this.Text = "DoktorHastam";
            this.Load += new System.EventHandler(this.DoktorHastam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_ustLineAcik.ResumeLayout(false);
            this.pnl_ustLineAcik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_liste)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_ustLineAcik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pct_kapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.ComboBox cmb_arama;
        private System.Windows.Forms.DataGridView dt_liste;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_doktor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_teshis;
        private System.Windows.Forms.TextBox txt_cinsiyet;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_teshisTarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}