﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bismillah_duarr
{
    public partial class pengajuanmitra : Form
    {
        public pengajuanmitra()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_pengajuan_Click(object sender, EventArgs e)
        {
            mitra form1 = new mitra();
            form1.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pengajuanmitra_Load(object sender, EventArgs e)
        {

        }
    }
}
