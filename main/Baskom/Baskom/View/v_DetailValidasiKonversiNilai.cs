using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baskom.Model;

namespace Baskom.View
{
    partial class v_DetailValidasiKonversiNilai : Form
    {
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataKonversiNilai m_DataKonversiNilai;
        m_DataMataKuliah m_DataMataKuliah;
        public v_DetailValidasiKonversiNilai(string nama_mhs, string nim, string nama_mitra,string prodi, string program, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataKonversiNilai m_DataKonversiNilai, m_DataMataKuliah m_DataMataKuliah)
        {
            InitializeComponent();
            lbl_nama.Text = nama_mhs;
            lbl_nim.Text = nim;
            lbl_mitra.Text = nama_mitra;
            lbl_prodi.Text = prodi;
            lbl_posisi.Text = program;
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataKonversiNilai = m_DataKonversiNilai;
            this.m_DataMataKuliah = m_DataMataKuliah;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbl_detailkonversinilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
