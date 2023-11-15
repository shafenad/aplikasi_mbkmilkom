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
    public partial class DetailKonversiNilai : Form
    {
        public DetailKonversiNilai()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KonversiNilai form1 = new KonversiNilai();
            form1.Show();
            this.Hide();
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaftarMitra form3 = new DaftarMitra();
            form3.Show();
            this.Hide();
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PengajuanMOA form4 = new PengajuanMOA();
            form4.Show();
            this.Hide();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilTimMBKM profil = new ProfilTimMBKM();
            profil.Show();
            this.Hide();
        }
    }
}
