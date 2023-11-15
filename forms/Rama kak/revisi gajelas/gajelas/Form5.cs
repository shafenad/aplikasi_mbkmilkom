using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gajelas
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DaftarMitra form3 = new DaftarMitra();
            form3.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UbahKataSandi form6 = new UbahKataSandi();  
            form6.Show();
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PengajuanMOA form4 = new PengajuanMOA();
            form4.Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailKonversiNilai form2 = new DetailKonversiNilai();
            form2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
