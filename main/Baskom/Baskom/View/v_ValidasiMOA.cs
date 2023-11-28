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
    
    partial class v_ValidasiMOA : Form
    {
        private c_Dashboard c_Dashboard;
        private c_ValidasiMOA c_ValidasiMOA;
        List<object> data_status = new();
        List<object> data_id = new();
        public v_ValidasiMOA(c_Dashboard c_Dashboard, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataPengajuanMOA m_DataPengajuanMOA)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_ValidasiMOA = new c_ValidasiMOA(m_DataAkunMahasiswa, m_DataPengajuanMOA);
            this.init();
        }
        public void init()
        {
            this.data_status.Clear();
            this.data_id.Clear();
            tbl_statuspengajuanmoa.Rows.Clear();
            List<object[]> data = this.c_ValidasiMOA.initDataGridView();
            foreach (object[] item in data)
            {
                bool status_validasi = (int)item[3] == 1 ? true : false;
                tbl_statuspengajuanmoa.Rows.Add(item[0], item[1], item[2], status_validasi);
                this.data_status.Add((int)item[5]);
                this.data_id.Add(status_validasi);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.ColumnIndex == 3)
            {
                bool status_validasi = (bool)tbl_statuspengajuanmoa.Rows[index].Cells[3].Value;
                this.data_status[index] = status_validasi;
            }
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDaftarMitra();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lihatProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setProfilTimMBKM();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setMemvalidasiKonversiNilai();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            c_ValidasiMOA.simpanData(this.data_status, this.data_id);
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardTimmbkm();
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setLogout();
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
