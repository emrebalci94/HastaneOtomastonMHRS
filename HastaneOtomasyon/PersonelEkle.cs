using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }

        private void txt_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {
            if (txt_tc.TextLength == 11)
            {
                if (KontrolIslemleri.TcKontrol(txt_tc.Text))
                {

                    pct_tckontrol.ImageLocation = @"images\onay.png";
                    toolTip1.SetToolTip(this.pct_tckontrol, "Bu T.C kullanılmaya uygun.");
                }
                else
                {

                    pct_tckontrol.ImageLocation = @"images\hata.png";
                    toolTip1.SetToolTip(this.pct_tckontrol, "Böyle bir T.C zaten kullanılmakta.");
                }
            }
            else
            {

                pct_tckontrol.ImageLocation = @"images\hata.png";
                toolTip1.SetToolTip(this.pct_tckontrol, "Bu T.C formata aykırı.");
            }
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

        private void cmb_personeltip_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.cmb_personeltip, "Bu cinsiyet kullanılmaya uygun.");
            pct_personeltipkontrol.ImageLocation = @"images\onay.png";
            if (cmb_personeltip.SelectedIndex!=0)
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

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            pct_resim.ImageLocation = @"images\fotoYok.png";
            try
            {
                ListelemeIslemleri.personelTipComboDoldur(cmb_personeltip);
                cmb_personeltip.SelectedIndex = 0;
            }
            catch (Exception)
            {

                pct_personeltipkontrol.ImageLocation = @"images\hata.png";
            }
        }
        string resimYolu;
        private void pct_resim_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Jpg (*.jpg)|*.jpg|Png (*.png)|*.png";
            op.Title = "Lütfen bir resim seçiniz.";
            if (op.ShowDialog() == DialogResult.OK)
            {
                resimYolu = op.FileName;
                pct_resim.ImageLocation = op.FileName;
            }
        }
        private void Temizle()
        {
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_tc.Clear();
            txt_sifre.Clear();
            cmb_personeltip.SelectedIndex = 0;
            pct_resim.ImageLocation = @"images\fotoYok.png";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt Edilsin mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pct_sifrekontrol.ImageLocation == @"images\onay.png" && pct_adkontrol.ImageLocation == @"images\onay.png" && pct_soyadkontrol.ImageLocation == @"images\onay.png" && pct_tckontrol.ImageLocation == @"images\onay.png" && pct_personeltipkontrol.ImageLocation == @"images\onay.png")
                {
                    try
                    {
                        Personel p = new Personel();
                        p.Tc = txt_tc.Text;
                        p.Ad = txt_ad.Text;
                        p.Soyad = txt_soyad.Text;
                        p.Sifre = txt_sifre.Text;
                        p.CreateDate = DateTime.Now;
                        p.PersonelTipId = int.Parse(cmb_personeltip.SelectedValue.ToString());
                        p.FotoPath = resimYolu;
                        DbIslemleri.PersonelKayit(p);
                        Anaform.anaForm.lbl_mrRobot.Text = "Kayıt işlemi başarıyla gerçekleşti.";
                        Temizle();
                            
                    }
                    catch (Exception ex)
                    {
                        
                        Anaform.anaForm.lbl_mrRobot.Text = ex.Message;
                        Temizle();
                    }
                }
                else
                {
                    Anaform.anaForm.lbl_mrRobot.Text = "Lütfen bilgilerinizi kontrol ediniz.";
                }
            }
        }
    }
}
