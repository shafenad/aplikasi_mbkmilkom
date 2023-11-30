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
    public partial class v_DetailValidasiKonversiSks : Form
    {
        public v_DetailValidasiKonversiSks(string nama_mhs, string nim, string nama_mitra)
        {
            InitializeComponent();
            lbl_NamaOrang.Text = nama_mhs;
            lbl_NIM.Text = nim;
            lbl_namamitra.Text = nama_mitra;
        }
        private void btn_simpan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
