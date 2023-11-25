using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baskom.Controller;

namespace Baskom.View
{
    partial class v_DaftarMitra : Form
    {
        private c_Dashboard c_Dashboard;
        public v_DaftarMitra(c_Dashboard c_Dashboard)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setMemvalidasiKonversiNilai();
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mitraBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setPengajuanMOA();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setProfilTimMBKM();
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardTimmbkm();
        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setPembagianTugas();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setMemvalidasiKonversiSks();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //logout
        }
    }
}
