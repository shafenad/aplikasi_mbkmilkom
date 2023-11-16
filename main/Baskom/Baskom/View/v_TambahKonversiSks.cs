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
    public partial class v_TambahKonversiSks : Form
    {
        public v_TambahKonversiSks()
        {
            InitializeComponent();
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
            v_CariMataKuliah v_CariMataKuliah = new v_CariMataKuliah();
            v_CariMataKuliah.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_TambahMataKuliahTempuh v_MataKuliah = new v_TambahMataKuliahTempuh();
            v_MataKuliah.Show();
            this.Hide();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DashboardMahasiswa v_DashboardMahasiswa = new v_DashboardMahasiswa();
            v_DashboardMahasiswa.Show();
            this.Hide();
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
            v_TambahMitra v_TambahMitra = new v_TambahMitra();
            v_TambahMitra.Show();
            this.Hide();
        }

        private void statusMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_StatusMOA v_StatusMitra = new v_StatusMOA();
            v_StatusMitra.Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_TambahKonversiNilai v_TambahKonversiNilai = new v_TambahKonversiNilai();
            v_TambahKonversiNilai.Show();
            this.Hide();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_ProfilMahasiswa v_ProfilMahasiswa = new v_ProfilMahasiswa();
            v_ProfilMahasiswa.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_LoginMahasiswa v_LoginMahasiswa = new v_LoginMahasiswa();
            v_LoginMahasiswa.Show();
            this.Hide();
        }
    }
}
