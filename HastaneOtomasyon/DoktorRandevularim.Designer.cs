namespace HastaneOtomasyon
{
    partial class DoktorRandevularim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorRandevularim));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_ustLineAcik = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pct_kapat = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_secim = new System.Windows.Forms.ComboBox();
            this.txt_arama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_liste = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.recete_yaz = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_ustLineAcik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_liste)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(110)))), ((int)(((byte)(103)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 15);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_ustLineAcik
            // 
            this.pnl_ustLineAcik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(125)))), ((int)(((byte)(117)))));
            this.pnl_ustLineAcik.Controls.Add(this.label1);
            this.pnl_ustLineAcik.Controls.Add(this.pct_kapat);
            this.pnl_ustLineAcik.Location = new System.Drawing.Point(0, -4);
            this.pnl_ustLineAcik.Name = "pnl_ustLineAcik";
            this.pnl_ustLineAcik.Size = new System.Drawing.Size(663, 44);
            this.pnl_ustLineAcik.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "RANDEVULARIM";
            // 
            // pct_kapat
            // 
            this.pct_kapat.BackColor = System.Drawing.Color.Transparent;
            this.pct_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pct_kapat.Image = ((System.Drawing.Image)(resources.GetObject("pct_kapat.Image")));
            this.pct_kapat.Location = new System.Drawing.Point(619, 5);
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_arama);
            this.groupBox1.Controls.Add(this.cmb_secim);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(141, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrele";
            // 
            // cmb_secim
            // 
            this.cmb_secim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_secim.FormattingEnabled = true;
            this.cmb_secim.Items.AddRange(new object[] {
            "Bugünkü Randevularım",
            "Gelecek Randevularım"});
            this.cmb_secim.Location = new System.Drawing.Point(21, 37);
            this.cmb_secim.Name = "cmb_secim";
            this.cmb_secim.Size = new System.Drawing.Size(146, 21);
            this.cmb_secim.TabIndex = 0;
            // 
            // txt_arama
            // 
            this.txt_arama.ForeColor = System.Drawing.Color.White;
            this.txt_arama.Location = new System.Drawing.Point(179, 37);
            this.txt_arama.Name = "txt_arama";
            this.txt_arama.Size = new System.Drawing.Size(155, 20);
            this.txt_arama.TabIndex = 1;
            this.txt_arama.TextChanged += new System.EventHandler(this.txt_arama_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta Adı ";
            // 
            // dt_liste
            // 
            this.dt_liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_liste.ContextMenuStrip = this.contextMenuStrip1;
            this.dt_liste.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dt_liste.Location = new System.Drawing.Point(46, 161);
            this.dt_liste.Name = "dt_liste";
            this.dt_liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_liste.Size = new System.Drawing.Size(555, 169);
            this.dt_liste.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dt_liste, "Reçete Yazmak için sağ tıklayın...");
            this.dt_liste.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recete_yaz,
            this.yenileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 48);
            // 
            // recete_yaz
            // 
            this.recete_yaz.Name = "recete_yaz";
            this.recete_yaz.Size = new System.Drawing.Size(152, 22);
            this.recete_yaz.Text = "Reçete Yaz";
            this.recete_yaz.Click += new System.EventHandler(this.recete_yaz_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            // 
            // DoktorRandevularim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(661, 365);
            this.Controls.Add(this.dt_liste);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_ustLineAcik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoktorRandevularim";
            this.Text = "DoktorRandevularim";
            this.Load += new System.EventHandler(this.DoktorRandevularim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_ustLineAcik.ResumeLayout(false);
            this.pnl_ustLineAcik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_kapat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_liste)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_ustLineAcik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pct_kapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_arama;
        private System.Windows.Forms.ComboBox cmb_secim;
        private System.Windows.Forms.DataGridView dt_liste;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recete_yaz;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}