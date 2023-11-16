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
    public partial class v_ProfilAdmin : Form
    {
        public v_ProfilAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            v_FormUbahKataSandi v_UbahKataSandi = new v_FormUbahKataSandi();
            v_UbahKataSandi.Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DashboardAdmin v_DashboardAdmin = new v_DashboardAdmin();
            v_DashboardAdmin.Show();
            this.Hide();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Mitra form5 = new Mitra();
            form5.Show();
            this.Hide();*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_LoginAdmin v_LoginAdmin = new v_LoginAdmin();
            v_LoginAdmin.Show();
            this.Hide();
        }

        private void akunDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DataDosen v_DataDosen = new v_DataDosen();
            v_DataDosen.Show();
            this.Hide();
        }

        private void akunMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DataMahasiswa v_DataMahasiswa = new v_DataMahasiswa();
            v_DataMahasiswa.Show();
            this.Hide();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
