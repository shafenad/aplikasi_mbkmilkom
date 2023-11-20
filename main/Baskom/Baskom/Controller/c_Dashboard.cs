using Baskom.Model;
using Baskom.View;
using Baskom.View_Lama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    class c_Dashboard
    {
        protected object? data_akun_pengguna;
        protected m_DataAkunDosen? m_DataAkunDosen;
        protected m_DataAkunMahasiswa? m_DataAkunMahasiswa;
        protected m_DataAkunTimmbkm? m_DataAkunTimmbkm;
        protected m_DataDetailMitra? m_DataDetailMitra;
        protected m_DataDetailProgram? m_DataDetailProgram;
        protected m_DataKonversiNilai? m_DataKonversiNilai;
        protected m_DataKonversiSks? m_DataKonversiSks;
        protected m_DataMataKuliah? m_DataMataKuliah;
        protected m_DataMataKuliahTempuh? m_DataMataKuliahTempuh;
        protected m_DataPenerimaan? m_DataPenerimaan;
        protected m_DataProgram? m_DataProgram;
        private v_ManajemenProfilDosen? v_ManajemenProfilDosen;
        private v_ManajemenProfilMahasiswa? v_ManajemenProfilMahasiswa;
        private object? v_MemvalidasiPengajuanMitra;
        private v_PembagianTugas? v_PembagianTugas;
        private v_TambahKonversiNilai? v_TambahKonversiNilai;
        private v_TambahKonversiSks? v_TambahKonversiSks;
        private v_TambahMataKuliahTempuh? v_TambahMataKuliahTempuh;
        private v_TambahMitra? v_TambahMitra;
        private v_TambahPengajuanMitra? v_TambahPengajuanMitra;
        private v_DashboardMahasiswa v_DashboardMahasiswa;
        private v_DashboardAdmin v_DashboardAdmin;
        private v_DashboardTimmbkm v_DashboardTimmbkm;

        public c_Dashboard(object data_akun_pengguna)
        {
            this.data_akun_pengguna = data_akun_pengguna;
            if (data_akun_pengguna.GetType() == typeof(m_DataAkunMahasiswa))
            {
                v_DashboardMahasiswa v_DashboardMahasiswa = new(this);
                this.v_DashboardMahasiswa = v_DashboardMahasiswa;
            }
            else if (data_akun_pengguna.GetType() == typeof(m_DataAkunAdmin))
            {
                v_DashboardAdmin v_DashboardAdmin = new(this);
                this.v_DashboardAdmin = v_DashboardAdmin;
            }
            else if (data_akun_pengguna.GetType() == typeof(m_DataAkunTimmbkm))
            {
                v_DashboardTimmbkm v_DashboardTimmbkm = new(this);
                this.v_DashboardTimmbkm = v_DashboardTimmbkm;
            }
        }
        public void setDashboardMahasiswa()
        {
            this.v_DashboardMahasiswa.Show();
        }
        public void setDashboardAdmin()
        {
            v_DashboardAdmin.Show();
        }
        public void setDashboardTimmbkm()
        {
            v_DashboardTimmbkm.Show();
        }

        public void logout() { }
        public void setMelihatKonversiNilai() { }
        public void setTambahKonversiNilai() { }
        public void setLogin() { }
        public void setManajemenProfilDosen() { }
        public void setManajemenProfilMahasiswa() { }
        public void setMataKuliah() { }
        public void setMelihatKonversiSks() { }
        public void setPengajuanMitra() { }
        public void setValidasiPengajuanMitra() { }
        public void setProfil(object data_akun_pengguna) { }
        public void setTambahKonversiSks() { }
        public void setTambahMitra() { }
        public void setPembagianTugas() { }
        public void showDataAkun(string nama_mahasiswa, string nim) { }
    }
}
