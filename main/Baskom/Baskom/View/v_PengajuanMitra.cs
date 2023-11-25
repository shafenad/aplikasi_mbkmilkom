using Baskom.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.View
{
    partial class v_PengajuanMitra : Form
    {
        private c_Dashboard c_Dashboard;
        public v_PengajuanMitra(c_Dashboard c_Dashboard)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_simpanmitra_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void statusMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void lbl_tambahmitra_Click_1(object sender, EventArgs e)
        {

        }


        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pengajuanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void statusMitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setStatusMOA();
        }

        private void konversiNilaiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahKonversiNilai();
        }

        private void informasiAkunToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setProfilMahasiswa();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardMahasiswa();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahMataKuliahTempuh();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahKonversiSks();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //logout
        }

        private void mitraToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

        }
    }
}

