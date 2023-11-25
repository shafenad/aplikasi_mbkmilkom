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
    public partial class TambahMataKuliah : Form
    {
        public TambahMataKuliah()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void tambahProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahMitraProgram form2 = new TambahMitraProgram();
            form2.Show();
            this.Hide();
        }

        private void informasiAkunToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void tambahProgramMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TambahMitraProgram form7 = new TambahMitraProgram();
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
