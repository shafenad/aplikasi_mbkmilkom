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
    public partial class DaftarMitra : Form
    {
        public DaftarMitra()
        {
            InitializeComponent();
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KonversiNilai form = new KonversiNilai();
            form.Show();
            this.Hide();
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mitraBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PengajuanMOA form4 = new PengajuanMOA();
            form4.Show();
            this.Hide();

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
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
