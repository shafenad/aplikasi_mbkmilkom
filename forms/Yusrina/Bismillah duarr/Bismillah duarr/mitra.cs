using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bismillah_duarr
{
    public partial class mitra : Form
    {

        public mitra()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_simpanmitra_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void statusMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pengajuanmitra Pengajuanmitra = new pengajuanmitra();
            Pengajuanmitra.Show();
            this.Hide();
        }


        private void lbl_tambahmitra_Click_1(object sender, EventArgs e)
        {
            pengajuanmitra form2 = new pengajuanmitra();
            form2.Show();
            this.Hide();
        }


        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pengajuanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void statusMitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            statusmitra Statusmitra = new statusmitra();
            Statusmitra.Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            konversinilai form4 = new konversinilai();
            form4.Show();
            this.Hide();
        }

        private void informasiAkunToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            profilmahasiswa form5 = new profilmahasiswa();
            form5.Show();
            this.Hide();
        }
    }
}

