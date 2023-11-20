using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.View
{
    public partial class v_PengajuanMOA : Form
    {
        public v_PengajuanMOA()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ComboBox comboBox = new ComboBox();

            // Tambahkan opsi ke dropdown secara manual
            comboBox.Items.Add("Opsi 1");
            comboBox.Items.Add("Opsi 2");
            comboBox.Items.Add("Opsi 3");
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lihatProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {

        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
