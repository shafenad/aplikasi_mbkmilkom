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
    public partial class konversinilai : Form
    {
        public konversinilai()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mitra form1 = new mitra();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pengajuanmitra form2 = new pengajuanmitra();
            form2.Show();
            this.Hide();
        }

        private void btn_simpannilai_Click(object sender, EventArgs e)
        {
            mitra form1 = new mitra();
            form1.Show();
            this.Hide();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profilmahasiswa form6 = new profilmahasiswa();
            form6.Show();
            this.Hide();
        }

        private void btn_inputmatkul_Click(object sender, EventArgs e)
        {

        }
    }
}
