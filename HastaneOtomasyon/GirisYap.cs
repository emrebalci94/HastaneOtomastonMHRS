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
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }
        public  int tema=1;
        public int butonSecim;
        private void GirisYap_Load(object sender, EventArgs e)
        {

        }

        private void GirisYap_Shown(object sender, EventArgs e)
        {
            if (tema == 1)
            {
                this.BackColor = Color.FromArgb(32, 56, 61);
                txt_sifre.BackColor = Color.FromArgb(32, 56, 61);
                txt_tc.BackColor = Color.FromArgb(32, 56, 61);
                pct_kapat.ImageLocation = @"images\GirisSayfasi\KoyuTasarim\kapatButonu.png";
                pct_giris.ImageLocation= @"images\GirisSayfasi\KoyuTasarim\girisYap.png";
                pct_kayit.ImageLocation= @"images\GirisSayfasi\KoyuTasarim\kayitOl.png";
                lbl_giris.BackColor = Color.FromArgb(0, 134, 132);
                lbl_kayit.BackColor = Color.FromArgb(0, 134, 132);
            }
            else if (tema == 2)
            {
                this.BackColor = Color.FromArgb(6, 131, 139);
                txt_sifre.BackColor = Color.FromArgb(6, 131, 139);
                txt_tc.BackColor = Color.FromArgb(6, 131, 139);
                pct_kapat.ImageLocation = @"images\GirisSayfasi\MaviTasarim\kapatButonu.png";
                pct_giris.ImageLocation = @"images\GirisSayfasi\MaviTasarim\girisYap.png";
                pct_kayit.ImageLocation = @"images\GirisSayfasi\MaviTasarim\kayitOl.png";
                lbl_giris.BackColor = Color.FromArgb(93, 161, 140);
                lbl_kayit.BackColor = Color.FromArgb(93, 161, 140);
            }
            else if (tema == 3)
            {
                this.BackColor = Color.FromArgb(6, 138, 74);
                txt_sifre.BackColor = Color.FromArgb(6, 138, 74);
                txt_tc.BackColor = Color.FromArgb(6, 138, 74);
                pct_kapat.ImageLocation = @"images\GirisSayfasi\YesilTasarim\kapatButonu.png";
                pct_giris.ImageLocation = @"images\GirisSayfasi\YesilTasarim\girisYap.png";
                pct_kayit.ImageLocation = @"images\GirisSayfasi\YesilTasarim\kayitOl.png";
                lbl_giris.BackColor = Color.FromArgb(135, 207, 87);
                lbl_kayit.BackColor = Color.FromArgb(135, 207, 87);
            }


            if (butonSecim==1)
            {
                lbl_secilen.Text = "Doktor Girişi";
                pnl_kayit.Visible = false;
                pnl_giris.Left += 75;
            }
            else
            {
                lbl_secilen.Text = "Hasta Girişi";
            }
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            GirisForm.opacity = true;

            this.Close();
         
        }

        private void pct_giris_MouseHover(object sender, EventArgs e)
        {
            lbl_giris.Font = new Font(lbl_giris.Font, FontStyle.Italic);
        }

        private void pct_giris_MouseLeave(object sender, EventArgs e)
        {
            lbl_giris.Font = new Font(lbl_giris.Font, FontStyle.Regular);
        }

        private void pct_kayit_MouseHover(object sender, EventArgs e)
        {
            lbl_kayit.Font = new Font(lbl_kayit.Font, FontStyle.Italic);
        }

        private void pct_kayit_MouseLeave(object sender, EventArgs e)
        {
            lbl_kayit.Font = new Font(lbl_kayit.Font, FontStyle.Regular);
        }

        private void pct_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        Hasta girilenHasta;
        Personel girilenDoktor;
        private void pct_giris_Click(object sender, EventArgs e)
        {
            Anaform ana = new Anaform();
            if (txt_tc.Text=="1" && txt_sifre.Text=="admin")
            {
                ana.adminDurum = true;
                ana.Show();
                this.Hide();
                GirisForm.girisDurum = true;
            }
            else
            {
                if (butonSecim !=1)//Hasta
                {
                  girilenHasta=  KontrolIslemleri.HastaGiris(txt_tc.Text,txt_sifre.Text);
                    if (girilenHasta!=null)
                    {
                        ana.girilenHasta = girilenHasta;
                        ana.Show();
                        this.Close();
                        GirisForm.girisDurum = true;
                    }
                    else
                    {
                        MessageBox.Show("TC veya Şifre uyuşmamaktadır...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else//Doktor
                {
                    
                    girilenDoktor = KontrolIslemleri.DoktorGiris(txt_tc.Text, txt_sifre.Text);
                    if (girilenDoktor!=null)
                    {
                        GirisForm.girisDurum = true;
                        ana.girilenPersonel = girilenDoktor;
                        ana.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("TC veya Şifre uyuşmamaktadır...", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pct_kayit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hasta Kayıt Formuna Gidilsin mi?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                HastaKayit h = new HastaKayit();
                h.tema = tema;
                h.ShowDialog();
                this.Close();
            }
        }
    }
}
