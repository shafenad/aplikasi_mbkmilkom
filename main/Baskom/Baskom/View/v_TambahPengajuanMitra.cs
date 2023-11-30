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
    partial class v_TambahPengajuanMitra : Form
    {
        private c_Dashboard c_Dashboard;
        private m_DataAkunMahasiswa data_akun_pengguna;
        private c_TambahPengajuanMitra c_TambahPengajuanMitra;
        private object[] data_mahasiswa;
        private bool available = false;
        public v_TambahPengajuanMitra(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna, m_DataPengajuanMitra m_DataPengajuanMitra)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_TambahPengajuanMitra = new c_TambahPengajuanMitra(m_DataPengajuanMitra);
            this.data_akun_pengguna = data_akun_pengguna;
            this.data_mahasiswa = data_akun_pengguna.getAttributes();
            this.cekPernahMengajukanBelum();
        }
        public void cekPernahMengajukanBelum()
        {
            List<object[]> data_pengajuan = c_TambahPengajuanMitra.getAllDataPengajuan();

            object[] mitra_baru = new object[5];
            foreach (object[] item in data_pengajuan)
            {
                if ((int)item[4] == (int)this.data_mahasiswa[0])
                {
                    this.available = true;
                    mitra_baru = item;
                    break;
                }
            }

            if (available)
            {
                tbx_namamitra.Enabled = false;
                tbx_deksripsimitra.Enabled = false;

                tbx_namamitra.Text = mitra_baru[1].ToString();
                tbx_deksripsimitra.Text = mitra_baru[2].ToString();
                btn_pengajuan.Text = "Kembali";
            }
            else
            {
                tbx_namamitra.Enabled = true;
                tbx_deksripsimitra.Enabled = true;
                tbx_namamitra.Clear();
                tbx_deksripsimitra.Clear();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_pengajuan_Click(object sender, EventArgs e)
        {
            if (available)
            {
                this.Close();

            }
            else
            {
                object[] pengajuan_mitra = new object[4];
                pengajuan_mitra[0] = tbx_namamitra.Text;
                pengajuan_mitra[1] = tbx_deksripsimitra.Text;
                pengajuan_mitra[2] = 0;
                pengajuan_mitra[3] = this.data_mahasiswa[0];

                c_TambahPengajuanMitra.tambahPengajuanMitra(pengajuan_mitra);

                this.cekPernahMengajukanBelum();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pengajuanmitra_Load(object sender, EventArgs e)
        {

        }
    }
}
