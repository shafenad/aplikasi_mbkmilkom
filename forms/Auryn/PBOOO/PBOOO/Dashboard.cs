using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBOOO
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MataKuliah matakuliah = new MataKuliah();
            matakuliah.Show();
            this.Hide();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KonversiSKS konversisks = new KonversiSKS();
            konversisks.Show();
            this.Hide();
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }
    }
}
