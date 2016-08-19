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
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }
        public static Anaform anaForm = new Anaform();
        public bool adminDurum = false;
        public Personel girilenPersonel;
        public Hasta girilenHasta;
        private void Anaform_Load(object sender, EventArgs e)
        {
            //YAPILACAKLAR YADA YAPILABİLİRLER
            //NOT:ÇÖZÜNÜRLÜK 1920:1080 Olarak ayarlandı başka çözünürlüklerde kayma olabilir.
            //Güncelleme Kısmında güncelleme işemi bittikden sonra değişen doktor burdaki girilen doktora paslanabilir.Ancak yanda hakkında bölümünün değişmesi için ekstra metod yazıp onun çalıştırılması gerek.
            //Admin Girişi:Herhangi giriş kısmından TC kimlik:1 Şifre:admin yazarak giriş yapabilirsin

            if (adminDurum)
            {
                pnl_adminMenu.Visible = true;
                pnl_bilgi.Visible = false;
            }
            else if (girilenHasta !=null)
            {
                pnl_hastaMenu.Visible = true;
                lbl_tcbilgi.Text = "T.C Kimlik:      " + girilenHasta.Tc[0].ToString() + "*********" + girilenHasta.Tc[10].ToString();
                lbl_ad.Text = "Ad:              " + girilenHasta.Ad;
                lbl_soyadbilgi.Text = "Soyad:           " + girilenHasta.Soyad;
                lbl_dogumtarihibilgi.Text = "Doğum Tarihi:    " + girilenHasta.DogumTarihi.Value.ToShortDateString();
                if (girilenHasta.Cinsiyet==true)
                {
                    lbl_cinsiyetbilgi.Text = "Cinsiyet:        Erkek";
                }
                else
                {
                    lbl_cinsiyetbilgi.Text = "Cinsiyet:        Kadın";
                }
                lbl_kayittarihibilgi.Text = "Kayıt Tarihi:    " + girilenHasta.CreateDate.ToShortDateString();
             
            }
            else if (girilenPersonel !=null)
            {
                pnl_doktorMenu.Visible = true;
                lbl_cinsiyetbilgi.Visible = false;

                lbl_tcbilgi.Text = "T.C Kimlik:      " + girilenPersonel.Tc[0].ToString() + "*********" + girilenPersonel.Tc[10].ToString();
                lbl_ad.Text = "Ad:               " + girilenPersonel.Ad;
                lbl_soyadbilgi.Text = "Soyad:           " + girilenPersonel.Soyad;
                lbl_kayittarihibilgi.Text = "Kayıt Tarihi:    " + girilenPersonel.CreateDate.ToShortDateString();
                if (File.Exists(girilenPersonel.FotoPath))
                {
                    pct_resimbilgi.ImageLocation = girilenPersonel.FotoPath;
                }
                else
                {
                    pct_resimbilgi.ImageLocation = @"images\fotoYok.png";
                }
                if (girilenPersonel.PersonelTipId==1)
                {
                    lbl_dogumtarihibilgi.Text = "Ünvan:          Doktor";
                }
                lbl_kayittarihibilgi.Top -= 30;
            }

            anaForm = this;
            //Menuler için gerekli olan ayarlar
            pct_adminRapor.Top -= pnl_personelAlt.Height;
            lbl_adminrapor.Top -= pnl_personelAlt.Height;

            pct_menuAc.ImageLocation = @"images\AnaForm\menuAc.png";


            //Formun Düzüne için gerekli olan yarlar
            float x = (Convert.ToInt32(this.Width) - Convert.ToInt32(lbl_baslik.Width))/2 ;
            lbl_baslik.Location = new Point(x: Convert.ToInt32(x), y: lbl_baslik.Location.Y);
            float kx = (Convert.ToInt32(this.Width) - Convert.ToInt32(pct_kapat.Width));
            pct_kapat.Location= new Point(x: Convert.ToInt32(kx), y: pct_kapat.Location.Y);
            float yx = (Convert.ToInt32(this.Width) - Convert.ToInt32(pct_kucult.Width)) -pct_kapat.Width;
            pct_kucult.Location = new Point(x: Convert.ToInt32(yx), y: pct_kucult.Location.Y);
            float bx = (Convert.ToInt32(this.Width) - Convert.ToInt32(pnl_bilgi.Width))-20;
            pnl_bilgi.Location = new Point(x: Convert.ToInt32(bx), y: pnl_bilgi.Location.Y);

            float px = (Convert.ToInt32(this.Width) - Convert.ToInt32(pnl_form.Width)) / 2;
            float py = (Convert.ToInt32(this.Height) - Convert.ToInt32(pnl_form.Height)) / 2;

            pnl_form.Location = new Point(x: Convert.ToInt32(px), y: Convert.ToInt32(py));

            float mrx = (Convert.ToInt32(this.Width) - Convert.ToInt32(pnl_mrbox.Width));
            pnl_mrbox.Location = new Point(x: Convert.ToInt32(mrx), y: pnl_mrbox.Location.Y);

        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pct_kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pct_menuAc_Click(object sender, EventArgs e)
        {
            
            if (pct_menuAc.ImageLocation==@"images\AnaForm\menuAcBeyaz.png")
            {
                if (pnl_adminMenu.Visible)//adminse
                {
                    pct_menuAc.ImageLocation = @"images\AnaForm\menuKapat.png";
                    pnl_adminMenu.Left = 0;
                    pct_menuAc.Left += 220;
                }
                else if (pnl_hastaMenu.Visible)//hasta
                {
                    pct_menuAc.ImageLocation = @"images\AnaForm\menuKapat.png";
                    pnl_hastaMenu.Left = 0;
                    pct_menuAc.Left += 220;
                }
                else if (pnl_doktorMenu.Visible)
                {
                    pct_menuAc.ImageLocation = @"images\AnaForm\menuKapat.png";
                    pnl_doktorMenu.Left = 0;
                    pct_menuAc.Left += 220;
                }
               
            }
            else if (pct_menuAc.ImageLocation == @"images\AnaForm\menuKapatBeyaz.png")
            {
                if (pnl_adminMenu.Visible)//adminse
                {
                    pct_menuAc.ImageLocation = @"images\AnaForm\menuAc.png";
                    pnl_adminMenu.Left = -220;
                    pct_menuAc.Left -= 220;
                }
                else if(pnl_hastaMenu.Visible)//hasta
                {
                    pct_menuAc.ImageLocation = @"images\AnaForm\menuAc.png";
                    pnl_hastaMenu.Left = -220;
                    pct_menuAc.Left -= 220;
                }
                else if (pnl_doktorMenu.Visible)
                {
                    pct_menuAc.ImageLocation = @"images\AnaForm\menuAc.png";
                    pnl_doktorMenu.Left = -220;
                    pct_menuAc.Left -= 220;
                }

            }
        }

        private void pct_menuAc_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Bu buton sana menüyü açıcak.";
            if (pct_menuAc.ImageLocation == @"images\AnaForm\menuAc.png")
            {
                pct_menuAc.ImageLocation = @"images\AnaForm\menuAcBeyaz.png";
            }
            else if (pct_menuAc.ImageLocation == @"images\AnaForm\menuKapat.png")
            {
                pct_menuAc.ImageLocation = @"images\AnaForm\menuKapatBeyaz.png";
            }
        }

        private void pct_menuAc_MouseLeave(object sender, EventArgs e)
        {
            if (pct_menuAc.ImageLocation == @"images\AnaForm\menuAcBeyaz.png")
            {
                pct_menuAc.ImageLocation = @"images\AnaForm\menuAc.png";
            }
            else if (pct_menuAc.ImageLocation == @"images\AnaForm\menuKapatBeyaz.png")
            {
                pct_menuAc.ImageLocation = @"images\AnaForm\menuKapat.png";
            }
           
        }

        private void Anaform_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Hoşgeldiniz! Ben Mr.Box\nSize yaptığınız işlemler doğrultusunda\nbilgiler vereceğim.";
        }

        private void pct_kapat_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Programı kapatmak için kullanılır.";
        }

        private void pct_kucult_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Programı alta almak için kullanılır.";
        }
        string oncekiLocationMenu;
        private void pct_personelislem_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Personel İşlemlerini gerçekleş-\ntireceğiniz menu.";
            oncekiLocationMenu = @"images\AnaForm\butonlar\1.png";
            pct_personelislem.ImageLocation = @"images\AnaForm\butonlar\beyazButon.png";
        }

        private void pct_personelislem_MouseLeave(object sender, EventArgs e)
        {
            pct_personelislem.ImageLocation = oncekiLocationMenu;      
        }

        private void pct_personelislem_Click(object sender, EventArgs e)
        {
          
            if (pnl_personelAlt.Visible==false)
            {
                pnl_personelAlt.Visible = true;
            }
            else
            {
                pnl_personelAlt.Visible = false;
            }
        }

        private void pnl_personelAlt_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_personelAlt.Visible==false)
            {
                pct_adminRapor.Top -= pnl_personelAlt.Height;
                lbl_adminrapor.Top -= pnl_personelAlt.Height;
                pnl_adminrapor.Top = pct_adminRapor.Top + 50;
            }
            else
            {
                pct_adminRapor.Top += pnl_personelAlt.Height;
                lbl_adminrapor.Top += pnl_personelAlt.Height;
                pnl_adminrapor.Top = pct_adminRapor.Top + 50;
            }
        }
        string oncekiLocationAltMenu;
        private void pct_personelEkle_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Personel Ekle formunu getirir.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_personelEkle.ImageLocation= @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_personelEkle_MouseLeave(object sender, EventArgs e)
        {
                pct_personelEkle.ImageLocation = oncekiLocationAltMenu;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
         
        }

        private void pct_personelGuncelle_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Personel Güncelle formunu getirir.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_personelGuncelle.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_personelGuncelle_MouseLeave(object sender, EventArgs e)
        {
            pct_personelGuncelle.ImageLocation = oncekiLocationAltMenu;
        }

        private void pct_personelSil_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Personel Sil formunu getirir.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_personelSil.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_personelSil_MouseLeave(object sender, EventArgs e)
        {
            pct_personelSil.ImageLocation = oncekiLocationAltMenu;
        }
        
        private void pct_personelEkle_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            PersonelEkle p = new PersonelEkle();
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_personelGuncelle_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            PersonelGuncelle p = new PersonelGuncelle();
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_personelSil_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            PersonelSil p = new PersonelSil();
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_adminRapor_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Raporlamaların yapıldığı menu";
            oncekiLocationMenu = @"images\AnaForm\butonlar\1.png";
            pct_adminRapor.ImageLocation = @"images\AnaForm\butonlar\beyazButon.png";
        }

        private void pct_adminRapor_MouseLeave(object sender, EventArgs e)
        {
            pct_adminRapor.ImageLocation = oncekiLocationMenu;
        }

        private void pnl_adminrapor_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_adminrapor.Visible==true)
            {
                pnl_adminrapor.Top = pct_adminRapor.Top + 50;
            }
        }

        private void pct_adminRapor_Click(object sender, EventArgs e)
        {
            if (pnl_adminrapor.Visible==false)
            {
                pnl_adminrapor.Visible = true;
            }
            else
            {
                pnl_adminrapor.Visible = false;
            }
        }

        private void pct_tarihrapor_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Doktorlarınıza izin vermek için tıklayın.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_doktorIzın.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_tarihrapor_MouseLeave(object sender, EventArgs e)
        {
            pct_doktorIzın.ImageLocation = oncekiLocationAltMenu;
        }

        private void pct_hastarapor_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Size hastalar hakkında rapor \noluşturmanızı sağlar";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_hastarapor.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_hastarapor_MouseLeave(object sender, EventArgs e)
        {
            pct_hastarapor.ImageLocation = oncekiLocationAltMenu;
        }

        private void pct_teshisrapor_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Personellerinizi görüntüleyebilir.\nİsterseniz çıktı alabilirsiniz.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_teshisrapor.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_teshisrapor_MouseLeave(object sender, EventArgs e)
        {
            pct_teshisrapor.ImageLocation = oncekiLocationAltMenu;
        }

      
     
        private void pct_admincikis_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Sizi giriş formuna geri götürür.";
            oncekiLocationMenu = @"images\AnaForm\butonlar\1.png";
            pct_admincikis.ImageLocation = @"images\AnaForm\butonlar\beyazButon.png";
        }

        private void pct_admincikis_MouseLeave(object sender, EventArgs e)
        {
            pct_admincikis.ImageLocation = oncekiLocationMenu;
        }
        GirisForm f = new GirisForm();
        private void pct_hastacikis_Click(object sender, EventArgs e)
        {
            GirisForm.girisDurum = false;
            girilenHasta = null;
            this.Close();
            f.Show();
        }

        private void pct_doktorcikis_Click(object sender, EventArgs e)
        {
            GirisForm.girisDurum = false;
            girilenPersonel = null;
            this.Close();
            f.Show();
        }

        private void pct_hastarandevual_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            RandevuAl p = new RandevuAl();
            p.girilenHasta = girilenHasta;
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_hastarandevularim_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            HastaTumRandevularim p = new HastaTumRandevularim();
            p.girilenHasta = girilenHasta;
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_profilduzenle_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            HastaProfilDuzenle p = new HastaProfilDuzenle();
            p.girilenHasta = girilenHasta;
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_hastarandevual_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Hemen şimdi randevu alın.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_hastarandevual.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_hastarandevual_MouseLeave(object sender, EventArgs e)
        {
            pct_hastarandevual.ImageLocation = oncekiLocationAltMenu;
        }

        private void pct_hastarandevularim_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Bugüne kadar yapmış olduğunuz\n tüm randevuları görüntüleyin.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_hastarandevularim.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_hastarandevularim_MouseLeave(object sender, EventArgs e)
        {
            pct_hastarandevularim.ImageLocation = oncekiLocationAltMenu;
        }

        private void pct_profilduzenle_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Profilinizdeki bilgileri güncelleyin.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_profilduzenle.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_profilduzenle_MouseLeave(object sender, EventArgs e)
        {
            pct_profilduzenle.ImageLocation = oncekiLocationAltMenu;
        }

        private void pct_hastacikis_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Sistemden güvenli bir şekilde\nçıkmanızı sağlar.";
            oncekiLocationMenu = @"images\AnaForm\butonlar\1.png";
            pct_hastacikis.ImageLocation = @"images\AnaForm\butonlar\beyazButon.png";
        }

        private void pct_hastacikis_MouseLeave(object sender, EventArgs e)
        {
            pct_hastacikis.ImageLocation = oncekiLocationMenu;
        }

        private void pct_doktorrandevu_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            DoktorRandevularim p = new DoktorRandevularim();
            p.girilenDoktor = girilenPersonel;
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_doktorprofil_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            DoktorProfilDuzenle p = new DoktorProfilDuzenle();
            p.girilenDoktor = girilenPersonel;
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_doktorrandevu_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Tüm Randevularınızı görüntülemek\niçin tıklayın.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_doktorrandevu.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_doktorrandevu_MouseLeave(object sender, EventArgs e)
        {
            pct_doktorrandevu.ImageLocation = oncekiLocationAltMenu;
        }

        private void pct_doktorhastalarim_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Hastanız hakkında detaylı bilgi edinin.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_doktorhastalarim.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_doktorhastalarim_MouseLeave(object sender, EventArgs e)
        {
            pct_doktorhastalarim.ImageLocation = oncekiLocationAltMenu;
        }

        private void pct_doktorprofil_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Profinilinizi bilgilerini değiştirin.";
            oncekiLocationAltMenu = @"images\AnaForm\butonlar\a1.png";
            pct_doktorprofil.ImageLocation = @"images\AnaForm\butonlar\altButonBeyaz.png";
        }

        private void pct_doktorprofil_MouseLeave(object sender, EventArgs e)
        {
            pct_doktorprofil.ImageLocation = oncekiLocationAltMenu;
        }

        private void pct_doktorcikis_MouseHover(object sender, EventArgs e)
        {
            lbl_mrRobot.Text = "Çıkış yap.";
            oncekiLocationMenu = @"images\AnaForm\butonlar\1.png";
            pct_doktorcikis.ImageLocation = @"images\AnaForm\butonlar\beyazButon.png";
        }

        private void pct_doktorcikis_MouseLeave(object sender, EventArgs e)
        {
            pct_doktorcikis.ImageLocation = oncekiLocationMenu;
        }

        private void pct_doktorhastalarim_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            DoktorHastam p = new DoktorHastam();
            p.girilenDoktor = girilenPersonel;
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_admincikis_Click(object sender, EventArgs e)
        {
            GirisForm.girisDurum = false;
            adminDurum = false;
            this.Close();
            f.Show();

        }

        private void pct_doktorIzın_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            DoktorIzın p = new DoktorIzın();
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_teshisrapor_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            PersonelRaporAl p = new PersonelRaporAl();
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }

        private void pct_hastarapor_Click(object sender, EventArgs e)
        {
            pnl_form.Controls.Clear();
            HastaRapor p = new HastaRapor();
            p.Left = 150;
            p.TopLevel = false;
            p.Show();
            pnl_form.Controls.Add(p);
        }
    }
}

