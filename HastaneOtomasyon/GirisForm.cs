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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pct_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Admin Girişi:Herhangi giriş kısmından TC kimlik:1 Şifre:admin yazarak giriş yapabilirsin
        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_tarih.BackColor = Color.FromArgb(62, 125, 117);
        }
        public static bool girisDurum;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (girisDurum)
            {
                this.Hide();
            }
            lbl_saat.Text =DateTime.Now.ToLongTimeString();
            lbl_tarih.Text = DateTime.Now.ToShortDateString();
            if (opacity)
            {
                this.Opacity = 100;
            }

        }

        private void pct_koyu_Click(object sender, EventArgs e)
        {
      
            secim = 1;
            this.BackColor = Color.FromArgb(32, 56, 61);
            pct_koyu.Width = 30;
            pct_koyu.Height = 30;
            pct_mavi.Width = 25;
            pct_mavi.Height = 25;
            pct_yesil.Width = 25;
            pct_yesil.Height = 25;
            pct_logo.ImageLocation = @"images\GirisSayfasi\KoyuTasarim\medicIcon.png";
            pct_line.ImageLocation = @"images\GirisSayfasi\KoyuTasarim\ustSekil.png";
            pct_doktor.ImageLocation = @"images\GirisSayfasi\KoyuTasarim\doktorButon.png";
            pct_hasta.ImageLocation= @"images\GirisSayfasi\KoyuTasarim\hastaButon.png";
            pct_baslik.ImageLocation= @"images\GirisSayfasi\KoyuTasarim\girisYapiniz.png";
            pct_kapat.ImageLocation= @"images\GirisSayfasi\KoyuTasarim\kapatButonu.png";
            pct_ustLineAcik.ImageLocation= @"images\GirisSayfasi\KoyuTasarim\ustLineAcik.png";
            pct_ustLineKoyu.ImageLocation = @"images\GirisSayfasi\KoyuTasarim\ustLineKoyu.png";
            lbl_tarih.BackColor = Color.FromArgb(62, 125, 117);
            pct_kapat.BackColor= Color.FromArgb(62, 125, 117);
            pct_kucult.BackColor= Color.FromArgb(62, 125, 117);
        }

        private void pct_mavi_Click(object sender, EventArgs e)
        {
  
            secim = 2;
            this.BackColor = Color.FromArgb(6, 131, 139);
            pct_koyu.Width = 25;
            pct_koyu.Height = 25;
            pct_mavi.Width = 30;
            pct_mavi.Height = 30;
            pct_yesil.Width = 25;
            pct_yesil.Height = 25;
            pct_logo.ImageLocation = @"images\GirisSayfasi\MaviTasarim\medicIcon.png";
            pct_line.ImageLocation = @"images\GirisSayfasi\MaviTasarim\ustSekil.png";
            pct_doktor.ImageLocation = @"images\GirisSayfasi\MaviTasarim\doktorButon.png";
            pct_hasta.ImageLocation = @"images\GirisSayfasi\MaviTasarim\hastaButon.png";
            pct_baslik.ImageLocation = @"images\GirisSayfasi\MaviTasarim\girisYapiniz.png";
            pct_kapat.ImageLocation = @"images\GirisSayfasi\MaviTasarim\kapatButonu.png";
            pct_ustLineAcik.ImageLocation = @"images\GirisSayfasi\MaviTasarim\ustLineAcik.png";
            pct_ustLineKoyu.ImageLocation = @"images\GirisSayfasi\MaviTasarim\ustLineKoyu.png";
            lbl_tarih.BackColor = Color.FromArgb(17, 176, 188);
            pct_kapat.BackColor = Color.FromArgb(17, 176, 188);
            pct_kucult.BackColor = Color.FromArgb(17, 176, 188);
        }

        private void pct_yesil_Click(object sender, EventArgs e)
        {
            secim = 3;
            this.BackColor = Color.FromArgb(6, 138, 74);
            pct_koyu.Width = 25;
            pct_koyu.Height = 25;
            pct_mavi.Width = 25;
            pct_mavi.Height = 25;
            pct_yesil.Width = 30;
            pct_yesil.Height = 30;
            pct_logo.ImageLocation = @"images\GirisSayfasi\YesilTasarim\medicIcon.png";
            pct_line.ImageLocation = @"images\GirisSayfasi\YesilTasarim\ustSekil.png";
            pct_doktor.ImageLocation = @"images\GirisSayfasi\YesilTasarim\doktorButon.png";
            pct_hasta.ImageLocation = @"images\GirisSayfasi\YesilTasarim\hastaButon.png";
            pct_baslik.ImageLocation = @"images\GirisSayfasi\YesilTasarim\girisYapiniz.png";
            pct_kapat.ImageLocation = @"images\GirisSayfasi\YesilTasarim\kapatButonu.png";
            pct_ustLineAcik.ImageLocation = @"images\GirisSayfasi\YesilTasarim\ustLineAcik.png";
            pct_ustLineKoyu.ImageLocation = @"images\GirisSayfasi\YesilTasarim\ustLineKoyu.png";
            lbl_tarih.BackColor = Color.FromArgb(43, 196, 84);
            pct_kapat.BackColor = Color.FromArgb(43, 196, 84);
            pct_kucult.BackColor = Color.FromArgb(43, 196, 84);
        }
        int secim = 1;
        private void pct_doktor_MouseHover(object sender, EventArgs e)
        {
            pct_doktor.ImageLocation= @"images\GirisSayfasi\doktorButonBeyaz.png";
        }

        private void pct_doktor_MouseLeave(object sender, EventArgs e)
        {
            if (secim==1)
            {
                pct_doktor.ImageLocation = @"images\GirisSayfasi\KoyuTasarim\doktorButon.png";
            }
            else if (secim==2)
            {
                pct_doktor.ImageLocation = @"images\GirisSayfasi\MaviTasarim\doktorButon.png";
            }
            else if (secim==3)
            {
                pct_doktor.ImageLocation = @"images\GirisSayfasi\YesilTasarim\doktorButon.png";
            }
            
        }

        private void pct_hasta_MouseHover(object sender, EventArgs e)
        {
            pct_hasta.ImageLocation = @"images\GirisSayfasi\hastaButonBeyaz.png";
        }

        private void pct_hasta_MouseLeave(object sender, EventArgs e)
        {
            if (secim == 1)
            {
                pct_hasta.ImageLocation = @"images\GirisSayfasi\KoyuTasarim\hastaButon.png";
            }
            else if (secim == 2)
            {
                pct_hasta.ImageLocation = @"images\GirisSayfasi\MaviTasarim\hastaButon.png";
            }
            else if (secim == 3)
            {
                pct_hasta.ImageLocation = @"images\GirisSayfasi\YesilTasarim\hastaButon.png";
            }

        }
        public static bool opacity = false;
        private void pct_doktor_Click(object sender, EventArgs e)
        {
            this.Opacity -= 0.6;
            opacity = false;
            GirisYap g = new GirisYap();
            g.tema = secim;
            g.butonSecim = 1;
            g.ShowDialog();
        }

        private void pct_hasta_Click(object sender, EventArgs e)
        {
            this.Opacity -= 0.6;
            opacity = false;
            GirisYap g = new GirisYap();
            g.tema = secim;
            g.butonSecim = 2;
            g.ShowDialog();
        }

        private void GirisForm_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Opacity = 100;
            MessageBox.Show("Test");
        }
    }
}
