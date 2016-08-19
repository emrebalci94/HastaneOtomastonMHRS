namespace HastaneOtomasyon
{
    partial class PersonelSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelSil));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.cmb_secim = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_ustLineAcik = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pct_kapat = new System.Windows.Forms.PictureBox();
            this.dgt_liste = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_ustLineAcik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_liste)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_arama);
            this.groupBox1.Controls.Add(this.cmb_secim);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(73, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 92);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Ayarı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "göre Ara:";
            // 
            // txt_arama
            // 
            this.txt_arama.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_arama.ForeColor = System.Drawing.Color.White;
            this.txt_arama.Location = new System.Drawing.Point(219, 40);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(157, 20);
            this.txt_arama.TabIndex = 8;
            this.txt_arama.TextChanged += new System.EventHandler(this.txt_arama_TextChanged);
            // 
            // cmb_secim
            // 
            this.cmb_secim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_secim.FormattingEnabled = true;
            this.cmb_secim.Items.AddRange(new object[] {
            "T.C Kimlik",
            "Ad",
            "Soyad"});
            this.cmb_secim.Location = new System.Drawing.Point(15, 40);
            this.cmb_secim.Name = "cmb_secim";
            this.cmb_secim.Size = new System.Drawing.Size(108, 21);
            this.cmb_secim.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(110)))), ((int)(((byte)(103)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 10);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_ustLineAcik
            // 
            this.pnl_ustLineAcik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(117)))));
            this.pnl_ustLineAcik.Controls.Add(this.label1);
            this.pnl_ustLineAcik.Controls.Add(this.pct_kapat);
            this.pnl_ustLineAcik.Location = new System.Drawing.Point(0, 0);
            this.pnl_ustLineAcik.Name = "pnl_ustLineAcik";
            this.pnl_ustLineAcik.Size = new System.Drawing.Size(566, 39);
            this.pnl_ustLineAcik.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "PERSONEL SİL\r\n";
            // 
            // pct_kapat
            // 
            this.pct_kapat.BackColor = System.Drawing.Color.Transparent;
            this.pct_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_kapat.Image = ((System.Drawing.Image)(resources.GetObject("pct_kapat.Image")));
            this.pct_kapat.Location = new System.Drawing.Point(508, 3);
            this.pct_kapat.Name = "pct_kapat";
            this.pct_kapat.Size = new System.Drawing.Size(30, 30);
            this.pct_kapat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_kapat.TabIndex = 8;
            this.pct_kapat.TabStop = false;
            this.pct_kapat.Click += new System.EventHandler(this.pct_kapat_Click);
            // 
            // dgt_liste
            // 
            this.dgt_liste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgt_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgt_liste.ContextMenuStrip = this.contextMenuStrip1;
            this.dgt_liste.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgt_liste.Location = new System.Drawing.Point(12, 162);
            this.dgt_liste.Name = "dgt_liste";
            this.dgt_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgt_liste.Size = new System.Drawing.Size(544, 150);
            this.dgt_liste.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // PersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(568, 336);
            this.Controls.Add(this.dgt_liste);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_ustLineAcik);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelSil";
            this.Text = "PersonelSil";
            this.Load += new System.EventHandler(this.PersonelSil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_ustLineAcik.ResumeLayout(false);
            this.pnl_ustLineAcik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgt_liste)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.ComboBox cmb_secim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_ustLineAcik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pct_kapat;
        private System.Windows.Forms.DataGridView dgt_liste;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
    }
}