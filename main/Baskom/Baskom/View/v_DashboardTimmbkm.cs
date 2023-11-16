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
    public partial class v_DashboardTimmbkm : Form
    {
        public v_DashboardTimmbkm()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            v_MemvalidasiKonversiSks v_MemvalidasiKonversiSks = new v_MemvalidasiKonversiSks();
            v_MemvalidasiKonversiSks.Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_MemvalidasiKonversiNilai v_MemvalidasiKonversiNilai = new v_MemvalidasiKonversiNilai();
            v_MemvalidasiKonversiNilai.Show();
            this.Hide();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_LoginTimmbkm v_LoginTimmbkm = new v_LoginTimmbkm();
            v_LoginTimmbkm.Show();
            this.Hide();
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_PengajuanMOA v_PengajuanMOA = new v_PengajuanMOA();
            v_PengajuanMOA.Show();
            this.Hide();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_ProfilTimMBKM v_ProfilTimMBKM = new v_ProfilTimMBKM();
            v_ProfilTimMBKM.Show();
            this.Hide();
        }
    }
}
