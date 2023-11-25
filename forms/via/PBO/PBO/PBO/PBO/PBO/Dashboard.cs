using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void informasiAkunToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

        }

        private void tambahMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tambahProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            ProfilAdmin form3 = new ProfilAdmin();
            form3.Show();
            this.Hide();
        }

        private void tambahMitraProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahMitraProgram form5 = new TambahMitraProgram();
            form5.Show();
            this.Hide();
        }

        private void tambahMitraMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
