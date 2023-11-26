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
    partial class v_DataMahasiswa : Form
    {
        private c_Dashboard c_Dashboard;
        private c_DataMahasiswa c_DataMahasiswa;
        private List<object> array_data;
        public v_DataMahasiswa(c_Dashboard c_Dashboard, m_DataAkunMahasiswa m_DataAkunMahasiswa)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_DataMahasiswa = new c_DataMahasiswa(m_DataAkunMahasiswa);
            this.initDataGridView();
        }
        public void initDataGridView()
        {
            tbl_daftarmhsadmin.Rows.Clear();
            array_data = this.c_DataMahasiswa.initDataGridView();
            foreach (object[] item in array_data)
            {
                tbl_daftarmhsadmin.Rows.Add(item[2], item[1]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void akunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void btn_tambahdaftarmhsadmin_Click(object sender, EventArgs e)
        {
            c_Dashboard.setTambahMahasiswa();
            this.initDataGridView();
        }

        private void tbl_daftarmhsadmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //if (e.ColumnIndex ==  2 )
            //{
            //    string nim = tbl_daftarmhsadmin.Rows[i].Cells[1].Value.ToString();

            //}
        }

        private void akunDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDataDosen();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardAdmin();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setProfilAdmin();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //logout
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDataMitra();
        }

        private void tambahMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahMataKuliah();
        }

        private void tambahProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahProgram();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahMataKuliah();
        }

        private void tambahMitraProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahMitraProgram();
        }

        private void tambahProgramMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahProgramMataKuliah();
        }
    }
}
