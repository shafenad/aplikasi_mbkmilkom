using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gajelas
{
    public partial class KonversiNilai : Form
    {
        public KonversiNilai()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailKonversiNilai form = new DetailKonversiNilai();
            form.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DetailKonversiNilai form = new DetailKonversiNilai();
            form.Show();
            this.Hide();
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaftarMitra form3 = new DaftarMitra();
            form3.Show();
        }

        private void pengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PengajuanMOA form4 = new PengajuanMOA();
            form4.Show();
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PengajuanMOA form4 = new PengajuanMOA();
            form4.Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void daftarMitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DaftarMitra form3 = new DaftarMitra();
            form3.Show();
            this.Hide();
        }

        private void lihatProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form5 form5 = new Form5();
            //form5.Show();
            //this.Hide();

            new ProfilTimMBKM().Show();
            this.Hide();
            
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }

