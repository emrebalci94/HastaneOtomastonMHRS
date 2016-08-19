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
    public partial class ReceteYaz : Form
    {
        public ReceteYaz()
        {
            InitializeComponent();
        }
        Recete hastaRecete;
        public  int hastaId;
        public  int doktorId;
        private void ReceteYaz_Load(object sender, EventArgs e)
        {
            ListelemeIslemleri.IlacComboDoldur(cmb_ilac);
            cmb_durum.SelectedIndex = 1;
            txt_teshis.BackColor = this.BackColor;
            hastaRecete = KontrolIslemleri.HastaReceteBul(doktorId, hastaId);
            if (hastaRecete!=null)
            {
                txt_teshis.Text = hastaRecete.Teshis;
                if (hastaRecete.Durum==true)
                {
                    cmb_durum.SelectedIndex = 1;
                }
                else
                {
                    cmb_durum.SelectedIndex = 0;
                }
                lbl_receteButon.Text = "Reçete Güncelle";
                lbl_receteButon.Left -= 10;
                pictureBox2.ImageLocation = @"images\AnaForm\butonlara\guncelle.png";
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (hastaRecete == null)
            {
                if (MessageBox.Show("Reçete Eklensin mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Recete r = new Recete();
                        if (cmb_durum.SelectedIndex == 1)
                        {
                            r.Durum = true;
                        }
                        else
                        {
                            r.Durum = false;
                        }
                        r.PersonelId = doktorId;
                        r.HastaId = hastaId;
                        r.Teshis = txt_teshis.Text;
                        r.CreateDate = DateTime.Now;
                        DbIslemleri.ReceteEkle(r);
                        this.Close();
                        Anaform.anaForm.lbl_mrRobot.Text = "Recete başarıyla kaydedildi.";
                    }
                    catch (Exception ex)
                    {

                        Anaform.anaForm.lbl_mrRobot.Text = ex.Message;
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Reçete Güncellensin mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                       
                        if (cmb_durum.SelectedIndex == 1)
                        {
                            hastaRecete.Durum = true;
                        }
                        else
                        {
                            hastaRecete.Durum = false;
                        }
                        hastaRecete.Teshis = txt_teshis.Text;
                        DbIslemleri.ReceteGuncelle(hastaRecete);
                        this.Close();
                        Anaform.anaForm.lbl_mrRobot.Text = "Recete başarıyla güncellendi.";
                    }
                    catch (Exception ex)
                    {

                        Anaform.anaForm.lbl_mrRobot.Text = ex.Message;
                    }
                }
            }
        }

        private void txt_teshis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
           && !char.IsSeparator(e.KeyChar);
        }

        private void pct_ilacEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Ilaclar i = new Ilaclar();
                string ilacGiris = Microsoft.VisualBasic.Interaction.InputBox("İlacın İsmini Giriniz:", "İlaç Girişi", "", this.Location.X, this.Location.Y);
                if (ilacGiris != null)
                {
                    i.Ad = ilacGiris;
                    i.CreateDate = DateTime.Now;
                    DbIslemleri.IlacEkle(i);
                    ListelemeIslemleri.IlacComboDoldur(cmb_ilac);
                    Anaform.anaForm.lbl_mrRobot.Text = "İlaç eklendi.";
                }
            }
            catch (Exception ex)
            {
                Anaform.anaForm.lbl_mrRobot.Text = ex.Message;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("İlaç Eklensin mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ReceteIlac r = new ReceteIlac();
                    r.IlacId = int.Parse(cmb_ilac.SelectedValue.ToString());
                    r.ReceteId = hastaRecete.ReceteId;
                    DbIslemleri.ReceteIlacEKle(r);
                    Anaform.anaForm.lbl_mrRobot.Text = "Reçeteye ilaç kaydı tamamlandı.";
                }
                catch (Exception ex)
                {
                    Anaform.anaForm.lbl_mrRobot.Text = ex.Message;
                }
            }
        }
    }
}
