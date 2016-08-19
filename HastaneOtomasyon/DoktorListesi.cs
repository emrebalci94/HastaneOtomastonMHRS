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
    public partial class DoktorListesi : Form
    {
        public DoktorListesi()
        {
            InitializeComponent();
        }

        public ComboBox gelenCombo;
        private void DoktorListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = this.BackColor;
            comboBox1.SelectedIndex = 0;
            textBox1.BackColor = this.BackColor;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
               dataGridView1.DataSource=  ListelemeIslemleri.DoktorAdGoreArama(textBox1.Text);
            }
            else
            {
                dataGridView1.DataSource = ListelemeIslemleri.DoktorTcGoreArama(textBox1.Text);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gelenCombo.SelectedValue =int.Parse( KontrolIslemleri.DoktorIdDon(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            this.Close();
        }
    }
}
