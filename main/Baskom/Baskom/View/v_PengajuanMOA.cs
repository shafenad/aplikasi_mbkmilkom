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
    public partial class v_PengajuanMOA : Form
    {
        public v_PengajuanMOA()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ComboBox comboBox = new ComboBox();

            // Tambahkan opsi ke dropdown secara manual
            comboBox.Items.Add("Opsi 1");
            comboBox.Items.Add("Opsi 2");
            comboBox.Items.Add("Opsi 3");
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaftarMitra form3 = new DaftarMitra();
            form3.Show();
            this.Hide();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lihatProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_ProfilTimMBKM v_ProfilTimMBKM = new v_ProfilTimMBKM();
            v_ProfilTimMBKM.Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_MemvalidasiKonversiNilai v_MemvalidasiKonversiNilai = new v_MemvalidasiKonversiNilai();
            v_MemvalidasiKonversiNilai.Show();
            this.Hide();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {

        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DashboardTimmbkm v_DashboardTimmbkm = new v_DashboardTimmbkm();
            v_DashboardTimmbkm.Show();
            this.Hide();
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_PembagianTugas v_PembagianTugas = new v_PembagianTugas();
            v_PembagianTugas.Show();
            this.Hide();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_MemvalidasiKonversiSks v_MemvalidasiKonversiSks = new v_MemvalidasiKonversiSks();
            v_MemvalidasiKonversiSks.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_LoginTimmbkm v_LoginTimmbkm = new v_LoginTimmbkm();
            v_LoginTimmbkm.Show();
            this.Hide();
        }
    }
}
