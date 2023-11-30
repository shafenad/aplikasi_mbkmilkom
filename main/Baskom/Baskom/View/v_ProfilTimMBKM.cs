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
            object[] data_dosen = data_akun_pengguna.getDosenAttributes();
            label3.Text = (string)data_dosen[3];
            label4.Text = (string)data_dosen[1];
            label6.Text = (string)data_dosen[2];
            label8.Text = (string)data_dosen[4];
            label10.Text = (string)data_dosen[5];
        }

        private void lnk_ubahsandi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c_Dashboard.setUbahKataSandiProfil();
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardTimmbkm();
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setValidasiMOA();
        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPembagianTugas();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiSks();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiNilai();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
