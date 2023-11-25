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
    public partial class v_TambahMahasiswa : Form
    {
        public v_TambahMahasiswa()
        {
            InitializeComponent();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string nama_mahasiswa = tbx_nama.Text;
            string nim = tbx_nim.Text;
            string prodi = tbx_programstudi.Text;
            string tahun_masuk = tbx_tahunmasuk.Text;

        }

        private void tbx_nim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
