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
    public partial class v_DataMahasiswa : Form
    {
        public v_DataMahasiswa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void akunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_tambahdaftarmhsadmin_Click(object sender, EventArgs e)
        {
            /*new v_TambahDataMahasiswa().Show();*/
        }

        private void tbl_daftarmhsadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*new profilemhs().Show();*/
        }

        private void akunDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DataDosen v_DataDosen = new v_DataDosen();
            v_DataDosen.Show();
            this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DashboardAdmin v_DashboardAdmin = new v_DashboardAdmin();
            v_DashboardAdmin.Show();
            this.Hide();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_ProfilAdmin v_ProfilAdmin = new v_ProfilAdmin();
            v_ProfilAdmin.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_LoginAdmin v_LoginAdmin = new v_LoginAdmin();
            v_LoginAdmin.Show();
            this.Hide();
        }
    }
}
