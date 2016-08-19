using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace HastaneOtomasyon
{
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            
            dgt_liste.Left += 40;
            dgt_liste.BackgroundColor = this.BackColor;
            cmb_secim.SelectedIndex = 0;
            txt_arama.BackColor = this.BackColor;
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_arama.Text = "";
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            dgt_liste.Visible = true;
            pnl_bilgiler.Visible = false;
            if (cmb_secim.SelectedIndex==0)
            {
              dgt_liste.DataSource=  ListelemeIslemleri.personelTcArama(txt_arama.Text);
            }
            else if (cmb_secim.SelectedIndex == 1)
            {
                dgt_liste.DataSource = ListelemeIslemleri.personelAdArama(txt_arama.Text);
            }
            else
            {
                dgt_liste.DataSource = ListelemeIslemleri.personelSoyadArama(txt_arama.Text);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Personel guncellenicek;
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guncellenicek=KontrolIslemleri.PersonelAra( dgt_liste.SelectedRows[0].Cells[0].Value.ToString());
            if (guncellenicek!=null)
            {
                ListelemeIslemleri.personelTipComboDoldur(cmb_personeltip);
                dgt_liste.Visible = false;
                pnl_bilgiler.Visible = true;
                txt_ad.Text = guncellenicek.Ad;
                txt_tc.Text = guncellenicek.Tc;
                txt_soyad.Text = guncellenicek.Soyad;
                txt_sifre.Text = guncellenicek.Sifre;
                if (File.Exists(guncellenicek.FotoPath))
                {
                    pct_resim.ImageLocation = guncellenicek.FotoPath;
                }
                else
                {
                    pct_resim.ImageLocation = @"images\fotoYok.png"; 
                }
                cmb_personeltip.SelectedValue = guncellenicek.PersonelTipId;
                
            }
            else
            {
                Anaform.anaForm.lbl_mrRobot.Text = "Lütfen güncellenecek personeli\ndüzgün seçtiğinizden emin\nolun.";
            }
            
        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {
            pct_tckontrol.ImageLocation = @"images\onay.png";
          
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {
            if (txt_ad.TextLength > 0)
            {
                pct_adkontrol.ImageLocation = @"images\onay.png";
                toolTip1.SetToolTip(this.pct_tckontrol, "Bu ad kullanılmaya uygun.");
            }
            else
            {
                pct_adkontrol.ImageLocation = @"images\hata.png";
                toolTip1.SetToolTip(this.pct_tckontrol, "Bu ad formata aykırı.");
            }
        }

        private void txt_soyad_TextChanged(object sender, EventArgs e)
        {
            if (txt_soyad.TextLength > 0)
            {

                pct_soyadkontrol.ImageLocation = @"images\onay.png";
                toolTip1.SetToolTip(this.pct_soyadkontrol, "Bu soyad kullanılmaya uygun.");
            }
            else
            {

                pct_soyadkontrol.ImageLocation = @"images\hata.png";
                toolTip1.SetToolTip(this.pct_soyadkontrol, "Bu soyad formata aykırı");
            }
        }

        private void cmb_personeltip_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cmb_personeltip, "Bu cinsiyet kullanılmaya uygun.");
            pct_personeltipkontrol.ImageLocation = @"images\onay.png";
            if (cmb_personeltip.SelectedIndex != 0)
            {
                txt_sifre.Clear();
                txt_sifre.Enabled = false;
                pct_sifrekontrol.ImageLocation = @"images\onay.png";
            }
            else
            {
                txt_sifre.Enabled = true;
                pct_sifrekontrol.ImageLocation = @"images\hata.png";
            }
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            if (txt_sifre.TextLength > 0)
            {

                pct_sifrekontrol.ImageLocation = @"images\onay.png";
                toolTip1.SetToolTip(this.pct_sifrekontrol, "Bu şifre kullanılmaya uygun.");
            }
            else
            {

                pct_sifrekontrol.ImageLocation = @"images\hata.png";
                toolTip1.SetToolTip(this.pct_sifrekontrol, "Bu şifre formata aykırı");
            }
        }

        private void pct_guncelleButon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt Güncellensin mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pct_sifrekontrol.ImageLocation == @"images\onay.png" && pct_adkontrol.ImageLocation == @"images\onay.png" && pct_soyadkontrol.ImageLocation == @"images\onay.png" && pct_tckontrol.ImageLocation == @"images\onay.png" && pct_personeltipkontrol.ImageLocation == @"images\onay.png")
                {
                    try
                    {
                        DbIslemleri.PersonelGuncelle(txt_tc.Text, txt_ad.Text, txt_soyad.Text, int.Parse(cmb_personeltip.SelectedValue.ToString()), pct_resim.ImageLocation, txt_sifre.Text);
                        Anaform.anaForm.lbl_mrRobot.Text = "Güncelleme işlemi başarıyla\n gerçekleşti.";
                        pnl_bilgiler.Visible = false;
                        txt_arama.Text = "";

                    }
                    catch (Exception ex)
                    {
                        Anaform.anaForm.lbl_mrRobot.Text = ex.Message;
                    }
                }
                else
                {
                    Anaform.anaForm.lbl_mrRobot.Text = "Lütfen bilgilerinizi kontrol ediniz.";
                }
            }
        }

        private void pct_resim_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Jpg (*.jpg)|*.jpg|Png (*.png)|*.png";
            op.Title = "Lütfen bir resim seçiniz.";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pct_resim.ImageLocation = op.FileName;
            }
        }
    }
}
