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
    partial class v_PengajuanMOA : Form
    {
        private c_Dashboard c_Dashboard;
        private m_DataAkunMahasiswa data_akun_pengguna;
        private c_TambahPengajuanMitra c_TambahPengajuanMitra;
        object[] data_mahasiswa;
        bool available = false;
        public v_PengajuanMOA(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna, m_DataPengajuanMitra m_DataPengajuanMitra)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_Dashboard = c_Dashboard;
            this.c_TambahPengajuanMitra = new c_TambahPengajuanMitra(m_DataPengajuanMitra);
            this.data_akun_pengguna = data_akun_pengguna;
            data_mahasiswa = data_akun_pengguna.getAttributes();

            this.setMOA();
        }
        public void setMOA()
        {
            List<object[]> data_pengajuan = c_TambahPengajuanMitra.getAllDataPengajuan();
            tbx_namamitra.Enabled = false;
            tbx_deksripsimitra.Enabled = false;

            object[] mitra_baru = new object[5];
            foreach (object[] item in data_pengajuan)
            {
                if ((int)item[4] == (int)data_mahasiswa[0])
                {
                    this.available = true;
                    mitra_baru = item;
                    break;
                }
            }

            if (available)
            {
                cbx_statusmitra.Enabled = true;

                tbx_namamitra.Text = (string)mitra_baru[1];
                tbx_deksripsimitra.Text = (string)mitra_baru[2];
            }
            else
            {
                btn_simpanstatus.Text = "Kembali";
                cbx_statusmitra.Enabled = false;
            }
        }
        private void btn_simpanstatus_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardMahasiswa();
        }
        private void statusmitra_Load(object sender, EventArgs e)
        {

        }
    }
}
