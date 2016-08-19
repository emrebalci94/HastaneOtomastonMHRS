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
    public partial class HastaTumRandevularim : Form
    {
        public HastaTumRandevularim()
        {
            InitializeComponent();
        }

        private void HastaTumRandevularim_Load(object sender, EventArgs e)
        {
            txt_arama.BackColor = this.BackColor;
            button1.BackColor = this.BackColor;
            dtg_liste.BackgroundColor = this.BackColor;
        }

        private void cmb_secim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_secim.SelectedIndex==0)
            {

            }
            else if (cmb_secim.SelectedIndex == 1)
            {
                txt_arama.Visible = false;
                dt_tarih1.Visible = true;
                dt_tarih2.Visible = true;
            }
            else
            {
                txt_arama.Visible = true;
                dt_tarih1.Visible = false;
                dt_tarih2.Visible = false;
            }
        }
        public Hasta girilenHasta;
        private void button1_Click(object sender, EventArgs e)
        {
            dtg_liste.Visible = true;
            if (cmb_secim.SelectedIndex==0)
            {
                dtg_liste.DataSource = ListelemeIslemleri.HastaTumRandevu(girilenHasta.HastaId);
            }
            else if (cmb_secim.SelectedIndex==1)
            {
                dtg_liste.DataSource = ListelemeIslemleri.HastaIkıTarihRandevu(girilenHasta.HastaId, dt_tarih1.Value, dt_tarih2.Value);
            }
            else
            {
                dtg_liste.DataSource = ListelemeIslemleri.HastaDoktorAdRandevu(girilenHasta.HastaId, txt_arama.Text);
            }

            Anaform.anaForm.lbl_mrRobot.Text = "Filtrelemeye göre çıkan sonuç...";
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
