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
    partial class v_MemvalidasiKonversiNilai : Form
    {
        private c_Dashboard c_Dashboard;
        public v_MemvalidasiKonversiNilai(c_Dashboard c_Dashboard)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setPengajuanMOA();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void daftarMitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDaftarMitra();
        }

        private void lihatProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setProfilTimMBKM();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setMemvalidasiKonversiSks();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardTimmbkm();
        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setPembagianTugas();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //logout
        }
    }
}

