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
using static System.Windows.Forms.DataFormats;

namespace Baskom.View
{
    partial class v_TambahMitraProgram : Form
    {
        private c_Dashboard c_Dashboard;
        private c_TambahMitraProgam c_TambahMitraProgam;
        private List<object> mitra = new List<object>();
        private List<object> program = new List<object>();
        private List<object> detail_mitra = new List<object>();
        private List<object> dropdown_mitra = new List<object>();
        private List<object> dropdown_program = new List<object>();
        public v_TambahMitraProgram(c_Dashboard c_Dashboard, m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataDetailMitra m_DataDetailMitra)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_TambahMitraProgam = new c_TambahMitraProgam(m_DataMitra, m_DataProgram, m_DataDetailMitra);
            this.init();
        }
        public void init()
        {
            dropdown_mitra.Clear();
            dropdown_program.Clear();
            cbx_namamitra.DataSource = null;
            cbx_program.DataSource = null;
            tbl_daftarprogrammitra.Rows.Clear();

            this.detail_mitra = c_TambahMitraProgam.initDetailMitra();
            this.mitra = c_TambahMitraProgam.initMitra();
            this.program = c_TambahMitraProgam.initProgram();

            foreach (object[] item in detail_mitra)
            {
                tbl_daftarprogrammitra.Rows.Add(item[1], item[0]);
            }
            foreach (object[] item in this.mitra)
            {
                dropdown_mitra.Add(item[1]);
            }
            foreach (object[] item in this.program)
            {
                dropdown_program.Add(item[1]);
            }

            cbx_namamitra.DataSource = this.dropdown_mitra;
            cbx_program.DataSource = this.dropdown_program;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbl_matakuliah_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDashboardAdmin();
        }

        private void tambahMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tambahProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setProfilAdmin();
        }

        private void tambahProgramMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void tambahProgramMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahProgramMataKuliah();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setTambahMataKuliah();
        }

        private void akunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDataDosen();
        }

        private void akunMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            c_Dashboard.setDataMahasiswa();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string message = c_TambahMitraProgam.tambahDetailMitraBaru(cbx_program.Text, cbx_namamitra.Text); ;
            if (message.Length > 0)
            {
                MessageBox.Show(message);
            }
            else
            {
                this.init();
            }
        }

        private void cbx_namamitra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setLogout();
        }
    }
}
