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
    public partial class v_MemvalidasiKonversiSks : Form
    {
        public v_MemvalidasiKonversiSks()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DashboardTimmbkm v_DashboardTimmbkm = new v_DashboardTimmbkm();
            v_DashboardTimmbkm.Show();
            this.Hide();
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_PembagianTugas v_PembagianTugas = new v_PembagianTugas();
            v_PembagianTugas.Show();
            this.Hide();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void konversiNIlaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_MemvalidasiKonversiNilai v_MemvalidasiKonversiNilai = new v_MemvalidasiKonversiNilai();
            v_MemvalidasiKonversiNilai.Show();
            this.Hide();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_ProfilTimMBKM v_ProfilTimMBKM = new v_ProfilTimMBKM();
            v_ProfilTimMBKM.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_LoginTimmbkm v_LoginTimmbkm = new v_LoginTimmbkm();
            v_LoginTimmbkm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            v_DetailValidasiKonversiSks v_DetailValidasiKonversiSks = new v_DetailValidasiKonversiSks();
            v_DetailValidasiKonversiSks.Show();
            this.Hide();
        }

        private void pengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_PengajuanMOA v_PengajuanMOA = new v_PengajuanMOA();
            v_PengajuanMOA.Show();
            this.Hide();
        }
    }
}
