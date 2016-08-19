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
    public partial class DoktorIzın : Form
    {
        public DoktorIzın()
        {
            InitializeComponent();
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoktorIzın_Load(object sender, EventArgs e)
        {
            ListelemeIslemleri.DoktorlarComboAt(comboBox1);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value>DateTime.Now && dateTimePicker2.Value > dateTimePicker1.Value)
            {
                if (KontrolIslemleri.DoktorIzinUygunluk(int.Parse(comboBox1.SelectedValue.ToString()),dateTimePicker1.Value,dateTimePicker2.Value))
                {
                    DialogResult sonuc= MessageBox.Show(comboBox1.Text+" Personele izin verilsin mi ?","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    PersonelIzin p = new PersonelIzin();
                    p.PersonelId = int.Parse(comboBox1.SelectedValue.ToString());
                    p.CreateDate = DateTime.Now;
                    p.StartDate = dateTimePicker1.Value;
                    p.EndDate = dateTimePicker2.Value;
                    if (sonuc==DialogResult.Yes)
                    {
                        try
                        {

                            DbIslemleri.DoktorIzinVer(p);
                            Anaform.anaForm.lbl_mrRobot.Text = "Personele başarıyla izin verildi.";
                        }
                        catch (Exception ex)
                        {
                            Anaform.anaForm.lbl_mrRobot.Text =ex.Message;
                        }
                    }
                }
                else
                {
                    pct_tarihOnay.ImageLocation = "images/hata.png";
                    toolTip1.SetToolTip(pct_tarihOnay, "Doktorun o tarihler arasında randevusu olduğundan veya izinli olduğundan izin verilemez.");
                }
            }
            else
            {
                pct_tarihOnay.ImageLocation = "images/hata.png";
                toolTip1.SetToolTip(pct_tarihOnay, "Başlangıç Tarihi Bugünden büyük olmak zorundadır.\nAyrı zamanda bitiş tarihi başlangıç tarihinden büyük olmak zorundadır.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DoktorListesi dl = new DoktorListesi();
            dl.gelenCombo = comboBox1;
            dl.ShowDialog();

        }
    }
}
