﻿using System;
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
    public partial class v_TambahKonversiNilai : Form
    {
        public v_TambahKonversiNilai()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*mitra form1 = new mitra();
            form1.Show();
            this.Hide();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_TambahMitra v_TambahMitra = new v_TambahMitra();
            v_TambahMitra.Show();
            this.Hide();
        }

        private void btn_simpannilai_Click(object sender, EventArgs e)
        {
            /*mitra form1 = new mitra();
            form1.Show();
            this.Hide();*/
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_ProfilMahasiswa v_ProfilMahasiswa = new v_ProfilMahasiswa();
            v_ProfilMahasiswa.Show();
            this.Hide();
        }

        private void btn_inputmatkul_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_DashboardMahasiswa v_DashboardMahasiswa = new v_DashboardMahasiswa();
            v_DashboardMahasiswa.Show();
            this.Hide();
        }

        private void statusMitraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            v_StatusMOA v_StatusMitra = new v_StatusMOA();
            v_StatusMitra.Show();
            this.Hide();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_TambahMataKuliahTempuh v_MataKuliah = new v_TambahMataKuliahTempuh();
            v_MataKuliah.Show();
            this.Hide();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_TambahKonversiSks v_TambahKonversiSks = new v_TambahKonversiSks();
            v_TambahKonversiSks.Show();
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