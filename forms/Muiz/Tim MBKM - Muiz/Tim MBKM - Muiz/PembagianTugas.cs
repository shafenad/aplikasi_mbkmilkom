using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tim_MBKM___Muiz
{
    public partial class PembagianTugas : Form
    {
        public PembagianTugas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new PembagianTugasPIC().Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new KonversiSKS().Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginTimMBKM().Show();
            this.Hide();
        }
    }
}
