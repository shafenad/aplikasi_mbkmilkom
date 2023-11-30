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
        List<bool> data_status = new();
        List<int> data_id = new();
        public v_ValidasiMOA(c_Dashboard c_Dashboard, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataPengajuanMitra m_DataPengajuanMOA)
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
                bool status_validasi = (Convert.ToInt32(item[3])) == 1 ? true : false;
                tbl_statuspengajuanmoa.Rows.Add(item[0], item[1], item[2], status_validasi);
                this.data_id.Add((int)item[4]);
                this.data_status.Add(status_validasi);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //label2.Text = Convert.ToBoolean(tbl_statuspengajuanmoa.Rows[e.RowIndex].Cells[3].Value)? "True":"False";
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDaftarMitra();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lihatProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilTimMBKM();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiNilai();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.data_id.Count; i++)
            {
                bool status_validasi = Convert.ToBoolean(tbl_statuspengajuanmoa.Rows[i].Cells[3].Value);
                this.data_status[i] = status_validasi;
            }
            c_ValidasiMOA.simpanData(this.data_status, this.data_id);
            this.init();
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardTimmbkm();
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
