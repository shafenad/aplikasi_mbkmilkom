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
    partial class v_ProfilTimMBKM : Form
    {
        private c_Dashboard c_Dashboard;
        private m_DataAkunTimmbkm data_akun_pengguna;
        public v_ProfilTimMBKM(c_Dashboard c_Dashboard, m_DataAkunTimmbkm data_akun_pengguna)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.data_akun_pengguna = data_akun_pengguna;
            object[] array_data = data_akun_pengguna.getDosenAttributes();
            label3.Text = array_data[2].ToString();
            label4.Text = array_data[0].ToString();
            label6.Text = array_data[1].ToString();
            label8.Text = array_data[3].ToString();
            label10.Text = array_data[4].ToString();
        }

        private void lnk_ubahsandi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c_Dashboard.setUbahKataSandiProfil();
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardTimmbkm();
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setPengajuanMOA();
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

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setMemvalidasiKonversiNilai();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setLogout();
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDaftarMitra();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
