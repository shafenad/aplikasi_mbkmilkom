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
    public partial class v_DashboardAdmin : Form
    {
        private object data_akun_pengguna;

        public v_DashboardAdmin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_ProfilAdmin v_ProfilAdmin = new v_ProfilAdmin();
            v_ProfilAdmin.Show();
            this.Hide();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Mitra form5 = new Mitra();
            form5.Show();
            this.Hide();*/
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void akunDosesToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_LoginAdmin v_LoginAdmin = new v_LoginAdmin();
            v_LoginAdmin.Show();
            this.Hide();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
