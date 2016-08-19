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
    public partial class PersonelSil : Form
    {
        public PersonelSil()
        {
            InitializeComponent();
        }

        private void PersonelSil_Load(object sender, EventArgs e)
        {
            dgt_liste.BackgroundColor = this.BackColor;
            cmb_secim.SelectedIndex = 0;
            txt_arama.BackColor = this.BackColor;
        }

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            if (cmb_secim.SelectedIndex == 0)
            {
                dgt_liste.DataSource = ListelemeIslemleri.personelTcArama(txt_arama.Text);
            }
            else if (cmb_secim.SelectedIndex == 1)
            {
                dgt_liste.DataSource = ListelemeIslemleri.personelAdArama(txt_arama.Text);
            }
            else
            {
                dgt_liste.DataSource = ListelemeIslemleri.personelSoyadArama(txt_arama.Text);
            }
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_arama.Text = "";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kayıt Güncellensin mi?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DbIslemleri.PersonelSil(dgt_liste.SelectedRows[0].Cells[0].Value.ToString());
                    Anaform.anaForm.lbl_mrRobot.Text = "Personel başarıyla silindi.";
                    txt_arama.Text = "";
                }
                catch (Exception ex)
                {
                    Anaform.anaForm.lbl_mrRobot.Text = ex.Message;

                }
            }
        }
    }
}
