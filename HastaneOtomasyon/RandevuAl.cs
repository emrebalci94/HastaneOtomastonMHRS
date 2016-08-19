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
    public partial class RandevuAl : Form
    {
        public RandevuAl()
        {
            InitializeComponent();
        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {
            txt_saat.BackColor = this.BackColor;
            ListelemeIslemleri.DoktorlarComboAt(cmb_doktorsecim);
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }  

        private void dt_tarih_ValueChanged(object sender, EventArgs e)
        {
            if (dt_tarih.Value>DateTime.Now)
            {
                if (dt_tarih.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    toolTip1.SetToolTip(pct_tarihKontrol, "Pazar randevu alınamaz.");
                    pct_tarihKontrol.ImageLocation = @"images\hata.png";
                }
                else
                {
                    toolTip1.SetToolTip(pct_tarihKontrol, "Tarih formatlara uygun");
                    pct_tarihKontrol.ImageLocation = @"images\onay.png";
                    pct_doktorkontrol.ImageLocation = "";
                    
                }
            }
            else
            {
                toolTip1.SetToolTip(pct_tarihKontrol, "Aynı gün veya geçmiş günlere randevu alamazsınız.");
                pct_tarihKontrol.ImageLocation = @"images\hata.png";
            }
        }

        private void cmb_doktorsecim_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }
        int secim;
        private void cmb_doktorsecim_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                secim = int.Parse(cmb_doktorsecim.SelectedValue.ToString());
                if (KontrolIslemleri.DoktorRandevuUygunluk(secim, dt_tarih.Value))
                {
                    toolTip1.SetToolTip(pct_doktorkontrol, "Doktor " + dt_tarih.Value.ToShortDateString() + " tarihinde uygun durumda.");
                    pct_doktorkontrol.ImageLocation = @"images\onay.png";
                }
                else
                {
                    toolTip1.SetToolTip(pct_doktorkontrol, "Doktor " + dt_tarih.Value.ToShortDateString() + " tarihinde uygun değil.");
                    pct_doktorkontrol.ImageLocation = @"images\hata.png";
                }
            }
            catch (Exception)
            {


            }
        }

        private void txt_saat_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_saat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_saat.Text[0].ToString() == "0")
                {
                    if (txt_saat.Text[1].ToString() == "8" || txt_saat.Text[1].ToString() == "9")
                    {
                        if (txt_saat.Text[3].ToString() == "3" || txt_saat.Text[3].ToString() == "0" && txt_saat.Text[4].ToString() == "0")
                        {
                            toolTip1.SetToolTip(pct_saatKontrol, "Girdiğiniz saat sisteme uygun.");
                            pct_saatKontrol.ImageLocation = @"images\onay.png";
                        }
                        else
                        {
                            toolTip1.SetToolTip(pct_saatKontrol, "Girdiğiniz saat randevu sistemimiz içersinde yer almamaktardır.\nUygun saatler(08:30-16:30) arasıdır.");
                            pct_saatKontrol.ImageLocation = @"images\hata.png";
                        }
                    }
                    else
                    {
                        toolTip1.SetToolTip(pct_saatKontrol, "Girdiğiniz saat randevu sistemimiz içersinde yer almamaktardır.\nUygun saatler(08:30-16:30) arasıdır.");
                        pct_saatKontrol.ImageLocation = @"images\hata.png";
                    }

                }
                else if (txt_saat.Text[0].ToString() == "1")
                {

                    if (txt_saat.Text[1].ToString()=="0"|| txt_saat.Text[1].ToString()=="1"|| txt_saat.Text[1].ToString()=="2"|| txt_saat.Text[1].ToString()=="3"|| txt_saat.Text[1].ToString()=="4"|| txt_saat.Text[1].ToString()=="5"|| txt_saat.Text[1].ToString()=="6")
                    {
                        if (txt_saat.Text[3].ToString() == "3" || txt_saat.Text[3].ToString() == "0")
                        {
                            if (txt_saat.Text[4].ToString() == "0")
                            {
                                toolTip1.SetToolTip(pct_saatKontrol, "Girdiğiniz saat sisteme uygun.");
                                pct_saatKontrol.ImageLocation = @"images\onay.png";
                            }
                            else
                            {
                                toolTip1.SetToolTip(pct_saatKontrol, "Girdiğiniz saat randevu sistemimiz içersinde yer almamaktardır.\nUygun saatler(08:30-16:30) arasıdır.");
                                pct_saatKontrol.ImageLocation = @"images\hata.png";
                            }
                           
                        }
                        else
                        {
                            toolTip1.SetToolTip(pct_saatKontrol, "Girdiğiniz saat randevu sistemimiz içersinde yer almamaktardır.\nUygun saatler(08:30-16:30) arasıdır.");
                            pct_saatKontrol.ImageLocation = @"images\hata.png";
                        }
                    }
                    else
                    {
                        toolTip1.SetToolTip(pct_saatKontrol, "Girdiğiniz saat randevu sistemimiz içersinde yer almamaktardır.\nUygun saatler(08:30-16:30) arasıdır.");
                        pct_saatKontrol.ImageLocation = @"images\hata.png";
                    }       
                }
                else
                {
                    toolTip1.SetToolTip(pct_saatKontrol, "Girdiğiniz saat randevu sistemimiz içersinde yer almamaktardır.\nUygun saatler(08:30-16:30) arasıdır.");
                    pct_saatKontrol.ImageLocation = @"images\hata.png";
                }

            }
            catch (Exception)
            {

                
            }
        }
        public Hasta girilenHasta;
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Randevu Alınsın mı?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string saat = txt_saat.Text;
                if (pct_saatKontrol.ImageLocation == @"images\onay.png" && pct_tarihKontrol.ImageLocation == @"images\onay.png" && pct_doktorkontrol.ImageLocation == @"images\onay.png" && saat.Length == 5)
                {
                    if (KontrolIslemleri.RandevuSaatUygunluk(saat, dt_tarih.Value, secim))
                    {
                        if (KontrolIslemleri.RandevuSaatveHastaUygunluk(saat, dt_tarih.Value, secim, girilenHasta.HastaId))
                        {
                            try
                            {

                                Randevu r = new Randevu();
                                r.HastaId = girilenHasta.HastaId;
                                r.PersonelId = secim;
                                r.RandevuSaati = saat;
                                r.RandevuTarihi = dt_tarih.Value;
                                DbIslemleri.RandevuEkle(r);
                                Anaform.anaForm.lbl_mrRobot.Text = "Randevu işlemi gerçekleştirildi.";
                                txt_saat.Text = "";
                                dt_tarih.Value = DateTime.Now;
                                cmb_doktorsecim.SelectedIndex = 0;

                            }
                            catch (Exception ex)
                            {

                                Anaform.anaForm.lbl_mrRobot.Text = ex.Message;
                                txt_saat.Text = "";
                            }
                        }
                        else
                        {
                            Anaform.anaForm.lbl_mrRobot.Text = "Aynı doktor aynı gün 2. kez randevu\n alamazsınız.";
                            txt_saat.Text = "";
                        }
                    }
                    else
                    {
                        Anaform.anaForm.lbl_mrRobot.Text = "Girmiş olduğunuz saatin daha önceden \n randevusu alınmış.";
                        txt_saat.Text = "";
                    }
                }
                else
                {
                    Anaform.anaForm.lbl_mrRobot.Text = "Lüften bilgilerinizi kontrol ediniz.";
                    txt_saat.Text = "";
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DoktorListesi dl = new DoktorListesi();
            dl.gelenCombo = cmb_doktorsecim;
            dl.ShowDialog();
        }
    }
}
