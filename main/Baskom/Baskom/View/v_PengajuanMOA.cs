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
        List<object[]> data_pengajuan;
        List<object[]> data_status;
        object[] mitra_baru = new object[5];
        int id_status;
        bool available = false;
        public v_PengajuanMOA(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna, m_DataPengajuanMitra m_DataPengajuanMitra, m_Data_Status_Validasi_Mitra m_Data_Status_Validasi_Mitra)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_Dashboard = c_Dashboard;
            this.c_TambahPengajuanMitra = new c_TambahPengajuanMitra(m_DataPengajuanMitra, m_Data_Status_Validasi_Mitra);
            this.data_akun_pengguna = data_akun_pengguna;
            this.data_mahasiswa = data_akun_pengguna.getAttributes();
            this.data_pengajuan = c_TambahPengajuanMitra.getAllDataPengajuan();
            this.data_status = c_TambahPengajuanMitra.getDataStatus();

            this.setMOA();
        }
        public void setMOA()
        {
            tbx_namamitra.Enabled = false;
            tbx_deksripsimitra.Enabled = false;

            foreach (object[] item in data_pengajuan)
            {
                if ((int)item[4] == (int)data_mahasiswa[0])
                {
                    this.available = true;
                    this.mitra_baru = item;
                    break;
                }
            }

            if (available)
            {
                tbx_namamitra.Text = (string)mitra_baru[1];
                tbx_deksripsimitra.Text = (string)mitra_baru[2];
                this.setStatus((int)mitra_baru[3]);
            }
            else
            {
                btn_simpanstatus.Text = "Kembali";
                cbx_statusmitra.Enabled = false;
            }
        }

        public void setStatus(int id_status)
        {
            if(id_status == 1)
            {
                cbx_statusmitra.Enabled = false;
                cbx_statusmitra.Text = (string)data_status[id_status - 1][1];

            } else if (id_status == 2)
            {
                cbx_statusmitra.Text = (string)data_status[id_status - 1][1];
                cbx_statusmitra.Enabled = true;

                foreach (object[] item in data_status)
                {
                    if ((int)item[0] == id_status+1)
                    {
                        cbx_statusmitra.Items.Add(item[1]);
                    }
                }
            } else if (id_status == 3)
            {
                cbx_statusmitra.Text = (string)data_status[id_status - 1][1];
                cbx_statusmitra.Enabled = true;

                foreach (object[] item in data_status)
                {
                    if ((int)item[0] == id_status + 1)
                    {
                        cbx_statusmitra.Items.Add(item[1]);
                    }
                }
            } else if (id_status == 4)
            {
                cbx_statusmitra.Enabled = false;
                cbx_statusmitra.Text = (string)data_status[id_status - 1][1];
            } else if (id_status == 5)
            {
                cbx_statusmitra.Enabled = false;
                cbx_statusmitra.Text = (string)data_status[id_status - 1][1];
            }
        }

        private void btn_simpanstatus_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardMahasiswa();

            object status = cbx_statusmitra.SelectedItem;
            object statusDipilih = cbx_statusmitra.GetItemText(status);

            foreach (object[] item in data_status)
            {
                if ((string)item[1] == (string)statusDipilih)
                {
                    this.id_status = (int)item[0];
                }
            }

            if (id_status != 0)
            {
                c_TambahPengajuanMitra.updateStatus(id_status, (int)mitra_baru[0]);
            }
        }
        private void statusmitra_Load(object sender, EventArgs e)
        {

        }
    }
}
