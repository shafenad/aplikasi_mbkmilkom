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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
            new KonversiSKS().Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LoginTimMBKM().Show();
            this.Hide();
        }
    }
}
