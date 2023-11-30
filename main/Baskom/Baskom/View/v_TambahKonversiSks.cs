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
    partial class v_TambahKonversiSks : Form
    {
        private c_Dashboard c_Dashboard;
        private m_DataAkunMahasiswa data_akun_pengguna;
        private c_KonversiSks c_KonversiSks;
        private object[] data_mahasiswa;
        int jumlah_sks;

        public v_TambahKonversiSks(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_KonversiSks = new c_KonversiSks();
            this.data_akun_pengguna = data_akun_pengguna;
            data_mahasiswa = data_akun_pengguna.getAttributes();

            this.setDataAkun();
        }

        private void setDataAkun()
        {
            lbl_namakonversisks.Text = (string)data_mahasiswa[2];
            lbl_nimkonversisks.Text = (string)data_mahasiswa[1];

            string inisial = (string)data_mahasiswa[2];

            string[] pisahkan = { " " };
            Int32 count = 2;

            String[] strlist = inisial.Split(pisahkan, count,
               StringSplitOptions.RemoveEmptyEntries);

            string inisialfiks = "";

            foreach (String s in strlist)
            {
                inisialfiks += s[0];
            }

            lbl_AD.Text = inisialfiks;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMataKuliahTempuh();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardMahasiswa();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KonversiSKS_Load(object sender, EventArgs e)
        {

        }

        private void tbx_kompetensikonversisks_TextChanged(object sender, EventArgs e)
        {

        }

        private void lyt_konversisks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pengajuanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPenerimaanMitra();
        }

        private void statusMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setStatusMOA();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahKonversiNilai();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilMahasiswa();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void lbl_namakonversisks_Click(object sender, EventArgs e)
        {

        }
    }
}
