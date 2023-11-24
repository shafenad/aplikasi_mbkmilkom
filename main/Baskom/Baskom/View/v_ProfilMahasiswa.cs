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
using Baskom.Model;

namespace Baskom.View
{
    partial class v_ProfilMahasiswa : Form
    {
        m_DataAkunMahasiswa data_akun_pengguna;
        private c_Dashboard c_Dashboard;
        public v_ProfilMahasiswa(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.data_akun_pengguna = data_akun_pengguna;
            object[] array_data = data_akun_pengguna.getAttributes();
            lbl_namamahasiswa.Text = array_data[2].ToString();
            lbl_nimmahasiswa.Text = array_data[1].ToString();
            lbl_prodi.Text = array_data[9].ToString();
            lbl_thnmasuk.Text = array_data[3].ToString();
            lbl_status.Text = (bool)array_data[4] ? "Aktif" : "Tidak Aktif";
            lbl_nowa.Text = array_data[5].ToString();
            lbl_batch.Text = array_data[6].ToString();
            lbl_email.Text = array_data[7].ToString();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahKonversiNilai();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnk_ubahsandi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c_Dashboard.setFormUbahKataSandi();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pengajuanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardMahasiswa();
        }

        private void pengajuanMitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setPengajuanMitra();
        }

        private void statusMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setStatusMOA();
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
            //logour
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }
    }
}
