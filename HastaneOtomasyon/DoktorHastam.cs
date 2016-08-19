using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace HastaneOtomasyon
{
    public partial class DoktorHastam : Form
    {
        public DoktorHastam()
        {
            InitializeComponent();
        }

        private void DoktorHastam_Load(object sender, EventArgs e)
        {
            cmb_arama.SelectedIndex = 0;
            dt_liste.BackgroundColor = this.BackColor;
            
        }
        public Personel girilenDoktor;

        private void txt_arama_TextChanged(object sender, EventArgs e)
        {
            this.Height = 310;
            groupBox2.Visible = false;
            dt_liste.Visible = true;
            if (cmb_arama.SelectedIndex==0)
            {
                dt_liste.DataSource = ListelemeIslemleri.HastaAramaAd(txt_arama.Text);
            }
            else
            {
                dt_liste.DataSource = ListelemeIslemleri.HastaAramaTc(txt_arama.Text);
            }
        }
     
        private void dt_liste_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Height = 475;
            dt_liste.Visible = false;
            groupBox2.Visible = true;
            //MessageBox.Show(dt_liste.CurrentRow.Cells[1].Value.ToString());
            try
            {
                dataGridView1.DataSource = ListelemeIslemleri.DoktorHastam(dt_liste.CurrentRow.Cells[1].Value.ToString());
               
                txt_tc.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                txt_ad.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                txt_soyad.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                if (dataGridView1.Rows[0].Cells[3].Value.ToString() == "True")
                {
                    txt_cinsiyet.Text = "Erkek";
                }
                else
                {
                    txt_cinsiyet.Text = "Kadın";
                }
                txt_doktor.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                txt_teshis.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                txt_teshisTarih.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                if (txt_tc.Text == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                Anaform.anaForm.lbl_mrRobot.Text = "Hasta Hakkında daha teşhis \noluşturulmamış.Lütfen başka bir\nhasta arayayınız.";
                txt_arama.Text = "";
            }
      
            //txt_tc.Text = gelenBilgiler[0].ToString();
            //txt_ad.Text = gelenBilgiler[1].ToString();
            //txt_soyad.Text = gelenBilgiler[2].ToString();
            //if (gelenBilgiler[3].ToString() == "1")
            //{
            //    txt_cinsiyet.Text = "Erkek";
            //}
            //else
            //{
            //    txt_cinsiyet.Text = "Kadın";
            //}
            //txt_doktor.Text = gelenBilgiler[4].ToString();
            //txt_teshis.Text = gelenBilgiler[5].ToString();
            //txt_teshisTarih.Text = gelenBilgiler[6].ToString();


        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {//Formun loaddındaki girilen doktor şeysini sil
            e.Graphics.DrawImage(Image.FromFile(@"images\GirisSayfasi\MaviTasarim\medicIcon.png"), 300, 150, 300, 500);
            Font kocabaslik = new System.Drawing.Font("Arial", 20, FontStyle.Bold);
            Font grupBaslik = new System.Drawing.Font("Arial", 15, FontStyle.Underline);
            Font baslik = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            Font altbaslik = new System.Drawing.Font("Arial", 12, FontStyle.Regular);
            Font dublealtbaslik = new System.Drawing.Font("Arial", 9, FontStyle.Italic);
            Font uzundublealtbaslik = new System.Drawing.Font("Arial", 7, FontStyle.Underline);
            System.Drawing.Printing.PageSettings sayfa = printDocument1.DefaultPageSettings;
            e.Graphics.DrawString("Çıktı Alan Doktor Bilgileri", grupBaslik, Brushes.Black, 150, 50);
            e.Graphics.DrawString("Adı:", baslik, Brushes.Black, 150, 80);
            e.Graphics.DrawString(girilenDoktor.Ad, altbaslik, Brushes.Black, 300, 80);
            e.Graphics.DrawString("Soyadı:", baslik, Brushes.Black, 150, 110);
            e.Graphics.DrawString(girilenDoktor.Soyad, altbaslik, Brushes.Black, 300, 110);  
            if (File.Exists(girilenDoktor.FotoPath))
            {
                e.Graphics.DrawImage(Image.FromFile(girilenDoktor.FotoPath), 580, 50, 100, 100);
            }
            else
            {
                e.Graphics.DrawImage(Image.FromFile("images/fotoYok.png"), 580, 50, 100, 100);
            }
            e.Graphics.DrawLine(new Pen(Color.Black,1), sayfa.Margins.Left, 170, sayfa.PaperSize.Width - sayfa.Margins.Right, 170);
            e.Graphics.DrawString("Çıktı Alınan Hastanın Hasta Bilgileri", grupBaslik, Brushes.Black, 150, 200);
            e.Graphics.DrawString("Hasta Tc:", baslik, Brushes.Black, 200, 230);
            e.Graphics.DrawString(txt_tc.Text, altbaslik, Brushes.Black, 350, 230);
            e.Graphics.DrawString("Hasta Adı:", baslik, Brushes.Black, 200, 260);
            e.Graphics.DrawString(txt_ad.Text, altbaslik, Brushes.Black, 350, 260);
            e.Graphics.DrawString("Hasta Soyadı:", baslik, Brushes.Black, 200, 290);
            e.Graphics.DrawString(txt_soyad.Text, altbaslik, Brushes.Black, 350, 290);
            e.Graphics.DrawString("Hasta Cinsiyet:", baslik, Brushes.Black, 200, 320);
            e.Graphics.DrawString(txt_cinsiyet.Text, altbaslik, Brushes.Black, 350, 320);
            e.Graphics.DrawString("Son Teşhis:", baslik, Brushes.Black, 200, 350);
            e.Graphics.DrawString(txt_teshis.Text, altbaslik, Brushes.Black, 350, 350);
            e.Graphics.DrawString("Son Teşhis Tarihi:", baslik, Brushes.Black, 200, 380);
            e.Graphics.DrawString(txt_teshisTarih.Text, altbaslik, Brushes.Black, 350, 380);
            e.Graphics.DrawLine(new Pen(Color.Black, 1), sayfa.Margins.Left, 800, sayfa.PaperSize.Width - sayfa.Margins.Right, 800);
            e.Graphics.DrawString("Not:Bu çıktı 'HastahaneOtomasyon' uygulaması tarafından çıkarıldı...", dublealtbaslik, Brushes.Black, 100, 1000);
            e.Graphics.DrawString("Powered by Emre Balcı", dublealtbaslik, Brushes.Black, 600, 1050);

        }
    }
}
