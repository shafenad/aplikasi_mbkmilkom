using Baskom.Controller;
using Baskom.Model;
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
    partial class v_TambahMahasiswa : Form
    {
        c_TambahMahasiswa c_TambahMahasiswa;
        public v_TambahMahasiswa(m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataProdi m_DataProdi, m_DataAkunTimmbkm m_DataAkunTimmbkm)
        {
            InitializeComponent();
            this.c_TambahMahasiswa = new c_TambahMahasiswa(m_DataAkunMahasiswa, m_DataProdi, m_DataAkunTimmbkm);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_tambahtambahmhs_Click(object sender, EventArgs e)
        {
            string message = "";
            if (!int.TryParse(tbx_tahunmasukmahasiswatambahmhs.Text, out _))
            {
                message = "Tahun Masuk Bernilai Angka!";
                MessageBox.Show(message);
            }
            else if (!int.TryParse(tbx_bacthmahasiswatambahmhs.Text, out _))
            {
                message = "Batch MBKM Bernilai Angka!";
                MessageBox.Show(message);
            }
            else
            {
                object[] mahasiswa = new object[9];
                mahasiswa[0] = tbx_nimhasiswatambahmhs.Text;
                mahasiswa[1] = tbx_namamahasiswatambahmhs.Text;
                mahasiswa[2] = int.Parse(tbx_tahunmasukmahasiswatambahmhs.Text);
                mahasiswa[3] = cmbstatusmahasiswamhs.Text == "Aktif" ? 1 : 0;
                mahasiswa[4] = tbx_nowamahasiswatambahmhs.Text;
                mahasiswa[5] = int.Parse(tbx_bacthmahasiswatambahmhs.Text);
                mahasiswa[6] = tbx_emailmahasiswatambahmhs.Text;
                mahasiswa[7] = tbx_katasandimahasiswatambahmhs.Text;
                mahasiswa[8] = cmbprogramstudimhs.Text;
                message = c_TambahMahasiswa.tambahMahasiswaBaru(mahasiswa);
                if (message.Length > 0)
                {
                    MessageBox.Show(message);
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
