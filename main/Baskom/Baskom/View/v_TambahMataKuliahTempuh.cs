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
    partial class v_TambahMataKuliahTempuh : Form
    {
        private c_Dashboard c_Dashboard;
        public v_TambahMataKuliahTempuh(c_Dashboard c_Dashboard)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahKonversiSks();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardMahasiswa();
        }

        private void pengajuanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setPengajuanMitra();
        }

        private void statusMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setStatusMOA();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahKonversiNilai();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setProfilMahasiswa();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setLogout();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }
    }
}
