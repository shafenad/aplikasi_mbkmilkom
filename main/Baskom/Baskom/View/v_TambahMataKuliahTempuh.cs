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
    public partial class v_TambahMataKuliahTempuh : Form
    {
        public v_TambahMataKuliahTempuh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_TambahKonversiSks v_TambahKonversiSks = new v_TambahKonversiSks();
            v_TambahKonversiSks.Show();
            this.Hide();
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
