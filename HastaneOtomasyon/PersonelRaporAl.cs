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
    public partial class PersonelRaporAl : Form
    {
        public PersonelRaporAl()
        {
            InitializeComponent();
        }

        private void PersonelRaporAl_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = Color.White;
            comboBox1.SelectedIndex = 0;
            textBox1.BackColor = this.BackColor;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                dataGridView1.DataSource = ListelemeIslemleri.TumPersoneller(textBox1.Text);
            }
            else if(comboBox1.SelectedIndex==1)
            {
                dataGridView1.DataSource = ListelemeIslemleri.TumPersonellerTc(textBox1.Text);
            }
            else if (comboBox1.SelectedIndex==2)
            {
                dataGridView1.DataSource = ListelemeIslemleri.PersonelTipineGore(textBox1.Text);
            }
            else if (comboBox1.SelectedIndex==3)
            {
                dataGridView1.DataSource = ListelemeIslemleri.SilinmisPersoneller();
            }
            else
            {
                dataGridView1.DataSource = ListelemeIslemleri.SilinmisPersoneller(textBox1.Text);
            }
        }

        private void pct_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Bitmap veriler;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            int with = dataGridView1.Width;
            dataGridView1.Width = 800;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            veriler = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(veriler, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            dataGridView1.Width = with;
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font kocabaslik = new System.Drawing.Font("Arial", 20, FontStyle.Bold);
            Font dublealtbaslik = new System.Drawing.Font("Arial", 9, FontStyle.Italic);
            e.Graphics.DrawString("PERSONEL BİLGİSİ RAPORLARI", kocabaslik, Brushes.Black, 250, 50);
            e.Graphics.DrawImage(veriler, 50, 100);
            e.Graphics.DrawImage(Image.FromFile(@"images\balciHsp.png"), 50, 900,300,150);
            e.Graphics.DrawString("Powered by Emre Balcı", dublealtbaslik, Brushes.Black, 600, 1050);
        }
    }
}
