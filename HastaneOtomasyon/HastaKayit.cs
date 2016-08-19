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
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }
        public int tema;
        private void HastaKayit_Shown(object sender, EventArgs e)
        {
            if (tema == 1)
            {
                this.BackColor = Color.FromArgb(32, 56, 61);
                txt_sifre.BackColor = Color.FromArgb(32, 56, 61);
                txt_tc.BackColor = Color.FromArgb(32, 56, 61);
                txt_ad.BackColor = Color.FromArgb(32, 56, 61);
                txt_soyad.BackColor = Color.FromArgb(32, 56, 61);
                pct_kapat.ImageLocation = @"images\GirisSayfasi\KoyuTasarim\kapatButonu.png";
                pct_kayit.ImageLocation = @"images\GirisSayfasi\KoyuTasarim\kayitOl.png";
                lbl_kayit.BackColor = Color.FromArgb(0, 134, 132);
                pct_ustLineAcik.ImageLocation= @"images\GirisSayfasi\KoyuTasarim\ustLineAcik.png";
                pct_ustLineKoyu.ImageLocation = @"images\GirisSayfasi\KoyuTasarim\ustLineKoyu.png";
                pct_kapat.BackColor = Color.FromArgb(62, 125, 117);
                pct_kucult.BackColor = Color.FromArgb(62, 125, 117);
                lbl_baslik.BackColor = Color.FromArgb(62, 125, 117);
            }
            else if (tema == 2)
            {
                this.BackColor = Color.FromArgb(6, 131, 139);
                txt_sifre.BackColor = Color.FromArgb(6, 131, 139);
                txt_tc.BackColor = Color.FromArgb(6, 131, 139);
                txt_ad.BackColor = Color.FromArgb(6, 131, 139);
                txt_soyad.BackColor = Color.FromArgb(6, 131, 139);
                pct_kapat.ImageLocation = @"images\GirisSayfasi\MaviTasarim\kapatButonu.png";
                pct_kayit.ImageLocation = @"images\GirisSayfasi\MaviTasarim\kayitOl.png";
                lbl_kayit.BackColor = Color.FromArgb(93, 161, 140);
                pct_ustLineAcik.ImageLocation = @"images\GirisSayfasi\MaviTasarim\ustLineAcik.png";
                pct_ustLineKoyu.ImageLocation = @"images\GirisSayfasi\MaviTasarim\ustLineKoyu.png";
                pct_kapat.BackColor = Color.FromArgb(17, 176, 188);
                pct_kucult.BackColor = Color.FromArgb(17, 176, 188);
                lbl_baslik.BackColor = Color.FromArgb(17, 176, 188);
            }
            else if (tema == 3)
            {
                this.BackColor = Color.FromArgb(6, 138, 74);
                txt_sifre.BackColor = Color.FromArgb(6, 138, 74);
                txt_tc.BackColor = Color.FromArgb(6, 138, 74);
                txt_ad.BackColor = Color.FromArgb(6, 138, 74);
                txt_soyad.BackColor = Color.FromArgb(6, 138, 74);
                pct_kapat.ImageLocation = @"images\GirisSayfasi\YesilTasarim\kapatButonu.png";
                pct_kayit.ImageLocation = @"images\GirisSayfasi\YesilTasarim\kayitOl.png";
                lbl_kayit.BackColor = Color.FromArgb(135, 207, 87);
                pct_ustLineAcik.ImageLocation = @"images\GirisSayfasi\YesilTasarim\ustLineAcik.png";
                pct_ustLineKoyu.ImageLocation = @"images\GirisSayfasi\YesilTasarim\ustLineKoyu.png";
                pct_kapat.BackColor = Color.FromArgb(43, 196, 84);
                pct_kucult.BackColor = Color.FromArgb(43, 196, 84);
                lbl_baslik.BackColor = Color.FromArgb(43, 196, 84);
            }
        }

        private void HastaKayit_Load(object sender, EventArgs e)
        {
            cmb_cinsiyet.SelectedIndex = 0;
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisForm.opacity = true;
        }

        private void pct_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        bool cinsiyet;
        private void cmb_cinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
  
            toolTip1.SetToolTip(this.pct_cinskontrol, "Bu cinsiyet kullanılmaya uygun.");
            pct_cinskontrol.ImageLocation = @"images\onay.png";
            if (cmb_cinsiyet.SelectedIndex==0)
            {
                cinsiyet = true;
            }
            else
            {
                cinsiyet = false;
            }
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

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {
            if (txt_ad.TextLength>0)
            {
        
                pct_adkontrol.ImageLocation = @"images\onay.png";
                toolTip1.SetToolTip(this.pct_adkontrol, "Bu ad kullanılmaya uygun.");
            }
            else
            {
              
                pct_adkontrol.ImageLocation = @"images\hata.png";
                toolTip1.SetToolTip(this.pct_adkontrol, "Bu ad formata aykırı");
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

        private void dtp_dogum_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan hesap = DateTime.Now.Subtract(dtp_dogum.Value);
            if (hesap.Days > 0)
            {
            
                pct_dtarihkontrol.ImageLocation = @"images\onay.png";
                toolTip1.SetToolTip(this.pct_dtarihkontrol, "Bu doğum tarihi kullanılmaya uygun.");
            }
            else
            {
              
                pct_dtarihkontrol.ImageLocation = @"images\hata.png";
                toolTip1.SetToolTip(this.pct_dtarihkontrol, "Doğum tarihini gelecekten seçemezsin :)");
            }
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            if (txt_sifre.TextLength>0)
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

        private void pct_kayit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt Edilsin mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pct_sifrekontrol.ImageLocation == @"images\onay.png" && pct_adkontrol.ImageLocation == @"images\onay.png" && pct_soyadkontrol.ImageLocation == @"images\onay.png" && pct_tckontrol.ImageLocation == @"images\onay.png" && pct_dtarihkontrol.ImageLocation == @"images\onay.png" && pct_cinskontrol.ImageLocation == @"images\onay.png")
                {
                    try
                    {
                        Hasta h = new Hasta();
                        h.Tc = txt_tc.Text;
                        h.Ad = txt_ad.Text;
                        h.Soyad = txt_soyad.Text;
                        h.Cinsiyet = cinsiyet;
                        h.DogumTarihi = dtp_dogum.Value;
                        h.Password = txt_sifre.Text;
                        h.CreateDate = DateTime.Now;
                        DbIslemleri.HastaKaydet(h);
                        GirisForm.opacity = true;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_ad.Clear();
                        txt_soyad.Clear();
                        txt_tc.Clear();
                        cmb_cinsiyet.SelectedIndex = 0;
                        dtp_dogum.Value = DateTime.Now;
                        txt_sifre.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Bilgilerinizi Kontrol Ediniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private void txt_tc_TextChanged(object sender, EventArgs e)
        {
            if (txt_tc.TextLength==11)
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
    }
}
