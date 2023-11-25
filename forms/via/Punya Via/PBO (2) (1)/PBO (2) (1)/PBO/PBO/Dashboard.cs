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
            Mitra form5 = new Mitra();
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
            TambahProgram form2 = new TambahProgram();
            form2.Show();
            this.Hide();
        }

        private void informasiAkunToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            ProfilAdmin form3 = new ProfilAdmin();
            form3.Show();
            this.Hide();
        }

        private void akunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*TambahDosen form1 = new TambahDosen();
            form1.Show();
            this.Hide();*/
        }

        private void akunMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*TambahMahasiswa form2 = new TambahMahasiswa();
            form2.Show();
            this.Hide();*/
        }
    }
}
