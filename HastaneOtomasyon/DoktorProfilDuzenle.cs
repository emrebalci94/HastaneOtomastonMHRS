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
    public partial class DoktorProfilDuzenle : Form
    {
        public DoktorProfilDuzenle()
        {
            InitializeComponent();
        }
        public Personel girilenDoktor;
        private void DoktorProfilDuzenle_Load(object sender, EventArgs e)
        {
            txt_ad.BackColor = this.BackColor;
            txt_soyad.BackColor = this.BackColor;
            txt_sifre.BackColor = this.BackColor;
            txt_tc.BackColor = this.BackColor;
            txt_resim.BackColor = this.BackColor;
            txt_tc.Text = girilenDoktor.Tc[0].ToString()+"**********"+girilenDoktor.Tc[10].ToString();
            txt_ad.Text = girilenDoktor.Ad;
            txt_soyad.Text = girilenDoktor.Soyad;
            txt_sifre.Text = girilenDoktor.Sifre;
            txt_resim.Text = girilenDoktor.FotoPath;
            pct_foto.ImageLocation = txt_resim.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Profil Bilgileriniz Güncellensin mi ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txt_ad.Text!="" && txt_soyad.Text!="" && txt_sifre.Text!="")
                {
                    try
                    {
                        girilenDoktor.Ad = txt_ad.Text;
                        girilenDoktor.Soyad = txt_soyad.Text;
                        girilenDoktor.Sifre = txt_sifre.Text;
                        girilenDoktor.FotoPath = txt_resim.Text;
                        DbIslemleri.DoktorProfilGuncelle(girilenDoktor);
                        Anaform.anaForm.lbl_mrRobot.Text = "Bilgileriniz başarıyla güncellendi.Lütfen yeniden\ngiriş yapınız.";
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        Anaform.anaForm.lbl_mrRobot.Text = ex.Message;
                    }
                }
                else
                {
                    Anaform.anaForm.lbl_mrRobot.Text = "Eksik Bilgilerinizi Tamamlayınız.";
                }
            }
        }

        private void txt_resim_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Jpg (*.jpg)|*.jpg|Png (*.png)|*.png";
            op.Title = "Lütfen bir resim seçiniz.";
            if (op.ShowDialog() == DialogResult.OK)
            {
                txt_resim.Text = op.FileName;
                pct_foto.ImageLocation = op.FileName;
            }
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
