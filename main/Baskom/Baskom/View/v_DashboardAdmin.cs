﻿using Baskom.Controller;
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
    partial class v_DashboardAdmin : Form
    {
        c_Dashboard c_Dashboard;
        public v_DashboardAdmin(c_Dashboard c_Dashboard)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Mitra form5 = new Mitra();
            form5.Show();
            this.Hide();*/
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c_Dashboard.setDashboardAdmin();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void akunDosesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void akunMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manajemenAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
