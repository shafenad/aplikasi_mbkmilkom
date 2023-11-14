using System;
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
    public partial class profilmahasiswa : Form
    {
        public profilmahasiswa()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mitra form1 = new mitra();
            form1.Show();
            this.Hide();
        }

        private void statusMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mitra form3 = new mitra();
            form3.Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            konversinilai form4 = new konversinilai();
            form4.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnk_ubahsandi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formubahsandimhsw form6 = new formubahsandimhsw();
            form6.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pengajuanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusmitra form6 = new statusmitra();
            form6.Show();
            this.Hide();
        }
    }
}
