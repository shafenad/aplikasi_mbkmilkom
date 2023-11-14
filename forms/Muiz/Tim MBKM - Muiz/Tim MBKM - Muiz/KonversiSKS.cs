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
    public partial class KonversiSKS : Form
    {
        public KonversiSKS()
        {
            InitializeComponent();
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
            new PembagianTugas().Show();
            this.Hide();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void konversiNIlaiToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            new KonversiSKS2().Show();
            this.Hide();
        }
    }
}
