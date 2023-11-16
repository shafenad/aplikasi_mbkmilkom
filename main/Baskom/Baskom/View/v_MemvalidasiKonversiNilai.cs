using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.View
{
    public partial class v_MemvalidasiKonversiNilai : Form
    {
        public v_MemvalidasiKonversiNilai()
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
            /*DetailKonversiNilai form = new DetailKonversiNilai();
            form.Show();*/
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            v_DetailValidasiKonversiNilai v_DetailValidasiKonversiNilai = new v_DetailValidasiKonversiNilai();
            v_DetailValidasiKonversiNilai.Show();
            this.Hide();
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*DaftarMitra form3 = new DaftarMitra();
            form3.Show();*/
        }

        private void pengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*PengajuanMOA form4 = new PengajuanMOA();
            form4.Show();*/
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_PengajuanMOA v_PengajuanMOA = new v_PengajuanMOA();
            v_PengajuanMOA.Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void daftarMitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            /*DaftarMitra form3 = new DaftarMitra();
            form3.Show();
            this.Hide();*/
        }

        private void lihatProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_ProfilTimMBKM v_ProfilTimMBKM = new v_ProfilTimMBKM();
            v_ProfilTimMBKM.Show();
            this.Hide();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_MemvalidasiKonversiSks v_MemvalidasiKonversiSks = new v_MemvalidasiKonversiSks();
            v_MemvalidasiKonversiSks.Show();
            this.Hide();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DashboardTimmbkm v_DashboardTimmbkm = new v_DashboardTimmbkm();
            v_DashboardTimmbkm.Show();
            this.Hide();
        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_PembagianTugas v_PembagianTugas = new v_PembagianTugas();
            v_PembagianTugas.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_LoginTimmbkm v_LoginTimmbkm = new v_LoginTimmbkm();
            v_LoginTimmbkm.Show();
            this.Hide();
        }
    }
}

