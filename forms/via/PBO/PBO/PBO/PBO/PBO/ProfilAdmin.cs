﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO
{
    public partial class ProfilAdmin : Form
    {
        public ProfilAdmin()
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
            UbahKataSandiProfil form4 = new UbahKataSandiProfil();
            form4.Show();
            this.Hide();
        }

        private void akunTimMBKMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dashboard form2 = new Dashboard();
            form2.Show();
            this.Hide();
        }

        private void mitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TambahMitraProgram form5 = new TambahMitraProgram();
            form5.Show();
            this.Hide();
        }

        private void tambahMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahMataKuliah form1 = new TambahMataKuliah();
            form1.Show();
            this.Hide();
        }

        private void tambahProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahProgramMataKuliah form2 = new TambahProgramMataKuliah();
            form2.Show();
            this.Hide();
        }

        private void tambahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahMitraProgram form5 = new TambahMitraProgram();
            form5.Show();
            this.Hide();
        }

        private void tambahProgramMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahProgramMataKuliah form7 = new TambahProgramMataKuliah();
            form7.Show();
            this.Hide();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahMataKuliah form6 = new TambahMataKuliah();
            form6.Show();
            this.Hide();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilAdmin form3 = new ProfilAdmin();
            form3.Show();
            this.Hide();
        }
    }
}
