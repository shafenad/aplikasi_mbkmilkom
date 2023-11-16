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
    public partial class v_ProfilTimMBKM : Form
    {
        public v_ProfilTimMBKM()
        {
            InitializeComponent();
        }

        private void lnk_ubahsandi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*UbahKataSandi ubah_sandi = new UbahKataSandi();
            ubah_sandi.Show();*/
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DashboardTimmbkm v_DashboardTimmbkm = new v_DashboardTimmbkm();
            v_DashboardTimmbkm.Show();
            this.Hide();
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_PengajuanMOA v_PengajuanMOA = new v_PengajuanMOA();
            v_PengajuanMOA.Show();
            this.Hide();
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

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_MemvalidasiKonversiNilai v_MemvalidasiKonversiNilai = new v_MemvalidasiKonversiNilai();
            v_MemvalidasiKonversiNilai.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_LoginTimmbkm v_LoginTimmbkm = new v_LoginTimmbkm();
            v_LoginTimmbkm.Show();
            this.Hide();
        }
    }
}
