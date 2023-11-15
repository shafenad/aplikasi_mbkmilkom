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
    public partial class PengajuanMOA : Form
    {
        public PengajuanMOA()
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
            DaftarMitra form3 = new DaftarMitra();
            form3.Show();
            this.Hide();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lihatProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilTimMBKM profil = new ProfilTimMBKM();
            profil.Show();
            this.Hide();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailKonversiNilai form2 = new DetailKonversiNilai();
            form2.Show();
            this.Hide();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {

        }
    }
}
