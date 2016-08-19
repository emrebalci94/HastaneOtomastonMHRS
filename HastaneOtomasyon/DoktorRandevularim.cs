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
    public partial class DoktorRandevularim : Form
    {
        public DoktorRandevularim()
        {
            InitializeComponent();
        }
        public Personel girilenDoktor;
        private void DoktorRandevularim_Load(object sender, EventArgs e)
        {
            cmb_secim.SelectedIndex = 0;
            txt_arama.BackColor = this.BackColor;
            dt_liste.BackgroundColor = this.BackColor;
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            dt_liste.Visible = true;
            if (cmb_secim.SelectedIndex==0)
            {
                dt_liste.DataSource = ListelemeIslemleri.DoktorBugunkuRandevu(girilenDoktor.PersonelId,txt_arama.Text);
            }
            else
            {
                dt_liste.DataSource = ListelemeIslemleri.DoktorGelecekRandevu(girilenDoktor.PersonelId,txt_arama.Text);

            }
        }

        private void recete_yaz_Click(object sender, EventArgs e)
        {
            try
            {
                ReceteYaz r = new ReceteYaz();
                Hasta h = KontrolIslemleri.HastaBul(dt_liste.CurrentRow.Cells[0].Value.ToString());
                r.hastaId = h.HastaId;
                r.doktorId = girilenDoktor.PersonelId;
                r.ShowDialog();
            }
            catch (Exception)
            {

                Anaform.anaForm.lbl_mrRobot.Text = "Lütfen bir kayıt seçtiğinizden\nemin olun.";
            }
            
        }
    }
}
