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
    public partial class HastaProfilDuzenle : Form
    {
        public HastaProfilDuzenle()
        {
            InitializeComponent();
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Hasta girilenHasta;
        private void HastaProfilDuzenle_Load(object sender, EventArgs e)
        {
            txt_tc.BackColor = this.BackColor;
            txt_ad.BackColor = this.BackColor;
            txt_soyad.BackColor = this.BackColor;
            txt_sifre.BackColor = this.BackColor;
            txt_sifre.Text = girilenHasta.Password;
            txt_tc.Text = girilenHasta.Tc[0].ToString() + "*********" + girilenHasta.Tc[10].ToString();
            txt_ad.Text = girilenHasta.Ad;
            txt_soyad.Text = girilenHasta.Soyad;
            dt_dogum.Value = girilenHasta.DogumTarihi.Value;
            if (girilenHasta.Cinsiyet==true)
            {
                lbl_cinsiyet.Text = "Erkek";
            }
            else
            {
                lbl_cinsiyet.Text = "Kadın";
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Profil Bilgileriniz Güncellensin mi ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_soyad.Text !="" && txt_ad.Text!="" && dt_dogum.Value<DateTime.Now&& txt_sifre.Text!="")
                {
                    try
                    {
                        girilenHasta.Ad = txt_ad.Text;
                        girilenHasta.Soyad = txt_soyad.Text;
                        girilenHasta.Password = txt_sifre.Text;
                        girilenHasta.DogumTarihi = dt_dogum.Value;
                        DbIslemleri.HastaGuncelle(girilenHasta);
                        Anaform.anaForm.lbl_mrRobot.Text = "Güncelleme işlemi gerçekleştirildi.\nAyarların uygulanması için yeniden\ngiriş yapınız.";
                        this.Close();      
                    }
                    catch (Exception ex)
                    {
                        Anaform.anaForm.lbl_mrRobot.Text = ex.Message;
                    }
                }
                else
                {
                    Anaform.anaForm.lbl_mrRobot.Text = "Lütfen eksik bilgilerinizi doldurun.";
                }
            }
        }
    }
}
