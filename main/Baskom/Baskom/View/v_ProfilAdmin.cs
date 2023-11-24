using Baskom.Controller;
using Baskom.Model;
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
    partial class v_ProfilAdmin : Form
    {
        c_Dashboard c_Dashboard;
        m_DataAkunAdmin data_akun_pengguna;
        public v_ProfilAdmin(c_Dashboard c_Dashboard, m_DataAkunAdmin data_akun_pengguna)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.data_akun_pengguna = data_akun_pengguna;
            object[] array_data = data_akun_pengguna.getAttributes();
            lbl_nama.Text = array_data[0].ToString();
            lbl_katasandi.Text = array_data[1].ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c_Dashboard.setFormUbahKataSandi();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardAdmin();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDataMitra();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void akunDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDataDosen();
        }

        private void akunMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDataMahasiswa();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void tambahMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahMataKuliah();
        }

        private void tambahProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahProgram();
        }
    }
}
